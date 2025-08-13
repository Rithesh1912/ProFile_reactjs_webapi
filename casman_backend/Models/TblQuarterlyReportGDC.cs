using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblQuarterlyReportGDC")]
public partial class TblQuarterlyReportGDC
{
    [StringLength(7)]
    [Unicode(false)]
    public string CASE_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SUB_ID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string IOC { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string IOCOUTCOME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ATTENDANCE { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? IOC_ROP_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CASENOWCONCLUDED { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string STAGEOFINVESTIGATION { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DECISION { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DECISION_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FINAL_OUTCOME_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LAST_UPDATED_BY { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DATE_LAST_UPDATED { get; set; }
}
