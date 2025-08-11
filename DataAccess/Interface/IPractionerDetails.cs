using CasmanSln.Models;

namespace CasmanSln.DataAccess.Interface
{
    public interface IPractionerDetails
    {
        Task<List<CasePractioner>> GetAllPractionerDetails();

       Task<CasePractioner> GetPractionerByCaseId(string caseId,string subId);

       Task<CasePractioner> CreatePractioner(CasePractioner newPrac);

        Task<bool>UpdatePractionerDetails(string PracNum, CasePractioner newPrac);

        Task<bool>DeletePractioner(string PracNum);
    }
}
