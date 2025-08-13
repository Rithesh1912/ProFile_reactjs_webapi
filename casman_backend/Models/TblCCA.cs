using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblCCA")]
public partial class TblCCA
{
    [Key]
    public int cca_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string first_name { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? initial { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string last_name { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? address1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? address2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? address3 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? country { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string city { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string postcode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? work_tel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? home_tel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TELEPHONE1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TELEPHONE2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mobile { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? fax { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? extn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? email { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;

    [StringLength(2500)]
    [Unicode(false)]
    public string? notes { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
