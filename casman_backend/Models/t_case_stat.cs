using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_case_stat")]
public partial class t_case_stat
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string case_stat { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? stat_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
