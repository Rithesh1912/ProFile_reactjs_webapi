using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Tblexpensebatch_a")]
public partial class Tblexpensebatch_a
{
    public int Exp_Batch_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Amount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string created_by { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string? _event { get; set; }

    [StringLength(10)]
    public string? Expense_Code { get; set; }
}
