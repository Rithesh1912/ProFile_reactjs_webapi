using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Tblrecoverybatch_a")]
public partial class Tblrecoverybatch_a
{
    [Key]
    public int ID { get; set; }

    public int Recvr_Batch_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Invoice_Date { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Control_Amount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string created_by { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Currency { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Exchange_Rate { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string? _event { get; set; }
}
