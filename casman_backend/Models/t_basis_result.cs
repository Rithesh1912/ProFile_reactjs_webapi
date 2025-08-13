using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class t_basis_result
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid { get; set; } = null!;

    public int? ROWNO { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string owner { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? scrt_name { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? case_type { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? case_stat { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? spclty_maj_desc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? incdt_date { get; set; }

    public short? YearOfCase { get; set; }
}
