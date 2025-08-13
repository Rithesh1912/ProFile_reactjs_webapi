using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class Tblrecoverydtl
{
    public int? Recvr_Batch_id { get; set; }

    public int Sequence_no { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? Department { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Recovery_Type { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Amount { get; set; }

    [StringLength(50)]
    public string? Recovery_From { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Reference { get; set; } = null!;

    [Column(TypeName = "decimal(10, 4)")]
    public decimal? exchange_rate { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? stg_amount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
