using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_cru_stat")]
public partial class t_cru_stat
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string cru_status { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string cru_status_desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    public int? sort_order { get; set; }
}
