using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("user_id", "app_id", "role")]
[Table("app_user")]
public partial class app_user
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;

    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string role { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? level { get; set; }
}
