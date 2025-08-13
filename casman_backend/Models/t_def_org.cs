using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_def_org")]
public partial class t_def_org
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string def_org { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string? def_org_name { get; set; }

    public short? def_order { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
