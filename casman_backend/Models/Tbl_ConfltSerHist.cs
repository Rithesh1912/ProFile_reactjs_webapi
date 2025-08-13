using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Tbl_ConfltSerHist")]
public partial class Tbl_ConfltSerHist
{
    public int Hist_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuditDateTime { get; set; }

    public string? SearchCont { get; set; }

    [StringLength(250)]
    public string? UserId { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? CaseId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SubId { get; set; }
}
