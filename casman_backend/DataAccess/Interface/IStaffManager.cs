using casman.Models;

namespace casman.DataAccess.Interface
{
    public interface IStaffManager
    {
        Task<staff> GetStaffDetailsById(staff staffId);

        Task<staff> GetAllStaffDetails();
       /* Task<staff>CreateStaff(staff staff);
        Task<staff>DeleteStaff(staff staffId);*/
    }
}
