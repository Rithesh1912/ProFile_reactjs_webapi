using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id")]
[Table("t_case_summ")]
public partial class t_case_summ
{
    public int Rowid { get; set; }

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string? day_one_summ { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public short lock_no { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Case_Progress { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? Summary { get; set; }

    public bool TaskCreated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Confirmed_User_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Last_Confirmed_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateSummaryCreated { get; set; }

    public bool Summary_Confirmed { get; set; }
}
