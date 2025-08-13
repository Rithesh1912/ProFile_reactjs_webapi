using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_area")]
public partial class t_area
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string area_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? area_desc { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? country_code { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? country_unit { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? country_group { get; set; }

    [Column(TypeName = "decimal(6, 3)")]
    public decimal? country_tax { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ctry_nominal_code { get; set; }

    public short? sort_column { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? area_jurisdiction { get; set; }

    public int? ADULT_LIMITATIONMONTHS { get; set; }

    public int? CHILDREN_LIMITATIONMONTHS { get; set; }

    public int? BRAINDAMAGE_LIMITATIONMONTHS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
