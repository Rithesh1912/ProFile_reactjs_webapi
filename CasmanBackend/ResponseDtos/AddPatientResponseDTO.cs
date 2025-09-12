namespace CasmanSln.ResponseDtos
{
    public class AddPatientResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int PtNumber { get; set; } 
        public string CaseId { get; set; }
        public string SubsidId { get; set; }
    }

}
