using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("cheque_recovery_at")]
public partial class cheque_recovery_at
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    public int sequence_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime recovered_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string recovery_type { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? payment_from { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal local_amount { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string currency { get; set; } = null!;

    [Column(TypeName = "decimal(10, 4)")]
    public decimal exchange_rate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? reference { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? stg_amount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? Department { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal gross_amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal VAT_amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Net_Amount { get; set; }
}
