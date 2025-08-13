using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class E_Invoice
{
    public long? ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string GACCDUD_E { get; set; } = null!;

    public int DudLig { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? DudDat { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PAM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string PAMTYP { get; set; } = null!;

    public double SAmt_1 { get; set; }

    public double SAmt_2 { get; set; }

    public double SAmt_3 { get; set; }

    public double SAmt_4 { get; set; }

    public double SAmt_5 { get; set; }

    public double SAmt_6 { get; set; }

    public double SAmt_7 { get; set; }

    public double SAmt_8 { get; set; }

    public double SAmt_9 { get; set; }

    public double SAmt_10 { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string BPAPAY { get; set; } = null!;

    public int FLGPAZ { get; set; }
}
