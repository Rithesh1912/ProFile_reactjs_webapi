using casman.Data;
using casman.DataAccess.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace casman.DataAccess.Repository
{
    public class StoredProcedureExecutor : IStoredProcedureExecutor
    {
        private readonly CasmanDbContext _context;

        public StoredProcedureExecutor(CasmanDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> ListAsync<T>(string storedProcedure, object parameters = null) where T : class
        {
            var sqlParameters = GetSqlParameters(parameters);
            var sql = BuildExecSql(storedProcedure, sqlParameters);

            return await _context.Set<T>()
                .FromSqlRaw(sql, sqlParameters.ToArray())
                .ToListAsync();
        }

        public async Task<int> ExecuteAsync(string storedProcedure, object parameters = null)
        {
            var sqlParameters = GetSqlParameters(parameters);
            var sql = BuildExecSql(storedProcedure, sqlParameters);

            return await _context.Database.ExecuteSqlRawAsync(sql, sqlParameters.ToArray());
        }

        private List<SqlParameter> GetSqlParameters(object parameters)
        {
            var sqlParams = new List<SqlParameter>();
            if (parameters != null)
            {
                foreach (var prop in parameters.GetType().GetProperties())
                {
                    sqlParams.Add(new SqlParameter("@" + prop.Name, prop.GetValue(parameters) ?? DBNull.Value));
                }
            }
            return sqlParams;
        }

        private string BuildExecSql(string storedProcedure, List<SqlParameter> sqlParameters)
        {
            var paramNames = string.Join(", ", sqlParameters.Select(p => p.ParameterName));
            return $"EXEC {storedProcedure} {paramNames}";
        }
    }

    }



