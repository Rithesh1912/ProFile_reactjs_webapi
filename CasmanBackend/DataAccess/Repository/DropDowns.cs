using CasmanSln.DataAccess.Interface;
using CasmanSln.Dtos;
using CasmanSln.Models;

using CasmanSln.ResponseDtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CasmanSln.Repositories
{
    public class Drpdwns : IDropDowns
    {
        private readonly string _connectionString;

        public Drpdwns(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        //        public async Task<List<string>> GetIndemnifiersDropdown(string? value = null)
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (SqlConnection conn = new SqlConnection(_connectionString))
        //                using (SqlCommand cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@Value", (object?)value ?? DBNull.Value);

        //                    await conn.OpenAsync();
        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader["Def_Org_Name"].ToString());
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine($"Error in GetIndemnifiersDropdown: {ex.Message}");
        //                throw; 
        //            }

        //            return result;
        //        }


        //        public async Task<List<string>> GetSpecialtiesDropdown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;


        //                    cmd.Parameters.AddWithValue("@ForSpecialty", 1);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {

        //                            result.Add(reader["SpcltyDesc"].ToString());
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {

        //                Console.WriteLine($"Error in GetSpecialtiesDropdown: {ex.Message}");
        //                throw; 
        //            }

        //            return result;
        //        }
        //        public async Task<List<string>> GetLiabilitiesDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForLiability", 1);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader["Liab_Desc"].ToString());
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine($"Error in GetLiabilitiesDropdown: {ex.Message}");
        //                throw;
        //            }

        //            return result;
        //        }

        //        public async Task<List<string>> GetCaseTypeDescriptionsDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCaseType", 4);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(0));
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCaseTypeDescriptionsAsync: " + ex.Message, ex);
        //            }

        //            return result;
        //        }

        //        public async Task<List<string>> GetCaseStatusDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR",conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCaseStatus", 5);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(1));
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCaseStatus: " +ex.Message, ex);
        //            }
        //            return result;

        //        }
        //        public async Task<List<string>> GetDepartmentDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using ( var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForDepartment", 6);

        //                    await conn.OpenAsync();

        //                    using( var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(1));
        //                        }
        //                    }

        //                }

        //            }
        //            catch(Exception ex)
        //            {
        //                throw new Exception("Error in GetDepartmentDropDown: " + ex.Message, ex);
        //            }
        //            return result;

        //        }
        //        public async Task<List<string>> GetCaseCategoryDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCaseCategory", 7);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while(await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(1));
        //                        }
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCaseCategoryDropDown: " + ex.Message, ex);
        //            }
        //            return result;
        //        }
        //        public async Task<List<string>> GetCasePracticeDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCasePractice", 8);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(1));
        //                        }
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCasePracticeDropDown: " + ex.Message, ex);
        //            }
        //            return result;
        //        }

        //        public async Task<List<string>> GetCaseFileClassificationDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForFileClassification", 9);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(1));
        //                        }
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCaseFileClassificationDropDown: " + ex.Message, ex);
        //            }
        //            return result;
        //        }

        //        public async Task<List<string>> GetCaseHandler1DropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCaseHandler", 10);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(0));
        //                        }
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCaseHandler1DropDown: " + ex.Message, ex);
        //            }
        //            return result;
        //        }

        //        public async Task<List<string>> GetCaseHandler2DropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCaseHandler", 10);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(0));
        //                        }
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCaseHandler2DropDown: " + ex.Message, ex);
        //            }
        //            return result;
        //        }

        //        public async Task<List<string>> GetCountryDropDown()
        //        {
        //            var result = new List<string>();

        //            try
        //            {
        //                using (var conn = new SqlConnection(_connectionString))
        //                using (var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn))
        //                {
        //                    cmd.CommandType = CommandType.StoredProcedure;
        //                    cmd.Parameters.AddWithValue("@ForCountry", 11);

        //                    await conn.OpenAsync();

        //                    using (var reader = await cmd.ExecuteReaderAsync())
        //                    {
        //                        while (await reader.ReadAsync())
        //                        {
        //                            result.Add(reader.GetString(0));
        //                        }
        //                    }

        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("Error in GetCountryDropDown: " + ex.Message, ex);
        //            }
        //            return result;
        //        }


        //    }

        //}

        public async Task<DropdownResponseDto> GetAllDropdowns()
        {
            var result = new DropdownResponseDto();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand("CMS_SP_MASTER_RTR", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();

                // 1️⃣ Specialties
                while (await reader.ReadAsync())
                    result.Specialties.Add(reader.GetString(1)); // SpcltyDesc

                // 2️⃣ Liabilities
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Liabilities.Add(reader.GetString(0));

                // 3️⃣ Case Types
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.CaseTypes.Add(reader.GetString(0));

                // 4️⃣ Statuses
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Statuses.Add(reader.GetString(1));

                // 5️⃣ Departments
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Departments.Add(reader.GetString(1));

                // 6️⃣ Categories
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Categories.Add(reader.GetString(1));

                // 7️⃣ Practices
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Practices.Add(reader.GetString(1));

                // 8️⃣ Classifications
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Classifications.Add(reader.GetString(1));

                // 9️⃣ Staff
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Staff.Add(reader.GetString(0));

                // 🔟 Countries
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Countries.Add(reader.GetString(0));

                // 1️⃣1️⃣ Indemnifiers
                await reader.NextResultAsync();
                while (await reader.ReadAsync())
                    result.Indemnifiers.Add(reader.GetString(0));
            }
            catch (SqlException sqlEx)
            {
                
                throw new Exception("Database error occurred while fetching dropdowns.", sqlEx);
            }
            catch (Exception ex)
            {
                
                throw new Exception("An unexpected error occurred while fetching dropdowns.", ex);
            }

            return result;
        }


    }
}



