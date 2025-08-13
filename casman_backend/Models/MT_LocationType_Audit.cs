using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_LocationType_Audit")]
public partial class MT_LocationType_Audit
{
    public int? LTID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? LocationTypeName { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool? Selectable { get; set; }

    public int? Level { get; set; }

    public bool? DefaultCanBeHomeLocation { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }
}
