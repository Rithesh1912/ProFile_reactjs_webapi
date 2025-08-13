using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_type", "mdu_liability1")]
[Table("mdu_liability")]
public partial class mdu_liability
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string case_type { get; set; } = null!;

    [Key]
    [Column("mdu_liability")]
    [StringLength(1)]
    [Unicode(false)]
    public string mdu_liability1 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? liab_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
