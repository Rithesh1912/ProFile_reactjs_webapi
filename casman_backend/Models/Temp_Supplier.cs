using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Temp_Supplier")]
public partial class Temp_Supplier
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

    [StringLength(1)]
    [Unicode(false)]
    public string BPAddress { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string BPAADD1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BPADES { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? BPAADDLIG0 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? BPAADDLIG1 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? BPAADDLIG2 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? Postcode { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? CTY { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string CRY { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? TEL0 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fax { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Email1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string CRY1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BIDNum { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BIDNumFlag { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string PAB1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BICCODE { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BNF { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Contact { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CCNCRM { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CNTTL { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CNTFNA { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CNTLNA { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TEL { get; set; } = null!;
}
