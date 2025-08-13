using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblQuarterlyReportGMC")]
public partial class TblQuarterlyReportGMC
{
    [StringLength(7)]
    [Unicode(false)]
    public string CASE_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SUB_ID { get; set; } = null!;

    public int? IOT { get; set; }

    public int? IOT_OUTCOME { get; set; }

    public int? ATTENDENCE { get; set; }

    public int? CPS { get; set; }

    public int? STGOTCM { get; set; }

    [StringLength(100)]
    public string? User_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DATE_LAST_UPDATED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IOT_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DECISION_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FINAL_DATE { get; set; }
}
