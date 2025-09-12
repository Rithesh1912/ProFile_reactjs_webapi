using CasmanSln.DataAccess.Interface;
using CasmanSln.DataAccess.Repository;
using CasmanSln.RequestDtos;
using Microsoft.AspNetCore.Mvc;

namespace CasmanSln.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PractionerController : ControllerBase
    {

        private readonly IPractionerRepository practionerRepository;
        private readonly ILogger<PractionerController> logger;


        public PractionerController(IPractionerRepository practionerRepository, ILogger<PractionerController> logger)
        {

            this.practionerRepository = practionerRepository;
            this.logger = logger;
        }

        [HttpGet("GetPractitionerByCaseId/{caseId}/{subId}")]
        public async Task<IActionResult> GetPractitionersByCaseId(string caseId, string subId)
        {
            try
            {
                var practitioners = await practionerRepository.GetPractionerDetailsByCaseID(caseId, subId);

                if (practitioners == null || !practitioners.Any())
                    return NotFound(new { message = "No practitioners found for this case/subsid" });

                return Ok(practitioners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error fetching practitioners", details = ex.Message });
            }
        }
        [HttpPost("AddPractitioner")]
        public async Task<IActionResult> AddPractDetailsByCaseID([FromBody] AddPractRequestDto request)
        {
            if (request == null)
                return BadRequest(new { isSuccess = false, message = "Request body is missing" });

            try
            {
                bool added = await practionerRepository.AddPractDetailsByCaseID(request);

                if (added)
                    return Ok(new { isSuccess = true, message = "Practitioner added successfully" });
                else
                    return BadRequest(new { isSuccess = false, message = "Insert failed. No rows affected." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { isSuccess = false, message = $"Database error: {ex.Message}" });
            }

        }

        [HttpDelete("Deletepractionerby/{CaseId}/{SubsidId}/{prac_num}")]
        public async Task<IActionResult> DeletePractioner(string CaseId, string SubsidId, string prac_num)
        {
            try
            {
                bool deleted = await practionerRepository.DeletePractioner(CaseId, SubsidId, prac_num);

                if (!deleted)
                    return NotFound(new { message = "practioner not found" });

                return Ok(new { message = "practioner deleted successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error deleting practioner", details = ex.Message });
            }
        }

        [HttpPut("UpdatePractionerby/{CaseId}/{SubsidId}/{prac_num}")]
        public async Task<IActionResult> UpdatePractitioner(int CaseId,string SubsidId, string prac_num, [FromBody] UpdatePractionerRequestDTO request)
        {
            try
            {


                var result = await practionerRepository.UpdatePractitioner(CaseId, SubsidId, prac_num, request);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"{ex.Message}" });
            }
        }

    }
}