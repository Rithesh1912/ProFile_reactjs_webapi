using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TEMPRANKING")]
public partial class TEMPRANKING
{
    [StringLength(15)]
    [Unicode(false)]
    public string? EXPERTID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AVGRATING { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AVGTIME { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? REPYEAR { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? REPAWAITED { get; set; }

    public int? MILES { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? TARIFFID { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? ADULTSPCLTYDESC { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? PAEDSPCLTYDESC { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? DENTSPCLTYDESC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MILESSORTORDER { get; set; }
}
