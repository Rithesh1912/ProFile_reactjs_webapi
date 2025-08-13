using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("plinvm")]
public partial class plinvm
{
    [StringLength(6)]
    [Unicode(false)]
    public string batch { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string supplier { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string item { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string page_no { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string refernce { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? dated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? due_date { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string alpha { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string currency { get; set; } = null!;

    public double exchange_rate { get; set; }

    public double currency_amount { get; set; }

    public double local_amount { get; set; }

    public double vat_amount { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code01 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code02 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code03 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code04 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code05 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code06 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code07 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code08 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code09 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_code10 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc01 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc02 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc03 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc04 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc05 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc06 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc07 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc08 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc09 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string nominal_desc10 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode01 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode02 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode03 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode04 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode05 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode06 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode07 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode08 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode09 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string nominal_vatcode10 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code01 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code02 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code03 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code04 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code05 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code06 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code07 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code08 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code09 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_code10 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense01 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense02 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense03 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense04 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense05 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense06 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense07 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense08 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense09 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string job_expense10 { get; set; } = null!;

    public double currency_value01 { get; set; }

    public double currency_value02 { get; set; }

    public double currency_value03 { get; set; }

    public double currency_value04 { get; set; }

    public double currency_value05 { get; set; }

    public double currency_value06 { get; set; }

    public double currency_value07 { get; set; }

    public double currency_value08 { get; set; }

    public double currency_value09 { get; set; }

    public double currency_value10 { get; set; }

    public double local_value01 { get; set; }

    public double local_value02 { get; set; }

    public double local_value03 { get; set; }

    public double local_value04 { get; set; }

    public double local_value05 { get; set; }

    public double local_value06 { get; set; }

    public double local_value07 { get; set; }

    public double local_value08 { get; set; }

    public double local_value09 { get; set; }

    public double local_value10 { get; set; }

    public double settlement_dis { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sett_due_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string posting_ind { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string authoriser { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? auth_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string posting_sel { get; set; } = null!;

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

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind01 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind02 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind03 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind04 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind05 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind06 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind07 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind08 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind09 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string goods_vat_ind10 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes01 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes02 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes03 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes04 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes05 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes06 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes07 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes08 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes09 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string tax_codes10 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fixed_rate { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string currency_operator { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string currency_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string reg_batch { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string reg_status { get; set; } = null!;

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

    public double settlement_dis2 { get; set; }

    public double settlement_dis3 { get; set; }

    public double settlement_dis4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sett_due_date2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sett_due_date3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sett_due_date4 { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string control { get; set; } = null!;

    public int last_line_key { get; set; }

    public int line_key01 { get; set; }

    public int line_key02 { get; set; }

    public int line_key03 { get; set; }

    public int line_key04 { get; set; }

    public int line_key05 { get; set; }

    public int line_key06 { get; set; }

    public int line_key07 { get; set; }

    public int line_key08 { get; set; }

    public int line_key09 { get; set; }

    public int line_key10 { get; set; }

    public byte[] rowstamp { get; set; } = null!;

    [StringLength(1)]
    public string? X3_Upload { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? X3_Update { get; set; }
}
