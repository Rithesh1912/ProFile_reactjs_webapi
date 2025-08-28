using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.Models;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace CasmanSln.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PractionerController : ControllerBase
    {
        private readonly IPractionerDetails practionerDetails;
        private readonly ILogger<PractionerController> logger;
        

        public PractionerController(IPractionerDetails practionerDetails, ILogger<PractionerController> logger) {

            this.practionerDetails = practionerDetails;
            this.logger = logger;
        }
        [HttpGet]
        [Route("GetAllPractionerDetails")]
        public async Task<IActionResult> GetAllPractionerDetails()
        {
            try
            {
                var details = await practionerDetails.GetAllPractionerDetails();
                return Ok(details);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occured while fetching all practitioners");
                return StatusCode(500, new { message = "An error occurred while retrieving practitioner details." });
            }

        }
        [HttpGet]
        [Route("GetPractionerByCaseId/{caseId}")]
        public async Task<IActionResult> GetPractionerDetailsByCaseID(string caseId, string subId)
        {
            try
            {
                var pracdetail = await practionerDetails.GetPractionerByCaseId(caseId, subId);
                if (pracdetail == null)
                    return NotFound(new { message = "Practitioner not found" });
                return Ok(pracdetail);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error fetching practitioner by caseId: {caseId}, subId: {subId}", caseId, subId);
                return StatusCode(500, new { message = "An error occurred while retrieving the practitioner." });
            }

            }

        [HttpPost]
        [Route("CreatePractioner")]
        public async Task<IActionResult> CreatePractioner([FromBody] CasePractioner prac)
        {
            try
            {
                var newPrac = await practionerDetails.CreatePractioner(prac);
                return CreatedAtAction(nameof(GetPractionerDetailsByCaseID), new { caseId = prac.CaseId, subId = prac.SubsidId }, newPrac);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error creating practitioner");
                return StatusCode(500, new { message = "An error occurred while creating the practitioner." });
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

        }
        [HttpPost("add-practitioner")]
        public async Task<IActionResult> AddPractitioner([FromBody] AddPractRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await practionerDetails.AddPractitionerDetails(request);

            if (result.IsSuccess)
                return Ok(result);  

            if (result.Message.StartsWith("Error"))
                return StatusCode(500, result);  

            return BadRequest(result);  
        }




    }
}
