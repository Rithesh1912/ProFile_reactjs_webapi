using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblBenefitHistory")]
public partial class TblBenefitHistory
{
    [Key]
    public int History_id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_time_updated { get; set; }

    [Column(TypeName = "text")]
    public string? content_String { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? caseId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? subId { get; set; }
}
