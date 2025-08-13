using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("country")]
public partial class country
{
    [Key]
    [Column("country")]
    [StringLength(3)]
    [Unicode(false)]
    public string country1 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? description { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ctry_nominal_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
