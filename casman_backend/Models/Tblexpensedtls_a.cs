using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Tblexpensedtls_a")]
public partial class Tblexpensedtls_a
{
    public int? Exp_Batch_id { get; set; }

    public int Sequence_no { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Staff { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Recovered_Date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Reference { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? currency_code { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? exchange_rate { get; set; }

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
}
