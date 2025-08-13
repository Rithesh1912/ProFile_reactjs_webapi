using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("review_reason")]
public partial class review_reason
{
    [Key]
    public short review_type { get; set; }

    [Column("review_reason")]
    [StringLength(30)]
    [Unicode(false)]
    public string? review_reason1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? review_delete { get; set; }
}
