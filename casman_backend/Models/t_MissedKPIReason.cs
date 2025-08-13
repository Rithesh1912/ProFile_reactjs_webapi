using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class t_MissedKPIReason
{
    [Key]
    public int MissedKPI_Id { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? MissedKPI_Code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MissedKPI_Reason { get; set; }
}
