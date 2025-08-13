using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("tblFileStrategyHistory")]
public partial class tblFileStrategyHistory
{
    [Key]
    public int id { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subSid { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? userId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? dateLastUpdated { get; set; }

    [Unicode(false)]
    public string? liability { get; set; }

    [Unicode(false)]
    public string? quantum { get; set; }

    [Unicode(false)]
    public string? procedure { get; set; }

    [Unicode(false)]
    public string? Membership { get; set; }
}
