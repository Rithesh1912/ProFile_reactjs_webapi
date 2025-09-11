
using CasmanSln.ResponseDtos;

namespace CasmanSln.DataAccess.Interface
{
    public interface IDropDowns
    {
        //Task<List<string>> GetIndemnifiersDropdown(string? value = null);

        //Task<List<string>> GetSpecialtiesDropdown();

        //Task<List<string>> GetLiabilitiesDropDown();

        //Task<List<string>> GetCaseTypeDescriptionsDropDown();

        //Task<List<string>> GetCaseStatusDropDown();

        //Task<List<string>> GetDepartmentDropDown();

        //Task<List<string>> GetCaseCategoryDropDown();

        //Task<List<string>> GetCasePracticeDropDown();

        //Task<List<string>> GetCaseFileClassificationDropDown();

        //Task<List<string>> GetCaseHandler1DropDown();

        //Task<List<string>> GetCaseHandler2DropDown();

        //Task<List<string>> GetCountryDropDown();

        Task<DropdownResponseDto> GetAllDropdowns();


    }
}
