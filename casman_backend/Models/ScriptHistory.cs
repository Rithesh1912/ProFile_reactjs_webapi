using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ScriptHistory")]
public partial class ScriptHistory
{
    public int ScriptRowNumber { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string ScriptName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ScriptVersion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ScriptRunStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScriptRunEndDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ScriptBy { get; set; } = null!;

    public bool? ScriptSuccessfulFlag { get; set; }

    public int? ERROR_NUMBER { get; set; }

    public int? ERROR_SEVERITY { get; set; }

    public int? ERROR_STATE { get; set; }

    public string? ERROR_PROCEDURE { get; set; }

    public int? ERROR_LINE { get; set; }

    public string? ERROR_MESSAGE { get; set; }
}
