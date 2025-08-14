using CasmanSln.Models;

namespace CasmanSln.DataAccess.Interface
{
    public interface ICaseDetails
    {
        Task<List<Case>> GetAllCaseDetails();
       

        Task<Case>GetCaseDetailsById(string caseId,string subId);

        Task<Case> CreateCase(Case newCase);

       /* Task<Case> UpdateCase(Case newCase);*/
    }
}
