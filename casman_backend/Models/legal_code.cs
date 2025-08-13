using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("legal_code")]
public partial class legal_code
{
    [Key]
    [Column("legal_code")]
    [StringLength(3)]
    [Unicode(false)]
    public string legal_code1 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? legal_code_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? category { get; set; }
}
