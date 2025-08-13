using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Tbltempinvoice")]
public partial class Tbltempinvoice
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? forward_to { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address1 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address2 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address3 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address4 { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? address5 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? postcode { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? staff_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public int DupPayReason_id { get; set; }
}
