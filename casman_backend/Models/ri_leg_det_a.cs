using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ri_leg_det_a")]
public partial class ri_leg_det_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? leg_fee_value { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? disb_value { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string? _event { get; set; }

    public int KeyNo { get; set; }
}
