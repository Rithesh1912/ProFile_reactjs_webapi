using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("staff_id", "app_id", "authority_function", "authority_level")]
[Table("app_authority")]
public partial class app_authority
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string authority_function { get; set; } = null!;

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string authority_level { get; set; } = null!;

    public short lock_no { get; set; }
}
