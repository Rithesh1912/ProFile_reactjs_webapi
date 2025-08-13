using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_offc")]
public partial class t_offc
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string offc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? offc_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
