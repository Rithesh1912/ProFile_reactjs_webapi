using CasmanSln.Dtos;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Dynamic.Core;

namespace CasmanSln.DataAccess.Interface
{
    public interface ICaseRepository
    {
        Task<CreateCaseResponseDto> CreateNewCaseAsync(CreateCaseRequestDto request);
        Task<ResponseDtos.PagedResult<CaseSearchResponseDto>> SearchCases(CaseSearchRequestDto request);

        Task<UpdateCaseResponseDto> UpdateCaseDetails(UpdateCaseRequestDto request);

        Task<ViewCaseDetailsResponseDto> GetCaseDetailsByCaseId(string caseId, string subId);

        Task<String> AddRecentCase(AddRecentCaseRequestDto request);

        Task<List<GetRecentCaseResponseDto>> GetRecentCaseDetailsByStaffId(String StaffId);
    }
}