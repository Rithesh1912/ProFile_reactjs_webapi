using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("auth_level")]
public partial class auth_level
{
    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string authority_function { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string authority_level { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? level_desc { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? auth_amount { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? country_code { get; set; }

    public short lock_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sort_order { get; set; }
}
