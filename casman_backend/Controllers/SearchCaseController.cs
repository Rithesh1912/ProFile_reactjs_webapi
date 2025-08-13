using casman.DataAccess.Interface;
using Microsoft.AspNetCore.Mvc;

namespace casman.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchCaseController : ControllerBase
    {
        
        
       
            private readonly ISearchCase _searchCaseRepository;

            public SearchCaseController(ISearchCase searchCaseRepository)
            {
                _searchCaseRepository = searchCaseRepository;
            }

        [HttpGet("search")]
        public async Task<IActionResult> SearchCase([FromQuery] string caseId, [FromQuery] string subId)
        {
            var result = await _searchCaseRepository.SearchCaseDetails(caseId, subId);

            if (result == null || result.Count == 0)
            {
                return NotFound(new { message = "No case found" });
            }

            return Ok(result); 
        }
        }
    }

