using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblHighValueReview")]
public partial class TblHighValueReview
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_Id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_Id { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string User_Id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Date_Last_Updated { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Jurisdiction { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfLetterbeforeAction { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? AllNamedDefendants { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ThompstoneParagraph { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesFromDate1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesFromDate2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesFromDate3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesFromDate4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesToDate1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesToDate2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesToDate3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClinicalFeaturesToDate4 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ClinicalFeaturesChronHist1 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ClinicalFeaturesChronHist2 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ClinicalFeaturesChronHist3 { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ClinicalFeaturesChronHist4 { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? ReinsurancePolicyYear { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? InterimPaymentDamages { get; set; }

    [Column(TypeName = "numeric(12, 2)")]
    public decimal? InterimPaymentCosts { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ReserveBreakdownSummary { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReserveBreakdownMultiplier { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CasePleadedPD { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CasePleadedPP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CasePleadedPPV { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? CurrentSituation { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? FutureAction { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? CasePleadedSummary { get; set; }
}
