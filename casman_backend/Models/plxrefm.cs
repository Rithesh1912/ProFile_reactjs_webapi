using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("plxrefm")]
public partial class plxrefm
{
    [Key]
    public int unique_no { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string customer { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string batch_item_no { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string transaction_item { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? allocated_date { get; set; }

    public double allocated_amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string second_ref { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string item_type { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency_code { get; set; } = null!;
}
