using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblClosingSummary")]
public partial class TblClosingSummary
{
    [StringLength(8)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Sub_ID { get; set; } = null!;

    public bool Policy_Repudiation { get; set; }

    public bool Informed_Member { get; set; }

    public bool Stood_Down_Experts { get; set; }

    public bool Paid_Final_Invoices { get; set; }

    public bool Notified_CRU { get; set; }

    public bool Checked_Records { get; set; }

    public bool? Costs_Assessment { get; set; }

    public bool County_Court { get; set; }

    public bool High_Court { get; set; }

    public bool Court_of_Appeal { get; set; }

    public bool Lords { get; set; }

    public bool? Cond_Fee { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Success_Fee_Agreed { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Success_Fee_Agreed1 { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Success_Fee_Agreed2 { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Ins_Fee_Agreed { get; set; }

    public bool Alter_Dis_Res { get; set; }

    public bool Infant_App { get; set; }

    public bool Court_App { get; set; }

    public bool Detailed_Assessment { get; set; }

    public bool Rude { get; set; }

    public bool Uncop { get; set; }

    public bool SexMisconduct { get; set; }

    public bool outofhours { get; set; }

    public bool Vic_Liab_Adm { get; set; }

    public bool Vic_Liab_Clin { get; set; }

    public bool Pvt_Sec { get; set; }

    public bool Cnst_Iss { get; set; }

    public bool HealthPrblm { get; set; }

    public bool TrsutInves { get; set; }

    public bool Inad_Notes { get; set; }

    public bool Prev_GMC_Ref { get; set; }

    public bool Locum { get; set; }

    public bool NHS_Direct { get; set; }

    public bool No_rel_data { get; set; }

    public bool Dis_Col { get; set; }

    public bool Criticism { get; set; }

    public bool Os_splty { get; set; }

    public bool? Cmtee_Recom { get; set; }

    public bool? Mdu_Committee { get; set; }

    public bool? CaseHandler { get; set; }

    public bool? Other { get; set; }

    public bool? FileDestroyed { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? FileDestroyed_Reason { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public bool? GPWSI { get; set; }

    public bool? Nurse_Practitioner { get; set; }

    public bool? Practice_Nurse { get; set; }

    public bool? GDC_Complaint { get; set; }

    public bool? Part_Offer { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? OfferReceived_Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OfferReceived_Date { get; set; }

    public bool? Successful_CRU_Appeal { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Successful_CRU_Appeal_Amt { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? AddlPart36OfferRcvd_Amt2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AddlPart36OfferRcvd_Date2 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? AddlPart36OfferRcvd_Amt3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AddlPart36OfferRcvd_Date3 { get; set; }

    public bool? Sucessful_NHS_Appeal { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Sucessful_NHS_Appeal_Amt { get; set; }

    public bool? Part_Offer_made { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Part36OfferMade_Amt1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Part36OfferMade_Date1 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Part36OfferMade_Amt2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Part36OfferMade_Date2 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Part36OfferMade_Amt3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Part36OfferMade_Date3 { get; set; }
}
