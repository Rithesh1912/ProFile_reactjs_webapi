using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("app_authority_a")]
public partial class app_authority_a
{
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string authority_function { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? authority_level { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
