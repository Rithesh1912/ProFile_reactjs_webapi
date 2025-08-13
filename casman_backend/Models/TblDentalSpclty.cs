using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblDentalSpclty")]
public partial class TblDentalSpclty
{
    public int Dental_spclty_id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Dental_spclty { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
