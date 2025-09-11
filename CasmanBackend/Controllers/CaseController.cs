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
        [ProducesResponseType(typeof(PagedResult<CaseSearchResponseDto>), 200)]
        public async Task<IActionResult> SearchCases([FromBody] CaseSearchRequestDto request)
        {
            try
            {
                if (request == null)
                    return BadRequest("Invalid search request");

                var result = await _caseRepository.SearchCases(request);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateCase([FromBody] UpdateCaseRequestDto request)
        {
            if (request == null)
                return BadRequest("Invalid request data.");

            try
            {
                UpdateCaseResponseDto response = await _caseRepository.UpdateCaseDetails(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the case.", error = ex.Message });
            }
        }

        [HttpGet("GetCaseDetailsByCaseId/{caseId}/{subId}")]
        public async Task<IActionResult> GetCaseDetailsByCaseId(string caseId, string subId)
        {
            if (caseId == null || subId == null)
                return BadRequest("CaseId and SubId are Required");
            try
            {
                ViewCaseDetailsResponseDto response = await _caseRepository.GetCaseDetailsByCaseId(caseId, subId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retriving the case details.", error = ex.Message });
            }
        }

        [HttpPost("AddRecentCaseByStaffId")]
        public async Task<IActionResult> AddRecentCase(AddRecentCaseRequestDto request)
        {
            try
            {
                var response = await _caseRepository.AddRecentCase(request);
                if (response == null) return BadRequest(response);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Invalid data" });
            }
        }
        [HttpGet("GetRecentCaseByStaffId/{StaffId}")]
        public async Task<IActionResult>GetRecentCaseDetailsByStaffId(String StaffId)
        {
            try
            {
                var response = await _caseRepository.GetRecentCaseDetailsByStaffId(StaffId);
                if (response == null) return BadRequest("Invalid Request");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { meassage = ex.Message });
            }
        }
    }

}
