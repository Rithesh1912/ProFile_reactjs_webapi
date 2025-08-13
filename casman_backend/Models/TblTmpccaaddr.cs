using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblTmpccaaddr")]
public partial class TblTmpccaaddr
{
    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    public int Seq_No { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string address1 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? address2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? address3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string city { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string postcode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string country { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string prefered { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? User_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
