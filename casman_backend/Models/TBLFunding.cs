using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("Case_ID", "Sub_ID")]
[Table("TBLFunding")]
public partial class TBLFunding
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string Sub_ID { get; set; } = null!;

    public bool? ATE_New { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ATE_New_Date { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? ATE_New_Premium { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ATE_New_ExpertRpt { get; set; }

    public bool? ATE_Old { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ATE_Old_Date { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? ATE_Old_Premium { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? ATE_Old_idemnity { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? Amt_Claimed { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? Amt_Paid { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? Amt_Difference { get; set; }

    public bool Unknown { get; set; }

    public int? SettlementType { get; set; }
}
