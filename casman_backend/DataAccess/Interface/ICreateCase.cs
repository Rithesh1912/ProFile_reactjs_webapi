using casman.RequestDtos;
using Microsoft.AspNetCore.Mvc;

namespace casman.DataAccess.Interface
{
    public interface ICreateCase
    {
        Task<Dictionary<string, object>?> CreateNewCase(CreateCaseDto dto);
    }
}
