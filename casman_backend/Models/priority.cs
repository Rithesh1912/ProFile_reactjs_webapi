using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("priority")]
public partial class priority
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string priority_code { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? priority_desc { get; set; }
}
