using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("GDCDecision")]
public partial class GDCDecision
{
    [Key]
    public int Decision_Id { get; set; }

    public int Investication_Id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Decision_TYPE { get; set; } = null!;

    [ForeignKey("Investication_Id")]
    [InverseProperty("GDCDecisions")]
    public virtual StageofInvestication Investication { get; set; } = null!;
}
