using CasmanSln.DataAccess.Interface;

using CasmanSln.Models;

using CasmanSln.RequestDtos;

using CasmanSln.ResponseDtos;

using Microsoft.Data.SqlClient;

using System;

using System.Data;

using System.Data.SqlClient;

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

        public async Task<List<GetPractionerResponseDto>> GetPractionerDetailsByCaseID(string caseID, string subID)
        {
            var pracList = new List<GetPractionerResponseDto>();

            using (var conn = new Microsoft.Data.SqlClient.SqlConnection(_connectionString))
            using (var cmd = new Microsoft.Data.SqlClient.SqlCommand("CD_SP_GETPRAC_RTR", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CASEID", caseID);
                cmd.Parameters.AddWithValue("@SUBID", subID);

                await conn.OpenAsync();

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var Prac_Details = new GetPractionerResponseDto
                        {
                            Prac_Num = reader["prac_num"]?.ToString().Trim(),
                            Prac_LastName = reader["prac_last_name"]?.ToString().Trim(),
                            Prac_FirstName = reader["prac_first_name"]?.ToString().Trim(),
                            Prac_Role = reader["prac_role"]?.ToString().Trim(),
                            indemnifiers = reader["prac_def_org"]?.ToString().Trim(),
                            PerCent_Involved = reader["prac_invl"]?.ToString().Trim()
                        };

                        pracList.Add(Prac_Details);
                    }
                }
            }

            return pracList;
        }


        public async Task<bool> AddPractDetailsByCaseID(AddPractRequestDto request)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("CD_SP_PRACDETAILS_PRI", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CaseId", request.CaseId);
                    cmd.Parameters.AddWithValue("@SubsidId", request.SubsidId ?? "");
                    cmd.Parameters.AddWithValue("@SurName", request.SurName ?? "");
                    cmd.Parameters.AddWithValue("@ForeName", request.ForeName ?? "");
                    cmd.Parameters.AddWithValue("@Initial", request.Initial ?? "");
                    cmd.Parameters.AddWithValue("@Sex", request.Sex ?? "");
                    cmd.Parameters.AddWithValue("@Indemnifier", request.Indemnifier ?? "");
                    cmd.Parameters.AddWithValue("@Role", request.Role ?? "");
                    cmd.Parameters.AddWithValue("@PercentinvolMdu", request.PercentInvolMdu ?? "");
                    cmd.Parameters.AddWithValue("@DateOfInvolved", (object)request.DateOfInvolved ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfNotifiedMdu", (object)request.DateOfNotifiedMdu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateClaimMode", (object)request.DateClaimMode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@SpecialityOfDOI", request.SpecialityOfDOI ?? "");
                    cmd.Parameters.AddWithValue("@UserId", request.UserId ?? "");

                    await conn.OpenAsync();
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Log exception if needed
                throw new Exception("Error adding practitioner", ex);
            }
        }

        public async Task<bool>DeletePractioner(string CaseId, string SubsidId, string prac_num)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM t_case_prac WHERE case_id = @CaseId AND subsid_id = @SubsidId AND prac_num = @prac_num", conn))
                {
                    cmd.Parameters.AddWithValue("@CaseId", CaseId);
                    cmd.Parameters.AddWithValue("@SubsidId", SubsidId);
                    cmd.Parameters.AddWithValue("@prac_num", prac_num);

                    await conn.OpenAsync();
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Deleting practioner", ex);

            }
        }

        public async Task<UpdatePractionerResponse> UpdatePractitioner(int CaseId,string subsidId,string prac_num,UpdatePractionerRequestDTO request)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("CD_SP_PRACDETAILS_PRU", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@CaseId", CaseId);
                    cmd.Parameters.AddWithValue("@SubsidId", subsidId);
                    cmd.Parameters.AddWithValue("@PracNum", prac_num);

                    cmd.Parameters.AddWithValue("@SurName", request.SurName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ForeName", request.ForeName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Initial", request.Initial ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sex", request.Sex ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Indemnifier", request.Indemnifier ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role", request.Role ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PercentinvolMdu", request.PercentInvolMdu ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfInvolved", request.DateOfInvolved.HasValue ? request.DateOfInvolved.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateOfNotifiedMdu", request.DateOfNotifiedMdu.HasValue ? request.DateOfNotifiedMdu.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateClaimMode", request.DateClaimMode.HasValue ? request.DateClaimMode.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SpecialityOfDOI", request.SpecialityOfDOI ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserId", request.UserId ?? (object)DBNull.Value);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new UpdatePractionerResponse
                            {
                                CaseId = Convert.ToInt32(reader["case_id"]),
                                SubsidId = reader["subsid_id"].ToString(),
                                PracNum = reader["prac_num"].ToString(),
                                SurName = reader["prac_last_name"].ToString(),
                                ForeName = reader["prac_first_name"].ToString(),
                                Initial = reader["prac_init"].ToString(),
                                Sex = reader["prac_sex"].ToString(),
                                Indemnifier = reader["prac_def_org"].ToString(),
                                Role = reader["prac_role"].ToString(),
                                PercentInvolMdu = reader["prac_invl"].ToString(),
                                DateOfInvolved = reader["date_involved"] as DateTime?,
                                DateOfNotifiedMdu = reader["date_notified"] as DateTime?,
                                DateClaimMode = reader["date_claim_made"] as DateTime?,
                                SpecialityOfDOI = reader["prac_tow"].ToString(),
                                UserId = reader["user_id"].ToString(),
                                LastUpdated = reader["date_last_updated"] as DateTime?
                            };
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
               
                throw new Exception($"Database error while updating practitioner: {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
               
                throw new Exception($"Unexpected error while updating practitioner: {ex.Message}", ex);
            }

            return null;
        }

    }

}


