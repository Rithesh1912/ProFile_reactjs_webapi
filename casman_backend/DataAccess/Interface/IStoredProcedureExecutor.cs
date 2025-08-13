namespace casman.DataAccess.Interface
{
    public interface IStoredProcedureExecutor
    {
        Task<List<T>> ListAsync<T>(string storedProcedure, object parameters = null) where T : class;
        Task<int> ExecuteAsync(string storedProcedure, object parameters = null);
    }
}
