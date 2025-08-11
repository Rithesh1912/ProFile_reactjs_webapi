using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasmanSln.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaseController : ControllerBase
    {
        private readonly ICaseDetails details;
        public CaseController(ICaseDetails details) {
            this.details = details;
        }
        [HttpGet]
        [Route("api/GetAllCaseDetails")]
        public async Task<IActionResult> GetAllCaseDetails()
        {
            var data = await details.GetAllCaseDetails();
            return Ok(data);
        }
        [HttpGet]
        [Route("api/GetCaseDetailsByCaseID/{caseId}")]
        public async Task<IActionResult> GetCaseDetailsByCaseId(string caseId, string subId)
        {
            var data1 = await details.GetCaseDetailsById(caseId, subId);
            return Ok(data1);
        }
        [HttpPost]
        [Route("api/CreateCase")]
        public async Task<IActionResult> CreateCase([FromBody]Case newCase)
        {
            if (newCase == null)
                return BadRequest("Case data is required.");
            var createdCase = await details.CreateCase(newCase);
            return CreatedAtAction(nameof(GetCaseDetailsByCaseId), new { caseid = createdCase.CaseId,subid=createdCase.SubsidId }, createdCase);
        }
       

    }

}
