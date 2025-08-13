using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("StageofInvestication")]
public partial class StageofInvestication
{
    [Key]
    public int Investication_Id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Investication_TYPE { get; set; } = null!;

    [InverseProperty("Investication")]
    public virtual ICollection<GDCDecision> GDCDecisions { get; set; } = new List<GDCDecision>();
}
