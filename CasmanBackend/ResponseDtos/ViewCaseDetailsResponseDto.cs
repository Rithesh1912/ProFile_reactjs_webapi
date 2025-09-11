namespace CasmanSln.ResponseDtos
{
    public class ViewCaseDetailsResponseDto
    {
        public string CaseId { get; set; }
        public string SubsidId { get; set; }
        public string? Department { get; set; }
        public string? CaseType { get; set; }
        public string? MduLiability { get; set; }
        public string? CaseCategory { get; set; }
        public string? CaseSpeciality { get; set; }
        public string? CasePractice { get; set; }
        public DateTime? IncdtDate { get; set; }
       
        public string? CaseHandler1 { get; set; }
        public string? CaseHandler2 { get; set; }
      
        public DateTime? ClaimDate { get; set; }
       
        public string? LegalCaseDocumentStatus { get; set; }
    }
}
