using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_Location")]
public partial class MT_Location
{
    [Key]
    public int LID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string BarCode { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? LocationName { get; set; }

    public int? ParentLocation { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int LocationType { get; set; }

    public bool? Active { get; set; }

    public bool? CanBeHomeLocation { get; set; }

    [ForeignKey("LocationType")]
    [InverseProperty("MT_Locations")]
    public virtual MT_LocationType LocationTypeNavigation { get; set; } = null!;
}
