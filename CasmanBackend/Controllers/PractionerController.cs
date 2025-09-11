using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.Models;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.AspNetCore.Mvc;

namespace CasmanSln.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PractionerController : ControllerBase
    {

        private readonly IPractionerRepository practionerRepository;
        private readonly ILogger<PractionerController> logger;


        public PractionerController(IPractionerRepository practionerRepository, ILogger<PractionerController> logger) {

            this.practionerRepository = practionerRepository;
            this.logger = logger;
        }

        [HttpGet("GetPractionerDetailsByCaseId/{CaseId}/{SubId}")]
        public async Task<IActionResult> GetPractionerDetailsByCaseId(string CaseId, string SubId)
        {
            try
            {
                var pracdetails = await practionerRepository.GetPractionerDetailsByCaseID(CaseId, SubId);
                if (pracdetails == null)
                {
                    return NotFound(new { message = "Practioner Not Found for this CaseId" });
                }
                return Ok(pracdetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("AddPractioner")]
        public async Task<IActionResult> AddPractionerByCaseId(AddPractRequestDto request)
        {
            try
            {
                var practioner = await practionerRepository.AddPractDetailsByCaseID(request);
                if (practioner == null)
                {
                    return BadRequest(new { Message = "Invalid data posted" });
                }
                return Ok(practioner);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("GetPracdetailsByName")]
        public async Task<IActionResult> GetPracDetailsByName(ConflictSearchRequestDto requestDto)
        {
            try
            {
                var details = await practionerRepository.GetPracDetailsByName(requestDto);
                if (details == null)
                {
                    return BadRequest(new { Message = "Invalid request" });
                }
                return Ok(details);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

      /*  [HttpGet]
        [Route("GetAllPractionerDetails")]
        public async Task<IActionResult> GetAllPractionerDetails()
        {
            this.Repository = repository;
        }
        [HttpGet("GetPracDetailsByCaseId/{caseID}/{subID}")]

        public async Task<IActionResult> GetPractionerDetailsByCaseID(string caseID, string subID)
        {
            try
            {
                var pracDetails = await Repository.GetPractionerDetailsByCaseID(caseID, subID);
                if (pracDetails == null)
                    return BadRequest("Practioner Not Found with this caseID");

                return Ok(pracDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retriving the practioner details.", error = ex.Message });
            }
        }
        [HttpPut("{pracNum}")]
      
        public async Task<IActionResult> UpdatePractionerDetails(string pracNum, [FromBody] CasePractioner newPrac)
        {
            if (pracNum.IsNullOrEmpty())
                return BadRequest(new { message = "pracNum is required" });
            try
            {
                var updatedPrac = await practionerDetails.UpdatePractionerDetails(pracNum, newPrac);
                if (updatedPrac == null)
                {
                    return NotFound(new { message = "Practitioner not found" });
                }
                return Ok(updatedPrac);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error updating practitioner with pracNum: {pracNum}", pracNum);
                return StatusCode(500, new { message = "An error occurred while updating the practitioner." });
            }
            }

        [HttpDelete("{pracNum}")]
     
        public async Task<IActionResult> DeletePractioner(string pracNum)
        {
            if (string.IsNullOrWhiteSpace(pracNum))
                return BadRequest(new { message = "pracNum is required" });
            try
            {
                var deleted = await practionerDetails.DeletePractioner(pracNum);

                if (!deleted)
                    return NotFound(new {message="Practioner Not Found"});

                return Ok(new { message = "Delted Successfully" });

            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error deleting practitioner with pracNum: {pracNum}", pracNum);
                return StatusCode(500, new { message = "An error occurred while deleting the practitioner." });
            }

        }*/


    }
}
