using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_EntityRelationships_Audit")]
public partial class MT_EntityRelationships_Audit
{
    public int? ERID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? RelationshipID { get; set; }

    public int? EID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }
}
