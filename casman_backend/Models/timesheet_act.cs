using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("timesheet_act")]
public partial class timesheet_act
{
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime week_end { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string activity_id { get; set; } = null!;

    public int order_no { get; set; }

    public short week_day { get; set; }

    public short time_spent { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? activity_code { get; set; }

    public short lock_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
