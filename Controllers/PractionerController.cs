using CasmanSln.DataAccess.Interface;
using CasmanSln.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasmanSln.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PractionerController : ControllerBase
    {
        private readonly IPractionerDetails practionerDetails;


        public PractionerController(IPractionerDetails practionerDetails) {

            this.practionerDetails = practionerDetails;
        }
        [HttpGet]
        [Route("GetAllPractionerDetails")]
        public async Task<IActionResult> GetAllPractionerDetails()
        {
            var details = await practionerDetails.GetAllPractionerDetails();
            return Ok(details);

        }
        [HttpGet]
        [Route("GetPractionerByCaseId")]
        public async Task<IActionResult> GetPractionerDetailsByCaseID(string caseId, string subId)
        {
            var pracdetail = await practionerDetails.GetPractionerByCaseId(caseId, subId);
            return Ok(pracdetail);
        }

        [HttpPost]
        [Route("CreatePractioner")]
        public async Task<IActionResult> CreatePractioner(CasePractioner prac)
        {
            var newPrac = await practionerDetails.CreatePractioner(prac);
            return Ok(newPrac);
        }
        [HttpPut("{pracNum}")]
      
        public async Task<IActionResult> UpdatePractionerDetails(string pracNum, CasePractioner newPrac)
        {
            var updatedPrac = await practionerDetails.UpdatePractionerDetails(pracNum, newPrac);
            if (updatedPrac == null)
            {
                return NotFound();
            }
            return Ok(updatedPrac);
        }

        [HttpDelete("{pracNum}")]
     
        public async Task<IActionResult> DeletePractioner(string pracNum)
        {
            var deleted = await practionerDetails.DeletePractioner(pracNum);

            if (!deleted)
                return NotFound();

            return Ok("Delted Successfully");
        }


    }
}
