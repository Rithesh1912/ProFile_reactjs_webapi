using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("staff_id", "case_id", "subsid_id")]
[Index("staff_id", Name = "index_staff_id")]
public partial class t_recent_case
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime search_date { get; set; }
}
