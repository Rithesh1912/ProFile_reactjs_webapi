using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_RetentionPeriodType")]
public partial class MT_RetentionPeriodType
{
    [Key]
    public int RetentionPeriodTypeID { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string RetentionPeriodType { get; set; } = null!;

    [InverseProperty("RetentionPeriodType")]
    public virtual ICollection<MT_RetentionPeriod> MT_RetentionPeriods { get; set; } = new List<MT_RetentionPeriod>();
}
