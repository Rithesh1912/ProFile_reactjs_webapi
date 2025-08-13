using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Tbl_Fund_SettlementType")]
public partial class Tbl_Fund_SettlementType
{
    [Key]
    public int CostId { get; set; }

    public string? SettlementType { get; set; }
}
