using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("indemnifier")]
public partial class indemnifier
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string org { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? org_desc { get; set; }
}
