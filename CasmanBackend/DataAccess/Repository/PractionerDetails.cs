using CasmanSln.DataAccess.Interface;
using CasmanSln.Models;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Data;

namespace CasmanSln.DataAccess.Repository
{
    public class PractionerDetails : IPractionerDetails
    {
        private readonly CasmanDbContext _context;
        private readonly IConfiguration _configuration;

        public PractionerDetails(CasmanDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<List<CasePractioner>> GetAllPractionerDetails()
        {
            var practionerdetails = await _context.t_case_prac.ToListAsync();
            return practionerdetails;
        }

        public async Task<CasePractioner> GetPractionerByCaseId(string caseId, string subId)
        {
            string FullCaseId = caseId + "-" + subId;
            var practionerdetail = await _context.t_case_prac.FirstOrDefaultAsync(c => c.CaseId == caseId && c.SubsidId == subId);
            return practionerdetail;
        }

        public async Task<CasePractioner> CreatePractioner(CasePractioner newPrac)
        {
            var currentYear = DateTime.Now.Year % 100; // 25 for 2025
            string yearPrefix = currentYear.ToString("D2"); // "25"

            // Find the last CaseId for this year (string comparison)
            var lastCase = await _context.t_case
                .Where(c => c.CaseId.StartsWith(yearPrefix))
                .OrderByDescending(c => c.CaseId)
                .FirstOrDefaultAsync();

            int sequence = 1;
            if (lastCase != null)
            {
                // Take the numeric part after the year and increment
                sequence = int.Parse(lastCase.CaseId.Substring(2)) + 1;
            }

            // Build CaseId in format YY00001
            string CaseId = $"{yearPrefix}{sequence:D5}";
            string SubId = "00";
            var newPractioner = new CasePractioner()
            {
                CaseId = CaseId,
                SubsidId = SubId,
                PracFirstName = newPrac.PracFirstName,
                PracLastName = newPrac.PracLastName,
                PracSex = newPrac.PracSex,
                PracNum = newPrac.PracNum,
                PracRole = "Lead"

            };
            _context.t_case_prac.Add(newPractioner);
            await _context.SaveChangesAsync();


            return newPractioner;

        }

        public async Task<bool> UpdatePractionerDetails(string PracNum, CasePractioner UpdatedcasePractioner)
        {
            var prac = await _context.t_case_prac.FirstOrDefaultAsync(x => x.PracNum == PracNum);
            if (prac == null)
            {
                return false;
            }
            prac.PracFirstName = UpdatedcasePractioner.PracFirstName;
            prac.PracLastName = UpdatedcasePractioner.PracLastName;
            prac.PracSex = UpdatedcasePractioner.PracSex;
            prac.PracRole = UpdatedcasePractioner.PracRole;

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeletePractioner(string pracNum)
        {
            var prac = await _context.t_case_prac
                .FirstOrDefaultAsync(x => x.PracNum == pracNum);

            if (prac == null)
                return false;

            _context.t_case_prac.Remove(prac);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<AddPractResponseDto> AddPractitionerDetails(AddPractRequestDto request)
        {
            var response = new AddPractResponseDto();
            var connectionString = _configuration.GetConnectionString("CasmanConnection");

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("dbo.CD_SP_PRACDETAILS_PRU", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CaseId", request.CaseId);
                    cmd.Parameters.AddWithValue("@SubsidId", request.SubsidId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracNum", request.PracNum ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SurName", request.SurName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ForeName", request.ForeName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Initial", request.Initial ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sex", request.Sex ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Indemnifier", request.Indemnifier ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role", request.Role ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PercentinvolMdu", request.PercentInvolMdu ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfInvolved", request.DateOfInvolved == default ? (object)DBNull.Value : request.DateOfInvolved);
                    cmd.Parameters.AddWithValue("@DateOfNotifiedMdu", request.DateOfNotifiedMdu == default ? (object)DBNull.Value : request.DateOfNotifiedMdu);
                    cmd.Parameters.AddWithValue("@DateClaimMode", request.DateClaimMode == default ? (object)DBNull.Value : request.DateClaimMode);
                    cmd.Parameters.AddWithValue("@SpecialityOfDOI", request.SpecialityOfDOI ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserId", request.UserId ?? (object)DBNull.Value);

                    await conn.OpenAsync();
                    int rows = await cmd.ExecuteNonQueryAsync();

                    if (rows > 0)
                    {
                        response.IsSuccess = true;
                        response.Message = "Practitioner details inserted successfully.";
                    }
                    else
                    {
                        response.IsSuccess = false;
                        response.Message = "Insert failed. No rows affected.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                response.IsSuccess = false;
                response.Message = $"Database error: {sqlEx.Message}";
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = $"Unexpected error: {ex.Message}";
            }

            return response;
        }

    }




}
