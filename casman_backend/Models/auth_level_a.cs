using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("auth_level_a")]
public partial class auth_level_a
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

    [Column(TypeName = "datetime")]
    public DateTime last_upddate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string last_upd_userid { get; set; } = null!;

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
