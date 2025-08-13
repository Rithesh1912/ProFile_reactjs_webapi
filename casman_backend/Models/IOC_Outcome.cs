using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("IOC_Outcome")]
public partial class IOC_Outcome
{
    [Key]
    public int IOC_Outcome_Id { get; set; }

    public int IOC_Id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string IOC_Outcome_TYPE { get; set; } = null!;

    [ForeignKey("IOC_Id")]
    [InverseProperty("IOC_Outcomes")]
    public virtual GDC_IOC IOC { get; set; } = null!;
}
