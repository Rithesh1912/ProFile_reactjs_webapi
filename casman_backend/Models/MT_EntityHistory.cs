using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_EntityHistory")]
public partial class MT_EntityHistory
{
    [Key]
    public int EHID { get; set; }

    public int? EID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ChangeType { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? AttributeChanged { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? AttributeValueBefore { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChangeDateTime { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? UserID { get; set; }
}
