using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("plitemm")]
public partial class plitemm
{
    [StringLength(8)]
    [Unicode(false)]
    public string supplier { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string item { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string refernce { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? dated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? due_date { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string kind { get; set; } = null!;

    public double local_amount { get; set; }

    public double currency_amount { get; set; }

    public double unall_amount { get; set; }

    public double unall_curr_amt { get; set; }

    public double discount { get; set; }

    public double vat_amount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string open_indicator { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string hold_indicator { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? disc_sett_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string authorisor { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? auth_date { get; set; }

    [StringLength(49)]
    [Unicode(false)]
    public string spare { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes1 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes2 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes3 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string username { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? userdate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string usertime { get; set; } = null!;

    public double retention_amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string our_reference { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string supplier_and_date { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string registered { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string transaction_group { get; set; } = null!;

    public double orig_base_value { get; set; }

    public double current_rate { get; set; }

    public double original_rate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string fixed_rate { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string currency_operator { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string currency_type { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string short_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? effective_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string period { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string plyear { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string sett_category { get; set; } = null!;

    public double discount2 { get; set; }

    public double discount3 { get; set; }

    public double discount4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? disc_sett_date2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? disc_sett_date3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? disc_sett_date4 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string control { get; set; } = null!;

    public byte[] rowstamp { get; set; } = null!;
}
