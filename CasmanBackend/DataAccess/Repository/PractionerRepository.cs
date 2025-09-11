    using CasmanSln.DataAccess.Interface;
    using CasmanSln.Models;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Dapper;
using Microsoft.Data.SqlClient;
    using System;
    using System.Data;
    using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SqlException = Microsoft.Data.SqlClient.SqlException;


namespace CasmanSln.DataAccess.Repository
{
    public class PractionerRepository : IPractionerRepository
    {
        private readonly string _connectionString;


        public PractionerRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<GetPractionerResponseDto> GetPractionerDetailsByCaseID(string caseID, string subID)
        {
            using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(_connectionString))
            using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand("CD_SP_GETPRAC_RTR", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CASEID", caseID);
                cmd.Parameters.AddWithValue("@SUBID", subID);

                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {


                    GetPractionerResponseDto Prac_Details = null;

                    if (await reader.ReadAsync())
                    {
                        Prac_Details = new GetPractionerResponseDto
                        {
                            Prac_Num = reader["prac_num"].ToString().Trim(),
                            Prac_LastName = reader["prac_last_name"].ToString().Trim(),
                            Prac_FirstName = reader["prac_first_name"].ToString().Trim(),
                            Prac_Role = reader["prac_role"].ToString().Trim(),
                            Idemnifier = reader["prac_def_org"].ToString().Trim(),
                            PerCent_Involved = reader["prac_invl"].ToString().Trim()

                        };
                    }

                    return Prac_Details;
                }
            }
        }

        public async Task<AddPractResponseDto> AddPractDetailsByCaseID(AddPractRequestDto request)
        {
            var response = new AddPractResponseDto();

            try
            {
                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connectionString))
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand("CD_SP_PRACDETAILS_PRU", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CaseId", request.CaseId ?? (object)DBNull.Value);
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

      
        public async Task<IEnumerable<ConflictSearchResponseDto>> GetPracDetailsByName(ConflictSearchRequestDto request)
        {
            var results = new List<ConflictSearchResponseDto>();

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new Microsoft.Data.SqlClient.SqlCommand("ConflictSrch_RTR", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.AddWithValue("@Surname", (object?)request.Surname ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Forename", (object?)request.Forename ?? DBNull.Value);
                    command.Parameters.AddWithValue("@JoinType", request.JoinType);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var dto = new ConflictSearchResponseDto
                            {
                                CaseId = reader["CaseId"] != DBNull.Value ? reader["CaseId"].ToString() : null,
                                SubId = reader["SubId"] != DBNull.Value ? reader["SubId"].ToString() : null,
                                PracFirstName = reader["PracFirstName"] != DBNull.Value ? reader["PracFirstName"].ToString() : null,
                                PracLastName = reader["PracLastName"] != DBNull.Value ? reader["PracLastName"].ToString() : null
                            };

                            results.Add(dto);
                        }
                    }
                }
            }

            return results;
        }

    }
}