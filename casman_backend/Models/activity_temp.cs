using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("activity_temp")]
public partial class activity_temp
{
    [StringLength(3)]
    [Unicode(false)]
    public string? activity { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? activity_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
