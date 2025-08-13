using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("split_reason")]
public partial class split_reason
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string split_reason_code { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? split_reason_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
