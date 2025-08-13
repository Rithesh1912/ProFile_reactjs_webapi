using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("AmountValue")]
public partial class AmountValue
{
    [Column(TypeName = "decimal(10, 2)")]
    public decimal? FxAmount { get; set; }
}
