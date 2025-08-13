using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("tblCaseDocumentStatus")]
public partial class tblCaseDocumentStatus
{
    [StringLength(1)]
    [Unicode(false)]
    public string? Case_document_status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }
}
