using casman.DataAccess.Interface;
using casman.RequestDtos;
using Microsoft.AspNetCore.Mvc;

namespace casman.Controllers
{
    [ApiController]
    public class CreateCaseController : Controller
    {
        private readonly ICreateCase createCase;
        public CreateCaseController(ICreateCase createCase)
        {
            this.createCase = createCase;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateCase([FromBody] CreateCaseDto dto)
        {
            var result = await createCase.CreateNewCase(dto);

            if (result!= null)
                return Ok(new { message = "Case created successfully" });

            return BadRequest(new { message = "Failed to create case" });
        }

    }
}
