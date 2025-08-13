using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class ri_pay_type
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string pay_codes { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? pay_desc { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? pay_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ind_lgl { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? quantum_reqd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Department { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? pay_type_2 { get; set; }
}
