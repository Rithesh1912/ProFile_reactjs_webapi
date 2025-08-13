using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_RetentionPeriod")]
public partial class MT_RetentionPeriod
{
    [Key]
    public int RetentionPeriodID { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string RetentionPeriod { get; set; } = null!;

    public int? RetentionPeriodTypeID { get; set; }

    [ForeignKey("RetentionPeriodTypeID")]
    [InverseProperty("MT_RetentionPeriods")]
    public virtual MT_RetentionPeriodType? RetentionPeriodType { get; set; }
}
