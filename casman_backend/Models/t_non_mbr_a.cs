using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_non_mbr_a")]
public partial class t_non_mbr_a
{
    [StringLength(2)]
    [Unicode(false)]
    public string def_org { get; set; } = null!;

    [StringLength(7)]
    [Unicode(false)]
    public string gmc_num { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? intls { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? last_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? first_name { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? nee { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? addr_1 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? addr_2 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? addr_3 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? addr_4 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? addr_post_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sex { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? spclty { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? nmbr_tow { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime last_updated_date { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
