using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblAdvCaseProgress_a")]
public partial class TblAdvCaseProgress_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_ID { get; set; } = null!;

    public int Adv_Type_ID { get; set; }

    public int Adv_Event_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Adv_Event_date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    public int? ID { get; set; }

    public int? Adv_Dept_ID { get; set; }
}
