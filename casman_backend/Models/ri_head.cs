using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid")]
[Table("ri_head")]
public partial class ri_head
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? narrative { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? solicitor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sol_inst { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sol_writ { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? sol_ref { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? sol_part { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_settled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_claim { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? period { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? exp_settle_date { get; set; }

    public short? recovery_due { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? recovery_date { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? recovery_amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? settle_val { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? plaintiff_val { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? settle_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? statute_barred_dt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? soc_date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? requested_by { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? authorised_by { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? sol_control_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? trial_date { get; set; }

    public short? never_stat_barred { get; set; }

    public short? appeal_pending { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? app_rec { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? disc_due { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? rec_disc_on { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? letter_of_claim { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? net_settle_val { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? net_plaintiff_val { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? cond_fee_arrang { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public short lock_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Case_Pleaded_AvH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Case_Pleaded_PD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Case_Pleaded_PP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Case_Pleaded_PPV { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Prov_of_Settlement_AvH { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Prov_of_Settlement_PD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Prov_of_Settlement_PP { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Prov_of_Settlement_PPV { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? State_Claims_Agency { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Letter_of_response { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? File_dest_date { get; set; }

    public bool? BRAIN_DAMAGED_CLAIMANT { get; set; }

    public bool? INFANT_CLAIMANT { get; set; }

    public bool? STANDARD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Part_8_Proceedings { get; set; }

    public short? claimant_under_disb { get; set; }

    public bool? Prov_of_sett_Rec_of_NHS_Charges { get; set; }

    public bool? Rec_of_NHS_Charges { get; set; }

    public bool? Case_Funding_Private { get; set; }

    public bool? Case_Funding_Unknown { get; set; }

    public bool? Case_Funding_Legal_Aid { get; set; }

    public bool? Fatal_Case { get; set; }

    public bool? Case_Funding_Legal_Expense { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? cond_fee_arrang_ATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? cond_fee_arrang_BTE { get; set; }

    public short? Irish_cap { get; set; }

    public bool? Case_Funding_cond_fee_arange_pre { get; set; }

    public bool? Case_Funding_cond_fee_arange_post { get; set; }

    public bool? Case_Funding_aftr_evnt_insur { get; set; }

    public bool? Case_Funding_aftr_evnt_pre { get; set; }

    public bool? Case_Funding_aftr_evnt_post { get; set; }

    public bool? Case_Funding_BTE_Insur { get; set; }

    public bool? Case_Funding_damage_agreemnt { get; set; }

    public bool? Case_Funding_self_Litigants { get; set; }

    public bool? Case_Funding_LegaAid_New { get; set; }

    public bool? Case_Funding_Pvt_Solicitor { get; set; }

    public bool? DoNotDestory { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ReasonArchiving { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RESP_LETTER_OF_NOTIFY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LETTER_OF_NOTIFY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DNPRAB_date { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string? DNPRAB_Reason { get; set; }

    public bool? Legal_Hold { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Liability_Adjustment_Settle { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Liability_Adjustment_ClaimantCosts { get; set; }

    public short? Liability_Adjustment_Percent { get; set; }

    public bool Insufficient_Information_box { get; set; }
}
