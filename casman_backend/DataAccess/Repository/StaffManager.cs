using casman.DataAccess.Interface;
using casman.Models;

namespace casman.DataAccess.Repository
{
    using casman.DataAccess.Interface;
    using casman.ResponseDtos;
    using global::casman.ResponseDtos;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;

    namespace casman.DataAccess.Repository
    {
        public class StaffManager : IStaffManager
        {
            private readonly string _connectionString;

            public StaffManager(IConfiguration configuration)
            {
                _connectionString = configuration.GetConnectionString("CasmanConnection");
            }

            public async Task<StaffResponseDto?> GetAllStaffDetails(string staffId)
            {
                using var conn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand("ADM_SP_GETUSERDETAILS_RTR", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@STAFF_ID", staffId ?? string.Empty);

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new StaffResponseDto
                    {
                        USER_ID = reader["USER_ID"]?.ToString(),
                        ROLE = reader["ROLE"]?.ToString(),
                        STAFF_NO = reader["STAFF_NO"]?.ToString(),
                        STAFF_ID = reader["STAFF_ID"]?.ToString(),
                        STAFF_NAME = reader["STAFF_NAME"]?.ToString(),
                        DEPT_ID = reader["DEPT_ID"]?.ToString(),
                        VALID = reader["VALID"]?.ToString(),
                        SECRETARIAT = reader["SECRETARIAT"]?.ToString(),
                        ADV_MGT = reader["ADV_MGT"]?.ToString(),
                        CLMS_MGT = reader["CLMS_MGT"]?.ToString(),
                        TEAM = Convert.ToBoolean(reader["TEAM"]),
                        ISSOL = Convert.ToBoolean(reader["ISSOL"]),
                        AUTH_CASESCMTE = reader["AUTH_CASESCMTE"]?.ToString()
                    };
                }

                return null; // no data found
            }
        }
    }

}
