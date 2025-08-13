using casman.DataAccess.Interface;
using Microsoft.Data.SqlClient;
using System.Data;

namespace casman.DataAccess.Repository
{
    public class SearchCase : ISearchCase
    {
        private readonly string _connectionString;

        public SearchCase(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<Dictionary<string, object>?> SearchCaseDetails(string caseID, string subId)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("CD_SP_SEARCHCASES_RTR", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@CaseID", caseID ?? string.Empty);
            cmd.Parameters.AddWithValue("@SubID", subId ?? string.Empty);

            await conn.OpenAsync();

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var result = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                }
                return result;
            }

            return null; // No data found
        }
    }
}
