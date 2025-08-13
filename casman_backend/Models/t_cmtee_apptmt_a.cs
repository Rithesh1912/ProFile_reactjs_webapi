using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_cmtee_apptmt_a")]
public partial class t_cmtee_apptmt_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime cmtee_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string cmtee_type { get; set; } = null!;

    public short sequence_no { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string org { get; set; } = null!;

    public short? apptmt_org { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
