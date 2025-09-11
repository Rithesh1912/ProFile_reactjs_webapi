using CasmanSln.Models;

namespace CasmanSln.ResponseDtos
{
    public class CaseSearchResponseDto
    {
        public string CaseId { get; set; }
        public string SubsidId { get; set; }
        public string MduUnit { get; set; }
        public DateTime? IncdtDate { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string SecondScrtUsr { get; set; }
        public string UserId { get; set; }
        public DateTime? DateLastUpdated { get; set; }
        public string ThirdScrtUsr { get; set; }
        public int? YearOfCase { get; set; }
        public DateTime? ClaimDate { get; set; }
        public string LegalCaseDocumentStatus { get; set; }
        public string CaseCreateSource { get; set; }
        public string CaseUri { get; set; }
      /*  public List<Case> Items { get; set; }
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }*/
    }
}
