using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id", "cmtee_date", "cmtee_type", "sequence_no")]
[Table("t_cmtee")]
public partial class t_cmtee
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
    public DateTime? date_last_updated { get; set; }

    public short lock_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RecommToTheBOM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecommToTheBOM_Datemodified { get; set; }

    public string? cmtee_comm_nohtml { get; set; }
}
