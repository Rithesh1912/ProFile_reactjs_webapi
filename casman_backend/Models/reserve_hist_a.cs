using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("reserve_hist_a")]
public partial class reserve_hist_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? settle_val { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? plaintiff_val { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? settle_reason { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    public short? mdu_pcnt { get; set; }

    public short? grp_pcnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Liability_Adjustment_Settle { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Liability_Adjustment_ClaimantCosts { get; set; }

    public short? Liability_Adjustment_Percent { get; set; }

    public bool Insufficient_Information_box { get; set; }
}
