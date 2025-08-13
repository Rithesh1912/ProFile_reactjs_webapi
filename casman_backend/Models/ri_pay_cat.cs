using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("ri_pay_cat")]
public partial class ri_pay_cat
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string pay_cat { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? pay_cat_desc { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? old_pay_cat_desc { get; set; }
}
