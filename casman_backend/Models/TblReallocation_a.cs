using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblReallocation_a")]
public partial class TblReallocation_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Staff_from { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Staff_to { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Daterealloc { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Realloc_Reason { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
