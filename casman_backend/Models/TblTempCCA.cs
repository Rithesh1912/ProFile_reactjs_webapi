using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblTempCCA")]
public partial class TblTempCCA
{
    public int cca_id { get; set; }

    public int? contact_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? first_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? initial { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? last_name { get; set; }

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
    public string? city { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? postcode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? work_tel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? home_tel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mobile { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? fax { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? extn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? email { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [StringLength(2500)]
    [Unicode(false)]
    public string? notes { get; set; }
}
