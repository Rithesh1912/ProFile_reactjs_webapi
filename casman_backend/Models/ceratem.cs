using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ceratem")]
public partial class ceratem
{
    [StringLength(3)]
    [Unicode(false)]
    public string currency_base { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string currency_year { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency_code { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string currency_type { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string spot_date { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string period { get; set; } = null!;

    public double exchange_rate { get; set; }

    public byte[] rowstamp { get; set; } = null!;
}
