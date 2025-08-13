using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblType")]
public partial class TblType
{
    [Key]
    public int Type_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Type_Description { get; set; }
}
