using CasmanSln.RequestDtos;
using CasmanSln.ResponseDtos;

namespace CasmanSln.DataAccess.Interface
{
    public interface IPatientDetails
    {
        Task<List<ViewPatientResponseDTO>> GetPatientInfoByCaseAndSub(ViewPatientRequestDTO request);

        Task<AddPatientResponseDTO> InsertPatientAsync(AddPatientRequestDTO patient);

        Task<bool> DeletePatient(string CaseId, string subsidId, string PtNumber);

        Task<UpdatePatientResponseDTO> UpdatePatient(int CaseId, string SubsidId, int PtNumber, UpdatePatientRequestDTO request);


    }
}
