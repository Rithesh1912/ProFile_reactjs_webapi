using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_prac_area")]
public partial class t_prac_area
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string prac_area_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? prac_area_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
