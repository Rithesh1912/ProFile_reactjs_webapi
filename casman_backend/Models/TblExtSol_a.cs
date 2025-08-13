using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblExtSol_a")]
public partial class TblExtSol_a
{
    public int Ext_Sol_Code { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Sol_Name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? PAYEE_CODE { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? PAYEE_NAME { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
