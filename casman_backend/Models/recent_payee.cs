using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("staff_id", "supplier")]
[Table("recent_payee")]
public partial class recent_payee
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string supplier { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? last_used_date { get; set; }
}
