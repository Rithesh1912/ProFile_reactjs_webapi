using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblKeyword_a")]
public partial class TblKeyword_a
{
    [Key]
    public long AuditId { get; set; }

    public string? XML { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Event { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
