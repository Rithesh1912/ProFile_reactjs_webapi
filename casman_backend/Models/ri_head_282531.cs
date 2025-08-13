using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ri_head_282531")]
public partial class ri_head_282531
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Liability_Adjustment_Settle { get; set; }
}
