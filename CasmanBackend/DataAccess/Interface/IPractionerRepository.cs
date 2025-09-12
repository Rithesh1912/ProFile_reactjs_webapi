using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;

namespace CasmanSln.DataAccess.Interface
{
    public interface IPractionerRepository
    {
        Task<List<GetPractionerResponseDto>> GetPractionerDetailsByCaseID(string caseID, string subID);

       
        Task<bool> AddPractDetailsByCaseID(AddPractRequestDto request);
        Task<bool> DeletePractioner(string CaseId, string SubsidId, string prac_num);

        Task<UpdatePractionerResponse> UpdatePractitioner(int CaseId, string subsidId, string prac_num, UpdatePractionerRequestDTO request);


    }
}
