using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid", "leg_type")]
[Table("ri_leg_det")]
public partial class ri_leg_det
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal leg_value { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? leg_other { get; set; }

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string leg_type { get; set; } = null!;

    public short lock_no { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
