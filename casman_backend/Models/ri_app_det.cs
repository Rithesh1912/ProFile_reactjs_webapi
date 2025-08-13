using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid", "org")]
[Table("ri_app_det")]
public partial class ri_app_det
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string org { get; set; } = null!;

    public short? percnt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? comments { get; set; }

    public short lock_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date_Last_Modified { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }
}
