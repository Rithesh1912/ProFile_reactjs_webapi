using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_EntityType")]
public partial class MT_EntityType
{
    [Key]
    public int ETID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? EntityTypeName { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    public bool? DefaultName { get; set; }
}
