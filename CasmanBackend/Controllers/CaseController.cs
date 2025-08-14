using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CasmanSln.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaseController : ControllerBase
    {
        private readonly ICaseDetails details;
        private readonly ILogger<CaseController> logger;
        public CaseController(ICaseDetails details, ILogger<CaseController> logger)
        {
            this.details = details;
            this.logger = logger;
        }
        [HttpGet]
        [Route("GetAllCaseDetails")]
        public async Task<IActionResult> GetAllCaseDetails()
        {
            try
            {
                var casedetails = await details.GetAllCaseDetails();
                if(casedetails== null) 
                    return NotFound(new {message="No data in database"});

                return Ok(casedetails);
            }
            catch(Exception ex) 
            {
                    logger.LogError(ex, "Error occured while fetching all case details");
                    return StatusCode(500, new { message = "An error occurred while retrieving case details." });
            }
        }
        [HttpGet]
        [Route("GetCaseDetailsByCaseID/{caseId}")]
        public async Task<IActionResult> GetCaseDetailsByCaseId(string caseId, string subId)
        {
            try
            {
                var casedetail = await details.GetCaseDetailsById(caseId, subId);
                if (casedetail == null)
                    return NotFound(new { message = "No data related to this caseId in database" });
                return Ok(casedetail);
            }
            catch(Exception ex)
            {
                logger.LogError(ex, "Error fetching casedetails by caseId: {caseId}, subId: {subId}", caseId, subId);
                return StatusCode(500, new { message = "An error occurred while retrieving the casedetails." });
            }
        }
        [HttpPost]
        [Route("api/CreateCase")]
        public async Task<IActionResult> CreateCase([FromBody]Case newCase)
        {
            try
            {
                if (newCase == null)
                    return BadRequest("Case data is required.");
                var createdCase = await details.CreateCase(newCase);
                return CreatedAtAction(nameof(GetCaseDetailsByCaseId), new { caseid = createdCase.CaseId, subid = createdCase.SubsidId }, createdCase);
            }
            catch(Exception ex)
            {
                logger.LogError(ex, "Error occured while creating case");
                return StatusCode(500, new { message = "An error occurred while creating the case." });
            }
        }
       

    }

}
