using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("bsaltiim")]
public partial class bsaltiim
{
    [StringLength(8)]
    [Unicode(false)]
    public string supplier { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string item { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string alt_item { get; set; } = null!;
}
