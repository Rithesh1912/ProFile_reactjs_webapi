using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id", "cmtee_date", "cmtee_type", "sequence_no", "org")]
[Table("t_cmtee_apptmt")]
public partial class t_cmtee_apptmt
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime cmtee_date { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string cmtee_type { get; set; } = null!;

    [Key]
    public short sequence_no { get; set; }

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string org { get; set; } = null!;

    public short? apptmt_org { get; set; }

    public short lock_no { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
