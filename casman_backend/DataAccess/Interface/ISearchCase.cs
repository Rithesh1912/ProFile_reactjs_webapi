using casman.ResponseDtos;

namespace casman.DataAccess.Interface
{
    public interface ISearchCase
    {
        public Task<Dictionary<string, object>?> SearchCaseDetails(string caseID, string subId);

    }
}
