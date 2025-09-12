namespace CasmanSln.ResponseDtos
{
    public class ViewPatientResponseDTO
    {
        public string CaseId { get; set; }
        public string SubsidId { get; set; }
        public string PtNumber { get; set; }
        public string PtLname { get; set; }
        public string PtFname { get; set; }
        public string PtTitle { get; set; }
        public string PtInit { get; set; }
        public string PtSex { get; set; }  // changed to string
        public string PtNino { get; set; }
        public DateTime? PtDob { get; set; }
        public int? PtAgeInc { get; set; }
        public string PtSol { get; set; }
        public string PtAddr1 { get; set; }
        public string PtAddr2 { get; set; }
        public string PtAddr3 { get; set; }
        public string PtAddr4 { get; set; }
        public string PtAddr5 { get; set; }
        public string PtAddrPostCode { get; set; }
        public string PtSolAddr1 { get; set; }
        public string PtSolAddr2 { get; set; }
        public string PtSolAddr3 { get; set; }
        public string PtSolAddr4 { get; set; }
        public string PtSolAddr5 { get; set; }
        public string PtSolPostCode { get; set; }
        public bool? PtIncomplete { get; set; }
        public bool? PtDeceased { get; set; }
        public string UserId { get; set; }
        public DateTime? DateLastUpdated { get; set; }
        public int? LockNo { get; set; }
        public bool? PatientInformed { get; set; }
        public string PtLnameInit { get; set; }
        public string Problem { get; set; }
        public string Sanction { get; set; } // changed to string
        public DateTime? SanctionDate { get; set; }
    }
}
