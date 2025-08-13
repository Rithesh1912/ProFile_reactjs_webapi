using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_EntityHistory_Audit")]
public partial class MT_EntityHistory_Audit
{
    public int? EHID { get; set; }

    public int? EID { get; set; }

    [StringLength(250)]
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
    public string? UserId { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }
}
