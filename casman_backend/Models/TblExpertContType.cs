using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblExpertContType")]
public partial class TblExpertContType
{
    [Key]
    public int Expert_Cont_Type_Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Expert_Cont_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
