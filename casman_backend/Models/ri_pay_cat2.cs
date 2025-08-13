using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("ri_pay_cat2")]
public partial class ri_pay_cat2
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string pay_type_2 { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? pay_description { get; set; }
}
