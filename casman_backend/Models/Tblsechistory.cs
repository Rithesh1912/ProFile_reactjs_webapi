using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Tblsechistory")]
public partial class Tblsechistory
{
    [StringLength(8)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? oldsec1 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? newsec1 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? oldsec2 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? newsec2 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? oldsec3 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? newsec3 { get; set; }
}
