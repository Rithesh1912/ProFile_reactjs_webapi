using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("TemplateID", "case_id", "subsid_id", "Department")]
[Table("TblTemplateForCase")]
public partial class TblTemplateForCase
{
    [Key]
    public int TemplateID { get; set; }

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

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

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Department { get; set; } = null!;
}
