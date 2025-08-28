using CasmanSln.DataAccess.Interface;
using CasmanSln.ResponseDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CasmanSln.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropDownController : ControllerBase
    {
        private readonly IDrpdwns _repository;

        public DropDownController(IDrpdwns repository)
        {
            _repository = repository;
        }

        //    [HttpGet("Indemnifier")]
        //    public async Task<IActionResult> GetIndemnifiersDropdown([FromQuery] string? value = null)
        //    {
        //        try
        //        {
        //            var list = await _repository.GetIndemnifiersDropdown(value);
        //            return Ok(list);
        //        }
        //        catch (Exception ex)
        //        {

        //            return StatusCode(500, $"Internal server error: {ex.Message}");
        //        }
        //    }

        //    [HttpGet("Speciality")]
        //    public async Task<IActionResult> GetSpecialtiesDropdown([FromQuery] int forSpecialty)
        //    {
        //        try
        //        {
        //            var list = await _repository.GetSpecialtiesDropdown();
        //            return Ok(list); 
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, $"Internal server error: {ex.Message}");
        //        }
        //    }

        //    [HttpGet("GetLiabilities")]
        //    public async Task<IActionResult> GetLiabilities()
        //    {
        //        try
        //        {
        //            var liabilities = await _repository.GetLiabilitiesDropDown();
        //            return Ok(liabilities);
        //        }
        //        catch(Exception ex) 
        //        {

        //            Console.WriteLine($"Error in GetLiabilities: {ex.Message}");
        //            return StatusCode(500, new { Message = "An error occurred while fetching liabilities.", Details = ex.Message });
        //        }

        //    }

        //    [HttpGet("GetCaseTypeDescriptions")]
        //    public async Task<IActionResult> GetCaseTypeDescriptions()
        //    {
        //        try
        //        {
        //            var descriptions = await _repository.GetCaseTypeDescriptionsDropDown();
        //            return Ok(descriptions);
        //        }
        //        catch (Exception ex)
        //        {

        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetCaseStatus")]

        //    public async Task<IActionResult> GetCaseStatusDropDown()
        //    {
        //        try
        //        {
        //            var status = await _repository.GetCaseStatusDropDown();
        //            return Ok(status);

        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetDepartment")]

        //    public async Task<IActionResult> GetDepartmentDropDown()
        //    {
        //        try
        //        {
        //            var dept = await _repository.GetDepartmentDropDown();
        //            return Ok(dept);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetCategory")]

        //    public async Task<IActionResult> GetCaseCategory()
        //    {
        //        try
        //        {

        //            var allowedCategories = new List<string>
        //{
        //    "", "DENTIST", "DOCTOR", "NON CLINICAL",
        //    "OTHER DENTAL PRACTITIONER", "OTHER MEDICAL PRACTITIONER",
        //    "STUDENT", "~NOT KNOWN", "~Unassigned"
        //};
        //            var category = await _repository.GetCaseCategoryDropDown();
        //            return Ok(category);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }
        //    [HttpGet("GetPractice")]

        //    public async Task<IActionResult> GetCasePractice()
        //    {
        //        try
        //        {
        //            var practice = await _repository.GetCasePracticeDropDown();
        //            return Ok(practice);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetFileClassification")]

        //    public async Task<IActionResult> GetCaseFileClassification()
        //    {
        //        try
        //        {
        //            var fileclassification = await _repository.GetCaseFileClassificationDropDown();
        //            return Ok(fileclassification);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetCaseHandler1")]
        //    public async Task<IActionResult> GetCaseHandler1()
        //    {
        //        try
        //        {
        //            var casehandler1 = await _repository.GetCaseHandler1DropDown();
        //            return Ok(casehandler1);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetCaseHandler2")]
        //    public async Task<IActionResult> GetCaseHandler2()
        //    {
        //        try
        //        {
        //            var casehandler2 = await _repository.GetCaseHandler2DropDown();
        //            return Ok(casehandler2);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        //    [HttpGet("GetCountry")]
        //    public async Task<IActionResult> GetCountry()
        //    {
        //        try
        //        {
        //            var country = await _repository.GetCountryDropDown();
        //            return Ok(country);
        //        }
        //        catch (Exception ex)
        //        {
        //            return StatusCode(500, "Internal server error: " + ex.Message);
        //        }
        //    }

        [HttpGet("getall")]
        public async Task<ActionResult<DropdownResponseDto>> GetAllDropdowns()
        {
            try
            {
                var result = await _repository.GetAllDropdowns();
                return Ok(result);
            }
            catch (Exception ex)
            {
               
                return StatusCode(500, new { message = "An error occurred while fetching dropdowns.", detail = ex.Message });
            }
        }

    }

}
    