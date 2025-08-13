using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("Cca_id", "Addr_id")]
[Table("TblCCAaddr")]
public partial class TblCCAaddr
{
    [Key]
    public int Cca_id { get; set; }

    [Key]
    public int Addr_id { get; set; }

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

    [StringLength(50)]
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
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
