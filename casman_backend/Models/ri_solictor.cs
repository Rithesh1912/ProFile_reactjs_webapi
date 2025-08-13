using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("ri_solictor")]
public partial class ri_solictor
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string sol_code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? sol_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? int_ext { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
