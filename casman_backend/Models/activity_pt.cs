using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("activity_pt")]
public partial class activity_pt
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string activity { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? activity_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
