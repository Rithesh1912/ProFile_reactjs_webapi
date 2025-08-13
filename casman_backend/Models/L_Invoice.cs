using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class L_Invoice
{
    public long? ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BPSinVlig_L { get; set; } = null!;

    public int LIG { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string FcyLin { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string COA0 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA6 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA7 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA8 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string COA9 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string SAC { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc0 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc3 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc4 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc5 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc6 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc7 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc8 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Acc9 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BPRLIN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DSP { get; set; } = null!;

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

    [StringLength(1)]
    [Unicode(false)]
    public string Qty { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Vat { get; set; } = null!;
}
