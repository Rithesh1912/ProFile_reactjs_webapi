using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;

namespace CasmanSln.DataAccess.Interface
{
    public interface IPractionerRepository
    {
        Task<GetPractionerResponseDto>GetPractionerDetailsByCaseID(string caseID,string subID);
        Task<AddPractResponseDto> AddPractDetailsByCaseID(AddPractRequestDto requestDto);

        Task<IEnumerable<ConflictSearchResponseDto>> GetPracDetailsByName(ConflictSearchRequestDto conflictSearchRequestDto);

    }
}
