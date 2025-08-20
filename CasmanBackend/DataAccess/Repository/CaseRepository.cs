using CasmanSln.DataAccess.Interface;
using CasmanSln.Dtos;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.Data.SqlClient; // Or System.Data.SqlClient depending on your setup
using System.Data;
using System.Text.RegularExpressions;

namespace CasmanSln.DataAccess.Repository
{
    public class CaseRepository : ICaseRepository
    {
        private readonly string _connectionString;

       
        public CaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<CreateCaseResponseDto> CreateNewCaseAsync(CreateCaseRequestDto request)
        {
            CreateCaseResponseDto response = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.ADM_SP_CREATENEWCASE_PRI", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PracNum", request.PracNum ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracRole", request.PracRole ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@MduUnit", request.MduUnit ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracLastName", request.PracLastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracFirstName", request.PracFirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracInit", request.PracInit ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracSex", request.PracSex ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracDefOrg", request.PracDefOrg ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracTow", request.PracTow ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PracSource", request.PracSource ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserId", request.UserId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@CaseCreateSource", request.CaseCreateSource);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            response = new CreateCaseResponseDto
                            {
                                CaseID = reader["CaseId"]?.ToString(),
                                SubID = reader["SubId"]?.ToString(),
                                Message = reader["Message"]?.ToString()
                               
                            };
                        }
                    }
                }
            }

            return response;
        }
        public async Task<List<CaseSearchResponseDto>> SearchCases(CaseSearchRequestDto request)
        {
            var results = new List<CaseSearchResponseDto>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("CD_SP_SEARCHCASES_RTR", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
         // Match SP parameters exactly(VARCHAR)
        cmd.Parameters.Add("@CaseID", SqlDbType.VarChar, 7).Value =
            string.IsNullOrWhiteSpace(request.CaseID) ? (object)DBNull.Value : request.CaseID;

                cmd.Parameters.Add("@SubsidID", SqlDbType.VarChar, 2).Value =
                    string.IsNullOrWhiteSpace(request.SubsidID) ? (object)DBNull.Value : request.SubsidID;
                Console.WriteLine($"Executing SP with CaseID={request.CaseID}, SubsidID={request.SubsidID}");


                await conn.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("No rows returned from stored procedure.");
                    }
                    while (await reader.ReadAsync())
                    {
                        results.Add(new CaseSearchResponseDto
                        {
                            CaseId = reader["case_id"].ToString(),
                            SubsidId = reader["subsid_id"].ToString(),
                            MduUnit = reader["mdu_unit"]?.ToString(),
                            IncdtDate = reader["incdt_date"] == DBNull.Value? (DateTime?)null: Convert.ToDateTime(reader["incdt_date"]),

                            OpenDate = reader["open_date"] as DateTime?,
                            CloseDate = reader["close_date"] as DateTime?,
                            SecondScrtUsr = reader["second_scrt_usr"]?.ToString(),
                            UserId = reader["user_id"]?.ToString(),
                            DateLastUpdated = reader["date_last_updated"] as DateTime?,
                            ThirdScrtUsr = reader["third_scrt_usr"]?.ToString(),
                            YearOfCase = reader["YearOfCase"] as int?,
                            ClaimDate = reader["CLAIM_DATE"] as DateTime?,
                            LegalCaseDocumentStatus = reader["Legal_case_Document_Status"]?.ToString(),
                            CaseCreateSource = reader["Case_Create_Source"]?.ToString(),
                            CaseUri = reader["case_uri"]?.ToString()
                        });
                    }
                }
            }

            return results;
        }

    }
}
