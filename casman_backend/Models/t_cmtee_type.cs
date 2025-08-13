using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_cmtee_type")]
public partial class t_cmtee_type
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string cmtee_type { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? cmtee_desc { get; set; }
}
