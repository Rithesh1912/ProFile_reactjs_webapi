using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("staff_id", "week_end", "case_id", "subsid_id", "work_cat_code", "week_day", "order_no")]
[Table("timesheet")]
public partial class timesheet
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime week_end { get; set; }

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Key]
    public int order_no { get; set; }

    [Key]
    public short week_day { get; set; }

    public short time_spent { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string work_cat_code { get; set; } = null!;

    public short lock_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }
}
