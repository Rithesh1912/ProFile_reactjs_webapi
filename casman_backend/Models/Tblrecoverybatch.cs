using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Tblrecoverybatch")]
public partial class Tblrecoverybatch
{
    [Key]
    public int Recvr_Batch_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Invoice_Date { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Control_Amount { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Created_By { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? User_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date_Last_Updated { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Currency { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Exchange_Rate { get; set; } = null!;
}
