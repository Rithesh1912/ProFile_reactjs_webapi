using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("A_Supplier")]
public partial class A_Supplier
{
    public long? ID { get; set; }

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
}
