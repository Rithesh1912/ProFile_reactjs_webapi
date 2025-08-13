using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("activity1", "dept_id")]
[Table("activity")]
public partial class activity
{
    [Key]
    [Column("activity")]
    [StringLength(3)]
    [Unicode(false)]
    public string activity1 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? activity_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string dept_id { get; set; } = null!;
}
