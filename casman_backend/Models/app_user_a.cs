using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("app_user_a")]
public partial class app_user_a
{
    [StringLength(8)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string role { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? level { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
