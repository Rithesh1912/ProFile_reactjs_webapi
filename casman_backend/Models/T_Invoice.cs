using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class T_Invoice
{
    public long? ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string PInvoice_T { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string PIVTyp { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Num { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string BPR { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string CPY { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string FCY { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DES { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string? BPRDat { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? BPRVCR { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? AccDat { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? cur { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CurTyp { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string RatMlt { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string? RatDat { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string BPRPay { get; set; } = null!;

    [StringLength(8000)]
    [Unicode(false)]
    public string? StrDudDat { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PTE { get; set; }

    public int Paz { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Vac { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string YcaseId { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Yprofinref { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Yledprac { get; set; } = null!;
}
