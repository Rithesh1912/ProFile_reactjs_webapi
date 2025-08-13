using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("assignment_a")]
public partial class assignment_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    public short assign_seq_num { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string solicitor_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? assign_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? assign_end { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? legal_code { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? outcome { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? Comments { get; set; }

    public int? Control_No { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? assign_accept { get; set; }

    public bool? rule4 { get; set; }

    public bool Ins_for_Legal_Diary { get; set; }

    public bool? Transferred_Case { get; set; }
}
