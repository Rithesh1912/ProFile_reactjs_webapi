using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("invoice_a")]
public partial class invoice_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    public int sequence_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime invoice_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? payment_date { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? invoice_reference { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? invoice_amount { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? batch_id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? mdu_reference { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? currency_code { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? exchange_rate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? payee { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? payee_name { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? authorised_by { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? requested_by { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? forward_to { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address1 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address2 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address3 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address4 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address5 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? postcode { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? priority { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pc_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? invoice_status { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? alpha_code { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? stg_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? allocated_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? analysis_codes3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DATEOFDEATH { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? ASHEINDEX { get; set; }

    public bool? MEDICALREPORT { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? RPI { get; set; }

    public int DupPayReason_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? PAYINDSTUS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BANKSORTCODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BANKACCOUNT { get; set; }
}
