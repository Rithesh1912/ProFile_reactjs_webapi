using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_RetentionSchedule")]
public partial class MT_RetentionSchedule
{
    public int RSID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? RetentionScheduleName { get; set; }

    public int? RetentionDateTriggerTypeID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NoOfYears { get; set; }

    public bool? Active { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Comments { get; set; }
}
