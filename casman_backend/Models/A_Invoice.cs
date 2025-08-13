using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class A_Invoice
{
    public long? ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BPSinvLic_A { get; set; } = null!;

    public int AnaLig { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Die { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Die1 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Die2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die6 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die7 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die8 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Die9 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? CCE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? CCE1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CCE2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CCE3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCE4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCE5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCE6 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCE7 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCE8 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCE9 { get; set; } = null!;

    public double AMT_1 { get; set; }

    public double AMT_2 { get; set; }

    public double AMT_3 { get; set; }

    public double AMT_4 { get; set; }

    public double AMT_5 { get; set; }

    public double AMT_6 { get; set; }

    public double AMT_7 { get; set; }

    public double AMT_8 { get; set; }

    public double AMT_9 { get; set; }

    public double AMT_10 { get; set; }
}
