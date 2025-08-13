using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class global_datum
{
    public short next_bom_month { get; set; }

    public short next_bom_year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime last_fin_year_end { get; set; }

    [Column(TypeName = "money")]
    public decimal minimum_bank_loan { get; set; }

    public short rate_year { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string new_std_letters { get; set; } = null!;

    public short erasure_period { get; set; }

    public short start_erasure_per { get; set; }

    public short batch_number { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string system_country { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string mdu_address_1 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string mdu_address_2 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string mdu_address_3 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string mdu_address_4 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string mdu_address_5 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string mem_nominal_code { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string chief_exec { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string membership_vatc { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string bank_code { get; set; } = null!;

    public short max_renewal_years { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? election_st_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? election_ed_date { get; set; }

    public short? election_tg_tm { get; set; }

    [Column(TypeName = "money")]
    public decimal gs_min_debit_adj { get; set; }

    [Column(TypeName = "money")]
    public decimal gs_min_credit_adj { get; set; }

    [Column(TypeName = "decimal(16, 4)")]
    public decimal? pc_monthly_rate { get; set; }

    [Column(TypeName = "decimal(16, 4)")]
    public decimal? pc_apr_rate { get; set; }

    public short? renew_offset { get; set; }

    public short? cm_erasure_period { get; set; }

    public short? erp_quote_exp_pd { get; set; }

    public short? contrib_yr_rnd_pd { get; set; }

    public short? max_res { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? payment_batch { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? max_reserve { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? high_reserve { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? max_nom_reserve { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? high_gross_reserve { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? reins_threshold { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sch_earliest_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sch_latest_start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sch_day_boundary { get; set; }

    public short? dd_elapse { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? master_policy_no { get; set; }

    public int? payee_persist { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? expsetdate_reins { get; set; }

    public int? solctrl_no { get; set; }

    public short? mduexp_batch { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal VAT_Percentage { get; set; }
}
