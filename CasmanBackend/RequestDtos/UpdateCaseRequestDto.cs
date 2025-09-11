using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasmanSln.RequestDtos
{
    public class UpdateCaseRequestDto
    {
        [Key]
        [Column("case_id")]
        public string CaseId { get; set; }

        [Column("subsid_id")]
        public string? SubsidId { get; set; }

        [Column("mdu_unit")]
        public string? Department { get; set; }

        [Column("case_type")]
        public string CaseType { get; set; }

        [Column("scrt_user")]
        public string caseHandler1 { get; set; }

        [Column("second_scrt_usr")]
        public string? caseHandler2 { get; set; }

        [Column("mduLiability")]
        public string MduLiability { get; set; }

        [Column("case_cat")]
        public string CaseCategory { get; set; }

        [Column("case_spl")]
        public string CaseSpeciality { get; set; }

        [Column("case_prac")]
        public string CasePractice { get; set; }

     


        [Column("third_scrt_usr")]
        public string? ThirdScrtUsr { get; set; }

       
        [Column("incdt_date")]
        public DateTime? IncdtDate { get; set; }

        [Column("CLAIM_DATE")]
        public DateTime? ClaimDate { get; set; }

        [Column("close_date")]
        public DateTime? CloseDate { get; set; }

        [Column("date_last_updated")]
        public DateTime? DateLastUpdated { get; set; }

        [Column("Legal_case_Document_Status")]
        public string? LegalCaseDocumentStatus { get; set; }

    }
}
