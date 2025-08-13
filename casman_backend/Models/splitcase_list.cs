using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid")]
[Table("splitcase_list")]
public partial class splitcase_list
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    public short? no_of_subs { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? staff_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? change_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? processed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? open_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? split_reason { get; set; }
}
