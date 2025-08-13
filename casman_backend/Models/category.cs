using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("category")]
public partial class category
{
    [Key]
    [Column("category")]
    [StringLength(3)]
    [Unicode(false)]
    public string category1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? description { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cat_nominal_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
