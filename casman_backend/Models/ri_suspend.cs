using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ri_suspend")]
public partial class ri_suspend
{
    public int batch_id { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? batch_value { get; set; }

    public short? batch_pos { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pay_type { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? requested_by { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? stg_amount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Department { get; set; }
}
