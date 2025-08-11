
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

        [Column("case_type")]
        public string? CaseType { get; set; }

        [Column("case_stat")]
        public string? CaseStat { get; set; }

        [Column("scrt_usr")]
        public string? ScrtUsr { get; set; }

        [Column("offc")]
        public string Offc { get; set; }

        [Column("case_cat")]
        public string? CaseCat { get; set; }

        [Column("case_class")]
        public string? CaseClass { get; set; }

        [Column("spclty_maj_code")]
        public string? SpcltyMajCode { get; set; }

        [Column("spclty_min_code")]
        public string? SpcltyMinCode { get; set; }

        [Column("hptl_loc")]
        public string? HptlLoc { get; set; }

        [Column("ha_fpc_name")]
        public string? HaFpcName { get; set; }

        [Column("area_code")]
        public string? AreaCode { get; set; }

        [Column("prac_area_code")]
        public string? PracAreaCode { get; set; }

        [Column("incdt_date")]
        public DateTime? IncdtDate { get; set; }

        [Column("open_date")]
        public DateTime? OpenDate { get; set; }

        [Column("close_date")]
        public DateTime? CloseDate { get; set; }

        [Column("pymnt_data_avail")]
        public bool? PymntDataAvail { get; set; }

        [Column("reins_data_avail")]
        public bool? ReinsDataAvail { get; set; }

        [Column("ref_data_avail")]
        public bool? RefDataAvail { get; set; }

        [Column("case_notes_avail")]
        public bool? CaseNotesAvail { get; set; }

        [Column("case_of_int")]
        public bool? CaseOfInt { get; set; }

        [Column("ha_aprvd")]
        public bool? HaAprvd { get; set; }

        [Column("mdureins_hal")]
        public string? MduReinsHal { get; set; }

        [Column("mfiche_no")]
        public string? MficheNo { get; set; }

        [Column("cru")]
        public string? Cru { get; set; }

        [Column("first_pg_loc")]
        public string? FirstPgLoc { get; set; }

        [Column("mdu_liability")]
        public string? MduLiability { get; set; }

        [Column("old_case_type")]
        public string? OldCaseType { get; set; }

        [Column("second_scrt_usr")]
        public string? SecondScrtUsr { get; set; }

        [Column("user_id")]
        public string? UserId { get; set; }

        [Column("date_last_updated")]
        public DateTime? DateLastUpdated { get; set; }

        [Column("lock_no")]
        public int? LockNo { get; set; }

        [Column("file_class_code")]
        public string? FileClassCode { get; set; }

        [Column("shared_case")]
        public bool? SharedCase { get; set; }

        [Column("third_scrt_usr")]
        public string? ThirdScrtUsr { get; set; }

        [Column("fac_postcode")]
        public string? FacPostcode { get; set; }

        [Column("YearOfCase")]
        public int? YearOfCase { get; set; }

        [Column("redact_case")]
        public bool? RedactCase { get; set; }

        [Column("redact_case_rule")]
        public string? RedactCaseRule { get; set; }

        [Column("Case_Document_Status")]
        public string? CaseDocumentStatus { get; set; }

        [Column("clfn_code")]
        public string? ClfnCode { get; set; }

        [Column("CLAIM_DATE")]
        public DateTime? ClaimDate { get; set; }

        [Column("Legal_case_Document_Status")]
        public string? LegalCaseDocumentStatus { get; set; }

        [Column("DOI_Status")]
        public string? DoiStatus { get; set; }

        [Column("Case_Create_Source")]
        public string? CaseCreateSource { get; set; }

        [Column("RetentionActionedDT")]
        public DateTime? RetentionActionedDT { get; set; }

        [Column("RetentionActionedPolicyName")]
        public string? RetentionActionedPolicyName { get; set; }

        [Column("Adv_Close_Date")]
        public DateTime? AdvCloseDate { get; set; }

        [Column("prodType")]
        public string? ProdType { get; set; }

        [Column("case_uri")]
        public string? CaseUri { get; set; }

        [Column("MissedKPI_Code")]
        public string? MissedKpiCode { get; set; }
    }
}
