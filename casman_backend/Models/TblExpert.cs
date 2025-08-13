using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblExpert")]
public partial class TblExpert
{
    public int Expert_id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? First_Name { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string Last_Name { get; set; } = null!;

    [StringLength(240)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? institute { get; set; }

    public int Tariff_id { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? Tariff_terms { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Valid { get; set; } = null!;

    [StringLength(70)]
    [Unicode(false)]
    public string? Street { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? city { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? county { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? postcode { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? Other_Addr { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? PAYEE_CODE { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? PAYEE_NAME { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpertPackSent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpertPackAcknowledged { get; set; }

    public int? Tariff_code_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Address5 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DataControlPolicy { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? CVLinkValue { get; set; }

    public int? Engagement_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StatusDeterminationStatementSent { get; set; }

    [StringLength(200)]
    public string? EngagementOther { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? VATCharged { get; set; }

    public int? VATID { get; set; }

    [StringLength(200)]
    public string? VATOtherCharged { get; set; }

    [StringLength(200)]
    public string? IntermediaryAdditionalInfo { get; set; }
}
