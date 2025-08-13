using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("cover_type")]
public partial class cover_type
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string cover_type_code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string cover_type_desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
