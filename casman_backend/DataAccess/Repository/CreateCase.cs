using casman.DataAccess.Interface;
using casman.RequestDtos;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace casman.DataAccess.Repository
{
    public class CreateCase : ICreateCase
    {
        private readonly string _connectionString;

        public CreateCase(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<Dictionary<string, object>?> CreateNewCase(CreateCaseDto dto)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("ADM_SP_CREATENEWCASE_PRI", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@prac_num", dto.prac_num ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_role", dto.prac_role ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_last_name", dto.prac_last_name ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_first_name", dto.prac_first_name ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_init", dto.prac_init ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_sex", dto.prac_sex ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_def_org", dto.prac_def_org ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_tow", dto.prac_tow ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@prac_source", dto.prac_source ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@userid", dto.user_id ?? (object)DBNull.Value);

            await conn.OpenAsync();

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var result = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                }
                return result;
            }

            return null;
        }
    }
}
