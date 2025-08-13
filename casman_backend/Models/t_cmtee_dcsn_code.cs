using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class t_cmtee_dcsn_code
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string cmtee_dcsn { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string? dcsn_desc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? full_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? quantum_allowed { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? check_cru { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
