using CasmanSln.DataAccess.Interface;
using CasmanSln.Dtos;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.AspNetCore.Mvc;


namespace CasmanSln.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaseController : ControllerBase
    {
        private readonly ICaseRepository _caseRepository;

        public CaseController(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }

        // POST: api/case/create
        [HttpPost("create")]
        public async Task<IActionResult> CreateCase([FromBody] CreateCaseRequestDto request)
        {
            if (request == null)
                return BadRequest("Invalid request data.");

            try
            {
                CreateCaseResponseDto response = await _caseRepository.CreateNewCaseAsync(request);

                if (response == null)
                {
                    return NotFound("Case could not be created. Possibly invalid UserId or missing data.");
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                // logs can be added with ILogger
                return StatusCode(500, new { message = "An error occurred while creating the case.", error = ex.Message });
            }
        }
        [HttpPost("search")]
        public async Task<ActionResult<List<CaseSearchResponseDto>>> SearchCases([FromBody] CaseSearchRequestDto request)
        {
            if (string.IsNullOrWhiteSpace(request.CaseID) || string.IsNullOrWhiteSpace(request.SubsidID))
            {
                return BadRequest("CaseID and SubsidID are required.");
            }

            var cases = await _caseRepository.SearchCases(request);

            if (cases == null)
            {
                return NotFound("No cases found for given search criteria.");
            }

            return Ok(cases);
        }
    }

}
