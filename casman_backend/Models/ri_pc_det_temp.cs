using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ri_pc_det_temp")]
public partial class ri_pc_det_temp
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    public int sequence_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pc_date { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? pc_value { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? pc_type { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? type { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? reference { get; set; }

    public int? batch_id { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? stg_amount { get; set; }

    public short lock_no { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Department { get; set; }

    public bool VAT_Manual { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal VAT_Amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Net_Amount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sanction { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Sanction_Date { get; set; }
}
