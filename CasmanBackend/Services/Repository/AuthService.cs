
using CasmanSln.Models;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using CasmanSln.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Casman.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly CasmanDbContext _context;

        public AuthService(IConfiguration configuration,CasmanDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task<string> Register(StaffRegisterRequestDto request)
        {
            // check if user already exists
            if (await _context.t_staff.AnyAsync(s => s.StaffId == request.StaffId))
            {
                return "Staff already exists!";
            }

            // hash password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var staff = new Staff
            {
             
                StaffNo = request.StaffNo,
                StaffId = request.StaffId,
                StaffName = request.StaffName,
                DeptId = request.DeptId,
                Team = request.Team,
                TeamId = request.TeamId,
                ModifiedBy = request.ModifiedBy,
                PasswordHash = passwordHash
            };

            _context.t_staff.Add(staff);
            await _context.SaveChangesAsync();

            return "Added Staff Successfully";
        }

     public async Task<LoginResponseDto>StaffLogin(LoginRequestDto requestDto)
        {

            var staff = await _context.t_staff.FirstOrDefaultAsync(s => s.StaffId == requestDto.StaffId);
            if (staff == null || !BCrypt.Net.BCrypt.Verify(requestDto.Password, staff.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid credentials");
            }

            // create JWT token
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, staff.StaffId),
                new Claim("staffName", staff.StaffName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new LoginResponseDto
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                StaffId = staff.StaffId,
                StaffName = staff.StaffName
            };
        }

    }
}
