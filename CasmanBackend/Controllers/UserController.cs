using CasmanSln.DataAccess.Interface;
using CasmanSln.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace CasmanSln.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _repository;

        public UserController(IUserManager repository)
        {
            _repository = repository;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertUserAndStaff([FromBody] UserStaffDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid input");

            try
            {
                bool result = await _repository.InsertUserAndStaffAsync(dto);
                if (result)
                    return Ok(new { message = "User and Staff inserted successfully" });
                else
                    return StatusCode(500, "Failed to insert data");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }

}
