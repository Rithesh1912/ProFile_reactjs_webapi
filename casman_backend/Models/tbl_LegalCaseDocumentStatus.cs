using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("tbl_LegalCaseDocumentStatus")]
public partial class tbl_LegalCaseDocumentStatus
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Legal_Case_Document_Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }
}
