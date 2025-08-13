using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TBLQUARTERLYREPORTCLAIMS")]
public partial class TBLQUARTERLYREPORTCLAIM
{
    [StringLength(7)]
    [Unicode(false)]
    public string CASE_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SUB_ID { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CLMS_DAMG_RSRV { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CLMS_COST_RSRV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CRNT_STUS_OVERVIEW { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CRNT_STUS_BRKDWN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? LAST_DATE_OF_SOLICITOR_REPORT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SETTLEMENT_MADE_BY_MDU_DDU { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string LAST_UPDATED_BY { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DATE_LAST_UPDATED { get; set; }
}
