using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;

namespace CasmanSln.Services.Interface
{
    public interface IAuthService
    {
        Task<LoginResponseDto>StaffLogin(LoginRequestDto request);
        Task<string> Register(StaffRegisterRequestDto request);
    }
}
