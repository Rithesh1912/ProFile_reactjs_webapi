using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_role")]
public partial class t_role
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string role { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? role_desc { get; set; }
}
