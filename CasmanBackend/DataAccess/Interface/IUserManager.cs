using CasmanSln.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CasmanSln.DataAccess.Interface
{
    public interface IUserManager
    {

        Task<bool> InsertUserAndStaffAsync(UserStaffDto dto);

    }
}
