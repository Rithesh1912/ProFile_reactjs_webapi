using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_Location_Audit")]
public partial class MT_Location_Audit
{
    public int? LID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Barcode { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? LocationName { get; set; }

    public int? ParentLocation { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? LocationType { get; set; }

    public bool? Active { get; set; }

    public bool? CanBeHomeLocation { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }
}
