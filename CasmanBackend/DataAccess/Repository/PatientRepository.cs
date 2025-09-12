using CasmanSln.DataAccess.Interface;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CasmanSln.DataAccess.Repository
{
    public class PatientRepository : IPatientDetails
    {
        private readonly string _connectionString;

        public PatientRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("CasmanConnection");
        }

        public async Task<List<ViewPatientResponseDTO>> GetPatientInfoByCaseAndSub(ViewPatientRequestDTO request)
        {
            var patients = new List<ViewPatientResponseDTO>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("CD_SP_PATIENTINFO_RTR", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@case_id", request.case_id);
                    cmd.Parameters.AddWithValue("@sub_id", request.subsid_id);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            patients.Add(new ViewPatientResponseDTO
                            {
                                CaseId = reader["case_id"]?.ToString(),
                                SubsidId = reader["subsid_id"]?.ToString(),
                                PtNumber = reader["PtNumber"]?.ToString(),
                                PtLname = reader["PtLname"]?.ToString(),
                                PtFname = reader["PtFname"]?.ToString(),
                                PtTitle = reader["PtTitle"]?.ToString(),
                                PtInit = reader["PtInit"]?.ToString(),
                                PtSex = reader["PtSex"]?.ToString(),
                                PtNino = reader["PtNino"]?.ToString(),
                                PtDob = reader["PtDob"] == DBNull.Value ? null : (DateTime?)reader["PtDob"],

                                PtAgeInc = int.TryParse(reader["PtAgeInc"]?.ToString(), out var age) ? age : null,

                                PtSol = reader["PtSol"]?.ToString(),
                                PtAddr1 = reader["PtAddr1"]?.ToString(),
                                PtAddr2 = reader["PtAddr2"]?.ToString(),
                                PtAddr3 = reader["PtAddr3"]?.ToString(),
                                PtAddr4 = reader["PtAddr4"]?.ToString(),
                                PtAddr5 = reader["PtAddr5"]?.ToString(),
                                PtAddrPostCode = reader["PtAddrPostCode"]?.ToString(),
                                PtSolAddr1 = reader["PtSolAddr1"]?.ToString(),
                                PtSolAddr2 = reader["PtSolAddr2"]?.ToString(),
                                PtSolAddr3 = reader["PtSolAddr3"]?.ToString(),
                                PtSolAddr4 = reader["PtSolAddr4"]?.ToString(),
                                PtSolAddr5 = reader["PtSolAddr5"]?.ToString(),
                                PtSolPostCode = reader["PtSolPostCode"]?.ToString(),

                               
                                PtIncomplete = ParseBool(reader["PtIncomplete"]?.ToString()),
                                PtDeceased = ParseBool(reader["PtDeceased"]?.ToString()),
                                PatientInformed = ParseBool(reader["PatientInformed"]?.ToString()),

                                UserId = reader["UserId"]?.ToString(),
                                DateLastUpdated = reader["DateLastUpdated"] == DBNull.Value ? null : (DateTime?)reader["DateLastUpdated"],

                                LockNo = int.TryParse(reader["LockNo"]?.ToString(), out var lockNo) ? lockNo : null,

                                PtLnameInit = reader["PtLnameInit"]?.ToString(),
                                Problem = reader["Problem"]?.ToString(),
                                Sanction = reader["Sanction"]?.ToString(),
                                SanctionDate = reader["SanctionDate"] == DBNull.Value ? null : (DateTime?)reader["SanctionDate"]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
           
                throw new Exception("Error fetching patient info", ex);
            }

            return patients; 
        }


        private bool? ParseBool(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            return value.Trim().ToUpper() == "Y";
        }

        public async Task<AddPatientResponseDTO> InsertPatientAsync(AddPatientRequestDTO patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("CD_SP_PATIENTINFO_PRI", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@case_id", patient.CaseId);
                    cmd.Parameters.AddWithValue("@subsid_id", patient.SubsidId);
                    cmd.Parameters.AddWithValue("@PtLname", patient.PtLname ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtFname", patient.PtFname ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtTitle", patient.PtTitle ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtInit", patient.PtInit ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSex", patient.PtSex ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtDob", patient.PtDob.HasValue ? patient.PtDob.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSol", patient.PtSol ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr1", patient.PtAddr1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr2", patient.PtAddr2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr3", patient.PtAddr3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr4", patient.PtAddr4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr5", patient.PtAddr5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddrPostCode", patient.PtAddrPostCode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr1", patient.PtSolAddr1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr2", patient.PtSolAddr2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr3", patient.PtSolAddr3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr4", patient.PtSolAddr4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr5", patient.PtSolAddr5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolPostCode", patient.PtSolPostCode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtIncomplete", patient.PtIncomplete ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtDeceased", patient.PtDeceased ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserId", patient.UserId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LockNo", patient.LockNo);
                    cmd.Parameters.AddWithValue("@PatientInformed", patient.PatientInformed ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Problem", patient.Problem ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sanction", patient.Sanction ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SanctionDate", patient.SanctionDate.HasValue ? patient.SanctionDate.Value : (object)DBNull.Value);

                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                    return new AddPatientResponseDTO
                    {
                        Success = true,
                        Message = "Patient inserted successfully",
                        CaseId = patient.CaseId,
                        SubsidId = patient.SubsidId
                    };
                }
            }
            catch (Exception ex)
            {
                // Log ex if needed
                return new AddPatientResponseDTO
                {
                    Success = false,
                    Message = $"Error inserting patient: {ex.Message}",
                    CaseId = patient.CaseId,
                    SubsidId = patient.SubsidId
                };
            }
        }

        public async Task<bool>DeletePatient(string CaseId, string SubsidId, string PtNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM T_PT_INFO WHERE case_id = @CaseId AND subsid_id = @SubsidId AND PtNumber = @PtNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@CaseId", CaseId);
                    cmd.Parameters.AddWithValue("@SubsidId", SubsidId);
                    cmd.Parameters.AddWithValue("@PtNumber", PtNumber);

                    await conn.OpenAsync();
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error Deleting patient", ex);

            }
        }

        public async Task<UpdatePatientResponseDTO> UpdatePatient(
            int CaseId, string SubsidId, int ptNumber, UpdatePatientRequestDTO request)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("CD_SP_PATIENTINFO_PRU", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    
                    cmd.Parameters.AddWithValue("@CaseId", CaseId);
                    cmd.Parameters.AddWithValue("@SubsidId", SubsidId);
                    cmd.Parameters.AddWithValue("@PtNumber", ptNumber);

                  
                    cmd.Parameters.AddWithValue("@PtLname", request.PtLname ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtFname", request.PtFname ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtTitle", request.PtTitle ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtInit", request.PtInit ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSex", request.PtSex ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtNino", request.PtNino ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtDob", request.PtDob.HasValue ? request.PtDob.Value : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAgeInc", request.PtAgeInc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSol", request.PtSol ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr1", request.PtAddr1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr2", request.PtAddr2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr3", request.PtAddr3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr4", request.PtAddr4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddr5", request.PtAddr5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtAddrPostCode", request.PtAddrPostCode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr1", request.PtSolAddr1 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr2", request.PtSolAddr2 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr3", request.PtSolAddr3 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr4", request.PtSolAddr4 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolAddr5", request.PtSolAddr5 ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtSolPostCode", request.PtSolPostCode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtIncomplete", request.PtIncomplete ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtDeceased", request.PtDeceased ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@UserId", request.UserId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@DateLastUpdated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@LockNo", request.LockNo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PatientInformed", request.PatientInformed ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PtLnameInit", request.PtLnameInit ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Problem", request.Problem ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Sanction", request.Sanction ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SanctionDate", request.SanctionDate.HasValue ? request.SanctionDate.Value : (object)DBNull.Value);

                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new UpdatePatientResponseDTO
                            {
                                CaseId = Convert.ToInt32(reader["case_id"]),
                                SubsidId = reader["subsid_id"].ToString(),
                                PtNumber = Convert.ToInt32(reader["PtNumber"]),
                                PtLname = reader["PtLname"].ToString(),
                                PtFname = reader["PtFname"].ToString(),
                                PtTitle = reader["PtTitle"].ToString(),
                                PtInit = reader["PtInit"].ToString(),
                                PtSex = reader["PtSex"].ToString(),
                                PtNino = reader["PtNino"].ToString(),
                                PtDob = reader["PtDob"] as DateTime?,
                                PtAgeInc = reader["PtAgeInc"].ToString(),
                                PtSol = reader["PtSol"].ToString(),
                                PtAddr1 = reader["PtAddr1"].ToString(),
                                PtAddr2 = reader["PtAddr2"].ToString(),
                                PtAddr3 = reader["PtAddr3"].ToString(),
                                PtAddr4 = reader["PtAddr4"].ToString(),
                                PtAddr5 = reader["PtAddr5"].ToString(),
                                PtAddrPostCode = reader["PtAddrPostCode"].ToString(),
                                PtSolAddr1 = reader["PtSolAddr1"].ToString(),
                                PtSolAddr2 = reader["PtSolAddr2"].ToString(),
                                PtSolAddr3 = reader["PtSolAddr3"].ToString(),
                                PtSolAddr4 = reader["PtSolAddr4"].ToString(),
                                PtSolAddr5 = reader["PtSolAddr5"].ToString(),
                                PtSolPostCode = reader["PtSolPostCode"].ToString(),
                                PtIncomplete = reader["PtIncomplete"].ToString(),
                                PtDeceased = reader["PtDeceased"].ToString(),
                                UserId = reader["UserId"].ToString(),
                                DateLastUpdated = reader["DateLastUpdated"] as DateTime?,
                                LockNo = reader["LockNo"].ToString(),
                                PatientInformed = reader["PatientInformed"].ToString(),
                                PtLnameInit = reader["PtLnameInit"].ToString(),
                                Problem = reader["Problem"].ToString(),
                                Sanction = reader["Sanction"].ToString(),
                                SanctionDate = reader["SanctionDate"] as DateTime?
                            };
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Database error while updating patient: {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error while updating patient: {ex.Message}", ex);
            }

            return null;
        }
    }
}
