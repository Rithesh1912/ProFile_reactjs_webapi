using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_EntityType_Audit")]
public partial class MT_EntityType_Audit
{
    public int? ETID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? EntityTypeName { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool? DefaultName { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }
}
