using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("cencurm")]
public partial class cencurm
{
    [StringLength(3)]
    [Unicode(false)]
    public string currency_base { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string currency_year { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency_code { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string currency_type { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string currency_desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string conv_operator { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string type_desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string frequency { get; set; } = null!;

    public int decplaces { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string cheque_lang { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string round_acct { get; set; } = null!;

    public double tolerance { get; set; }

    public byte[] rowstamp { get; set; } = null!;
}
