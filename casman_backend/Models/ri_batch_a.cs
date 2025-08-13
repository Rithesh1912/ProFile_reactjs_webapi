using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ri_batch_a")]
public partial class ri_batch_a
{
    public int batch_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? batch_date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? batch_user { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? batch_total { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? batch_ref { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? batch_status { get; set; }

    [Column(TypeName = "decimal(10, 5)")]
    public decimal? curr_rate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? payee_code { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? payee_name { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? batch_currency { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? payee_alpha { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? priority { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
