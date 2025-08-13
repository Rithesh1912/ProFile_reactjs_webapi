using casman.Models;

namespace casman.DataAccess.Interface
{
    public interface IPractionerDetails
    {
        Task<List<t_case_prac>> GetAllPractionerDetails();

        Task<t_case_prac> GetPractionerByCaseId(string caseId, string subId);

        Task<t_case_prac> CreatePractioner(t_case_prac newPrac);

        Task<bool> UpdatePractionerDetails(string pracNum, t_case_prac newPrac);

        Task<bool> DeletePractioner(string pracNum);
    }
}
