using CasmanSln.Dtos;
using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;

namespace CasmanSln.DataAccess.Interface
{
    public interface ICaseRepository
    {
        Task<CreateCaseResponseDto> CreateNewCaseAsync(CreateCaseRequestDto request);
        Task<List<CaseSearchResponseDto>> SearchCases(CaseSearchRequestDto request);

        Task<UpdateCaseResponseDto>UpdateCaseDetails(UpdateCaseRequestDto request);

        Task<ViewCaseDetailsResponseDto> GetCaseDetailsByCaseId(string caseId, string subId);
    }
}
