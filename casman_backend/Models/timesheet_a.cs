using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("timesheet_a")]
public partial class timesheet_a
{
    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string change_type { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime week_end { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    public int order_no { get; set; }

    public short week_day { get; set; }

    public short time_spent { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? work_cat_code { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
