using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("GDC_IOC")]
public partial class GDC_IOC
{
    [Key]
    public int IOC_Id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string IOC_TYPE { get; set; } = null!;

    [InverseProperty("IOC")]
    public virtual ICollection<IOC_Outcome> IOC_Outcomes { get; set; } = new List<IOC_Outcome>();
}
