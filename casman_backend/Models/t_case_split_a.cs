using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_case_split_a")]
public partial class t_case_split_a
{
    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string EventType { get; set; } = null!;

    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? orig_subsid_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? split_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? split_date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? staff_id { get; set; }
}
