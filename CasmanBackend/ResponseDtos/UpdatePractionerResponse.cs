namespace CasmanSln.ResponseDtos
{
    public class UpdatePractionerResponse
    {
        public int? CaseId { get; set; }
        public string SubsidId { get; set; }
        public string PracNum { get; set; }
        public string SurName { get; set; }
        public string ForeName { get; set; }
        public string Initial { get; set; }
        public string Sex { get; set; }
        public string Indemnifier { get; set; }
        public string Role { get; set; }
        public string PercentInvolMdu { get; set; }
        public DateTime? DateOfInvolved { get; set; }
        public DateTime? DateOfNotifiedMdu { get; set; }
        public DateTime? DateClaimMode { get; set; }
        public string SpecialityOfDOI { get; set; }
        public string UserId { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
