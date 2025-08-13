using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblpaediatricSpclty")]
public partial class TblpaediatricSpclty
{
    [Key]
    public int Paed_spclty_id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Paed_splty { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
