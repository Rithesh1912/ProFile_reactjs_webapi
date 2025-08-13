using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Tbltarrif")]
public partial class Tbltarrif
{
    [Key]
    public int Tarrif_id { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string tarrif { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
