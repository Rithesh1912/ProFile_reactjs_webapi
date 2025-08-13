using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblExpertDentalSpclty")]
public partial class TblExpertDentalSpclty
{
    public int? Expert_id { get; set; }

    public int? Dental_spclty_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date_last_updated { get; set; }
}
