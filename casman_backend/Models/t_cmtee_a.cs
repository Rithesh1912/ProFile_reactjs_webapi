using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_cmtee_a")]
public partial class t_cmtee_a
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

    [StringLength(8)]
    [Unicode(false)]
    public string? auth { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? scrt_pres { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? stdg_date { get; set; }

    [StringLength(450)]
    [Unicode(false)]
    public string? cmtee_comm { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cmtee_dcsn { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cmtee_dcsn2 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cmtee_dcsn3 { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cmtee_dcsn4 { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? qtm_amt { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? crcy { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? RecommToTheBOM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecommToTheBOM_Datemodified { get; set; }

    public string? cmtee_comm_nohtml { get; set; }
}
