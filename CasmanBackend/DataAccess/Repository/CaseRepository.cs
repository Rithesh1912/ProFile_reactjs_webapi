using Azure.Core;
using CasmanSln.DataAccess.Interface;
using CasmanSln.Dtos;
using CasmanSln.Models;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.Data.SqlClient; // Or System.Data.SqlClient depending on your setup
using System.Data;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        //public async Task<List<CaseSearchResponseDto>> SearchCases(CaseSearchRequestDto request)
        //{
        //    var results = new List<CaseSearchResponseDto>();

        //    using (SqlConnection conn = new SqlConnection(_connectionString))
        //    using (SqlCommand cmd = new SqlCommand("CD_SP_SEARCHCASES_RTR", conn))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        // // Match SP parameters exactly(VARCHAR)
        //cmd.Parameters.Add("@CaseID", SqlDbType.VarChar, 7).Value =
        //    string.IsNullOrWhiteSpace(request.CaseID) ? (object)DBNull.Value : request.CaseID;

        //        cmd.Parameters.Add("@SubsidID", SqlDbType.VarChar, 2).Value =
        //            string.IsNullOrWhiteSpace(request.SubsidID) ? (object)DBNull.Value : request.SubsidID;
        //        Console.WriteLine($"Executing SP with CaseID={request.CaseID}, SubsidID={request.SubsidID}");


        //        await conn.OpenAsync();

        //        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
        //        {
        //            if (!reader.HasRows)
        //            {
        //                Console.WriteLine("No rows returned from stored procedure.");
        //            }
        //            while (await reader.ReadAsync())
        //            {
        //                results.Add(new CaseSearchResponseDto
        //                {
        //                    CaseId = reader["case_id"].ToString(),
        //                    SubsidId = reader["subsid_id"].ToString(),
        //                    MduUnit = reader["mdu_unit"]?.ToString(),
        //                    IncdtDate = reader["incdt_date"] == DBNull.Value? (DateTime?)null: Convert.ToDateTime(reader["incdt_date"]),

        //                    OpenDate = reader["open_date"] as DateTime?,
        //                    CloseDate = reader["close_date"] as DateTime?,
        //                    SecondScrtUsr = reader["second_scrt_usr"]?.ToString(),
        //                    UserId = reader["user_id"]?.ToString(),
        //                    DateLastUpdated = reader["date_last_updated"] as DateTime?,
        //                    ThirdScrtUsr = reader["third_scrt_usr"]?.ToString(),
        //                    YearOfCase = reader["YearOfCase"] as int?,
        //                    ClaimDate = reader["CLAIM_DATE"] as DateTime?,
        //                    LegalCaseDocumentStatus = reader["Legal_case_Document_Status"]?.ToString(),
        //                    CaseCreateSource = reader["Case_Create_Source"]?.ToString(),
        //                    CaseUri = reader["case_uri"]?.ToString()
        //                });
        //            }
        //        }
        //    }

        //    return results;
        //}

        public async Task<UpdateCaseResponseDto>UpdateCaseDetails(UpdateCaseRequestDto request)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("CD_SP_CASE_PRU", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CaseId", request.CaseId);
                cmd.Parameters.AddWithValue("@SubsidId", (object?)request.SubsidId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MduUnit", (object?)request.Department ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CaseType", request.CaseType);
                cmd.Parameters.AddWithValue("@mduLiability", request.MduLiability ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CaseCategory", request.CaseCategory);
                cmd.Parameters.AddWithValue("@CaseSpeciality", request.CaseSpeciality);
                cmd.Parameters.AddWithValue("@CasePractice", request.CasePractice);
                cmd.Parameters.AddWithValue("@CaseHandler1", (object?)request.caseHandler1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CaseHandler2", (object?)request.caseHandler2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ThirdScrtUsr", (object?)request.ThirdScrtUsr ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IncdtDate", (object?)request.IncdtDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ClaimDate", (object?)request.ClaimDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CloseDate", (object?)request.CloseDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateLastUpdated", DateTime.Now);
                cmd.Parameters.AddWithValue("@LegalCaseDocumentStatus", (object?)request.LegalCaseDocumentStatus ?? DBNull.Value);

                await conn.OpenAsync();

                var reader = await cmd.ExecuteReaderAsync();
                string message = "Case updated successfully";
                if (await reader.ReadAsync())
                {
                    message = reader["Message"].ToString();
                }

                return new UpdateCaseResponseDto { Message = message };
            }

        }
        public async Task<ViewCaseDetailsResponseDto> GetCaseDetailsByCaseId(string caseId, string subId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("CD_SP_CASEGENERALDETAILS_RTR", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CaseId", caseId);
                cmd.Parameters.AddWithValue("@SubsidId", subId);

                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {


                    ViewCaseDetailsResponseDto caseDetails = null;

                    if (await reader.ReadAsync())
                    {
                        caseDetails = new ViewCaseDetailsResponseDto
                        {
                            CaseId = reader["CaseId"].ToString(),
                            SubsidId = reader["SubsidId"].ToString(),
                            Department = reader["MduUnit"].ToString(),
                            CaseType = reader["CaseType"].ToString(),
                            MduLiability = reader["MduLiability"].ToString(),
                            CaseCategory = reader["CaseCategory"].ToString(),
                            CaseSpeciality = reader["CaseSpeciality"].ToString(),
                            CasePractice = reader["CasePractice"].ToString(),
                            IncdtDate = reader["IncdtDate"] as DateTime?,

                            CaseHandler1 = reader["CaseHandler1"].ToString(),
                            CaseHandler2 = reader["CaseHandler2"].ToString(),

                            ClaimDate = reader["ClaimDate"] as DateTime?,

                            LegalCaseDocumentStatus = reader["LegalCaseDocumentStatus"].ToString()
                        };
                    }

                    return caseDetails;
                }
            }

        }
        public async Task<ResponseDtos.PagedResult<CaseSearchResponseDto>> SearchCases(CaseSearchRequestDto request)
        {
            var results = new List<CaseSearchResponseDto>();
            int totalCount = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("CD_SP_SEARCHCASES_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@CaseID", SqlDbType.VarChar, 7).Value =
                        string.IsNullOrWhiteSpace(request.CaseID) ? (object)DBNull.Value : request.CaseID;

                    cmd.Parameters.Add("@SubsidID", SqlDbType.VarChar, 2).Value =
                        string.IsNullOrWhiteSpace(request.SubsidID) ? (object)DBNull.Value : request.SubsidID;

                    cmd.Parameters.Add("@PageNumber", SqlDbType.Int).Value =
                        request.PageNumber <= 0 ? 1 : request.PageNumber;

                    cmd.Parameters.Add("@PageSize", SqlDbType.Int).Value =
                        request.PageSize <= 0 ? 10 : request.PageSize;

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        // First result set = paginated rows
                        while (await reader.ReadAsync())
                        {
                            results.Add(new CaseSearchResponseDto
                            {
                                CaseId = reader["case_id"].ToString(),
                                SubsidId = reader["subsid_id"].ToString(),
                                MduUnit = reader["mdu_unit"]?.ToString(),
                                IncdtDate = reader["incdt_date"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(reader["incdt_date"]),
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


                        if (await reader.NextResultAsync() && await reader.ReadAsync())
                        {
                            totalCount = reader.GetInt32(0);
                        }
                    }
                }
            }

            return new ResponseDtos.PagedResult<CaseSearchResponseDto>
            {
                Items = results,
                TotalCount = totalCount,
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };
        }

    }
}
