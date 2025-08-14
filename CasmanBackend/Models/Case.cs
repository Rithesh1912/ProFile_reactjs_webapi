
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CasmanSln.Models
{
   
    public class Case
    {
        [Key]
        [Column("case_id")]
        public string CaseId { get; set; }

        [Column("subsid_id")]
        public string? SubsidId { get; set; }

        [Column("mdu_unit")]
        public string? MduUnit { get; set; }

        [Column("incdt_date")]
        public DateTime? IncdtDate { get; set; }

        [Column("open_date")]
        public DateTime? OpenDate { get; set; }

        [Column("close_date")]
        public DateTime? CloseDate { get; set; }

       
        [Column("second_scrt_usr")]
        public string? SecondScrtUsr { get; set; }

        [Column("user_id")]
        public string? UserId { get; set; }

        [Column("date_last_updated")]
        public DateTime? DateLastUpdated { get; set; }

        [Column("third_scrt_usr")]
        public string? ThirdScrtUsr { get; set; }


        [Column("YearOfCase")]
        public int? YearOfCase { get; set; }

       
        [Column("CLAIM_DATE")]
        public DateTime? ClaimDate { get; set; }

        [Column("Legal_case_Document_Status")]
        public string? LegalCaseDocumentStatus { get; set; }

       
        [Column("Case_Create_Source")]
        public string? CaseCreateSource { get; set; }

        [Column("case_uri")]
        public string? CaseUri { get; set; }

       
    }
}
