using CasmanSln.DataAccess.Interface;
using CasmanSln.Models;
using CasmanSln.RequestDtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CasmanSln.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientDetails _patientRepository;

        public PatientController(IPatientDetails patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet("GetPatientByCaseId/{caseId}/{subId}")]
        public async Task<IActionResult> GetPatientByCaseId(string caseId, string subId)
        {
            try
            {
                var request = new ViewPatientRequestDTO
                {
                    case_id = caseId,
                    subsid_id = subId
                };

                var patients = await _patientRepository.GetPatientInfoByCaseAndSub(request);

                if (patients == null || patients.Count == 0)
                {
                    return NotFound(new { message = "No patients found for given caseId and subId" });
                }

                return Ok(patients);
            }
            catch (Exception ex)
            {


                return StatusCode(500, new
                {
                    message = "An error occurred while fetching patient data",
                    details = ex.Message
                });
            }
        }


        [HttpPost("addpatient")]
        public async Task<IActionResult> AddPatient([FromBody] AddPatientRequestDTO patient)
        {
            if (patient == null)
                return BadRequest("Invalid patient data");

            try
            {
                var response = await _patientRepository.InsertPatientAsync(patient);

                if (response.Success)
                    return Ok(response);
                else
                    return StatusCode(500, response);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = "An error occurred while inserting patient", Error = ex.Message });
            }
        }

        [HttpDelete("DeletePatientby/{CaseId}/{SubsidId}/{PtNumber}")]
        public async Task<IActionResult> DeletePatient(string CaseId, string SubsidId, string PtNumber)
        {
            try
            {
                bool deleted = await _patientRepository.DeletePatient(CaseId, SubsidId, PtNumber);
                if (!deleted)
                    return NotFound(new { message = "Patient not found" });

                return Ok(new { message = "Patient deleted successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error deleting patient", details = ex.Message });
            }
        }

        [HttpPut("UpdatePatientby/{CaseId}/{SubsidId}/{PtNumber}")]

        public async Task<IActionResult> UpdatePatient(int CaseId, string SubsidId, int PtNumber, [FromBody] UpdatePatientRequestDTO request)
        {
            try
            {


                if (request == null)
                    return BadRequest("Invalid patient request data.");

                var result = await _patientRepository.UpdatePatient(CaseId, SubsidId, PtNumber, request);

                if (result == null)
                    return NotFound($"Patient not found with CaseId={CaseId}, SubsidId={SubsidId}, PtNumber={PtNumber}");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"{ex.Message}" });
            }
        }
    }
}
