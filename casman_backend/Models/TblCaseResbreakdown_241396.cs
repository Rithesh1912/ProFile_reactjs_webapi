using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblCaseResbreakdown_241396")]
public partial class TblCaseResbreakdown_241396
{
    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Probability { get; set; }
}
