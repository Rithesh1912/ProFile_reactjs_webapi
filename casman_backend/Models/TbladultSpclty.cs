using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TbladultSpclty")]
public partial class TbladultSpclty
{
    [Key]
    public int Adult_spclty_id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Adult_spclty { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Valid { get; set; } = null!;
}
