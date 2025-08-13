using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblReleaseInfo")]
public partial class TblReleaseInfo
{
    [StringLength(500)]
    public string Comments { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Enable { get; set; } = null!;

    [StringLength(500)]
    public string LearnMoreLink { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string UpdatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime UpdatedDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Start_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? End_Date { get; set; }
}
