using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_case_rest_a")]
public partial class t_case_rest_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
