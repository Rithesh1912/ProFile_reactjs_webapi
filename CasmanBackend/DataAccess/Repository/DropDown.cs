using CasmanSln.DataAccess.Interface;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CasmanSln.Repositories
{
    public class Drpdwns : IDrpdwns
    {
        private readonly string _connectionString;

        public Drpdwns(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<List<string>> GetIndemnifiersDropdown(string? value = null)
        {
            var result = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Value", (object?)value ?? DBNull.Value);

                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader["Def_Org_Name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error in GetIndemnifiersDropdown: {ex.Message}");
                throw; 
            }

            return result;
        }


        public async Task<List<string>> GetSpecialtiesDropdown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    
                    cmd.Parameters.AddWithValue("@ForSpecialty", 1);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            
                            result.Add(reader["SpcltyDesc"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Error in GetSpecialtiesDropdown: {ex.Message}");
                throw; 
            }

            return result;
        }
        public async Task<List<string>> GetLiabilitiesDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForLiability", 1);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader["Liab_Desc"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetLiabilitiesDropdown: {ex.Message}");
                throw;
            }

            return result;
        }

        public async Task<List<string>> GetCaseTypeDescriptionsDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCaseType", 4);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCaseTypeDescriptionsAsync: " + ex.Message, ex);
            }

            return result;
        }

        public async Task<List<string>> GetCaseStatusDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCaseStatus", 5);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(1));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCaseStatus: " +ex.Message, ex);
            }
            return result;

        }
        public async Task<List<string>> GetDepartmentDropDown()
        {
            var result = new List<string>();

            try
            {
                using ( var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForDepartment", 6);

                    await conn.OpenAsync();

                    using( var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(1));
                        }
                    }

                }
                
            }
            catch(Exception ex)
            {
                throw new Exception("Error in GetDepartmentDropDown: " + ex.Message, ex);
            }
            return result;

        }
        public async Task<List<string>> GetCaseCategoryDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCaseCategory", 7);

                    await conn.OpenAsync();
                   
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while(await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(1));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCaseCategoryDropDown: " + ex.Message, ex);
            }
            return result;
        }
        public async Task<List<string>> GetCasePracticeDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCasePractice", 8);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(1));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCasePracticeDropDown: " + ex.Message, ex);
            }
            return result;
        }

        public async Task<List<string>> GetCaseFileClassificationDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForFileClassification", 9);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(1));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCaseFileClassificationDropDown: " + ex.Message, ex);
            }
            return result;
        }

        public async Task<List<string>> GetCaseHandler1DropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCaseHandler", 10);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(0));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCaseHandler1DropDown: " + ex.Message, ex);
            }
            return result;
        }

        public async Task<List<string>> GetCaseHandler2DropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCaseHandler", 10);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(0));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCaseHandler2DropDown: " + ex.Message, ex);
            }
            return result;
        }

        public async Task<List<string>> GetCountryDropDown()
        {
            var result = new List<string>();

            try
            {
                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ForCountry", 11);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(reader.GetString(0));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetCountryDropDown: " + ex.Message, ex);
            }
            return result;
        }


    }

}



