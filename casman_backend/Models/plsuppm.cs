using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("plsuppm")]
public partial class plsuppm
{
    [StringLength(8)]
    [Unicode(false)]
    public string supplier { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string alpha { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string address1 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string address2 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string address3 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string address4 { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string address5 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string letter_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string pay_indicator { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string pay_terms { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string pay_type { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string bank_account { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string bank_code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string bank_name { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string bank_branch { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? date_last_sale { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_created { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes1 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes2 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string balance_fwd_ind { get; set; } = null!;

    public double ytd_sales { get; set; }

    public double cumulative_sales { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string payment_reference { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes_21 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes_22 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis_codes_23 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string vat_type { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string vat_reg_number { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string address6 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string fax { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string telex { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string btx { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string price_list { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string special_price_list { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string pop_discount_cat { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string spare { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string supplier_category { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string edi_supplier { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string account_type { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string sett_category { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string cit_supplier { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string iban { get; set; } = null!;

    [StringLength(11)]
    [Unicode(false)]
    public string bic { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string email { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string transaction_email { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string tol_check { get; set; } = null!;

    public byte[] rowstamp { get; set; } = null!;
}
