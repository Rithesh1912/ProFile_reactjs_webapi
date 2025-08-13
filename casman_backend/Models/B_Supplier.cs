using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("B_Supplier")]
public partial class B_Supplier
{
    public long? ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BPSupplier { get; set; } = null!;

    public int? supplier_category { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? supplier { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BPRSHO { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? alpha { get; set; }

    public int BPAADD { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? currency { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CRN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NAF { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? vat_reg_number { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string VACBPR { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string PTE { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string ACCCOD { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TSSCOD0 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TSSCOD1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string PLISTC { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string MDL { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string EECICT { get; set; } = null!;

    public int OSTCTL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string OSTAUZAMT { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? BPSREM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Field71 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Field72 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Field81 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Field82 { get; set; } = null!;
}
