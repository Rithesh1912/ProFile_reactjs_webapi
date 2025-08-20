using CasmanSln.DataAccess.Interface;
using CasmanSln.Dtos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CasmanSln.DataAccess.Repository
{
    public class UserManager : IUserManager
    {
        private readonly string _connectionString;

        public UserManager(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<bool> InsertUserAndStaffAsync(UserStaffDto dto)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("InsertUserAndStaff", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User_ID", dto.UserId);
                cmd.Parameters.AddWithValue("@Staff_ID", dto.StaffId);
                cmd.Parameters.AddWithValue("@First_Name", dto.First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", dto.Last_Name);
                cmd.Parameters.AddWithValue("@Dept_ID", dto.DeptId);
                cmd.Parameters.AddWithValue("@Team", dto.Team);
                cmd.Parameters.AddWithValue("@ROLE",dto.Role);
                cmd.Parameters.AddWithValue("@Team_ID", dto.TeamId);
                cmd.Parameters.AddWithValue("@modified_by", dto.ModifiedBy);

                await conn.OpenAsync();
                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                return rowsAffected > 0;
            }
        }
    }
}

