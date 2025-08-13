using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_spclty")]
public partial class t_spclty
{
    [StringLength(4)]
    [Unicode(false)]
    public string? spclty_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? spclty_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? claims_use { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? mem_use { get; set; }
}
