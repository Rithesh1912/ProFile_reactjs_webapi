using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblTemplateForCase_Audit")]
public partial class TblTemplateForCase_Audit
{
    [Column(TypeName = "datetime")]
    public DateTime AuditDateTime { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string AuditAction { get; set; } = null!;

    public int TemplateID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [Column(TypeName = "xml")]
    public string? caseIndexTemplate { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? lockHolder { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lockStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? lockExpires { get; set; }

    public bool? isReplaced { get; set; }

    [Column(TypeName = "xml")]
    public string? newCaseIndexTemplate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Department { get; set; }
}
