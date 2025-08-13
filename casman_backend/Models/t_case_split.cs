using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id")]
[Table("t_case_split")]
public partial class t_case_split
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string orig_subsid_id { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string split_reason { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime split_date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? staff_id { get; set; }
}
