using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_LocationType")]
public partial class MT_LocationType
{
    [Key]
    public int LTID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? LocationTypeName { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Level { get; set; }

    public bool? Selectable { get; set; }

    public bool? DefaultCanBeHomeLocation { get; set; }

    [InverseProperty("LocationTypeNavigation")]
    public virtual ICollection<MT_Location> MT_Locations { get; set; } = new List<MT_Location>();
}
