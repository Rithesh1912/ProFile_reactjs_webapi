using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("nljrnm")]
public partial class nljrnm
{
    [StringLength(10)]
    [Unicode(false)]
    public string journal_no { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string slash { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string page_no { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? dated { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string narrative { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string hold_indicator { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string action_indicator { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string period_indicator { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string period_entered { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? expiry_date { get; set; }

    public double total_debits { get; set; }

    public double total_credits { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string no_of_lines { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string total_no_of_lines { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes01 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes02 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes03 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes04 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes05 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes06 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes07 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes08 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes09 { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string nominal_codes10 { get; set; } = null!;

    public double line_amounts01 { get; set; }

    public double line_amounts02 { get; set; }

    public double line_amounts03 { get; set; }

    public double line_amounts04 { get; set; }

    public double line_amounts05 { get; set; }

    public double line_amounts06 { get; set; }

    public double line_amounts07 { get; set; }

    public double line_amounts08 { get; set; }

    public double line_amounts09 { get; set; }

    public double line_amounts10 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes01 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes02 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes03 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes04 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes05 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes06 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes07 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes08 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes09 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string line_vatcodes10 { get; set; } = null!;

    public double line_vat_amts01 { get; set; }

    public double line_vat_amts02 { get; set; }

    public double line_vat_amts03 { get; set; }

    public double line_vat_amts04 { get; set; }

    public double line_vat_amts05 { get; set; }

    public double line_vat_amts06 { get; set; }

    public double line_vat_amts07 { get; set; }

    public double line_vat_amts08 { get; set; }

    public double line_vat_amts09 { get; set; }

    public double line_vat_amts10 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative01 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative02 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative03 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative04 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative05 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative06 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative07 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative08 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative09 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string line_narrative10 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string nlyear { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? transdate { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string source1 { get; set; } = null!;

    [StringLength(24)]
    [Unicode(false)]
    public string source2 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd01 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd02 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd03 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd04 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd05 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd06 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd07 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd08 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd09 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string rept_curr_cd10 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code01 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code02 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code03 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code04 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code05 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code06 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code07 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code08 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code09 { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string curr_code10 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type01 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type02 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type03 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type04 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type05 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type06 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type07 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type08 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type09 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string curr_type10 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind01 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind02 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind03 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind04 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind05 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind06 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind07 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind08 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind09 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string fix_rate_ind10 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq01 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq02 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq03 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq04 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq05 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq06 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq07 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq08 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq09 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string curr_freq10 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv01 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv02 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv03 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv04 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv05 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv06 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv07 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv08 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv09 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string multidiv10 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status01 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status02 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status03 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status04 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status05 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status06 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status07 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status08 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status09 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string revalue_status10 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis1 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis2 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string analysis3 { get; set; } = null!;

    public double trans_amount01 { get; set; }

    public double trans_amount02 { get; set; }

    public double trans_amount03 { get; set; }

    public double trans_amount04 { get; set; }

    public double trans_amount05 { get; set; }

    public double trans_amount06 { get; set; }

    public double trans_amount07 { get; set; }

    public double trans_amount08 { get; set; }

    public double trans_amount09 { get; set; }

    public double trans_amount10 { get; set; }

    public double report_amount01 { get; set; }

    public double report_amount02 { get; set; }

    public double report_amount03 { get; set; }

    public double report_amount04 { get; set; }

    public double report_amount05 { get; set; }

    public double report_amount06 { get; set; }

    public double report_amount07 { get; set; }

    public double report_amount08 { get; set; }

    public double report_amount09 { get; set; }

    public double report_amount10 { get; set; }

    public double exchange_rate01 { get; set; }

    public double exchange_rate02 { get; set; }

    public double exchange_rate03 { get; set; }

    public double exchange_rate04 { get; set; }

    public double exchange_rate05 { get; set; }

    public double exchange_rate06 { get; set; }

    public double exchange_rate07 { get; set; }

    public double exchange_rate08 { get; set; }

    public double exchange_rate09 { get; set; }

    public double exchange_rate10 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string interco_flag { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string transaction_group { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string group_journal { get; set; } = null!;

    public int journal_type { get; set; }

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

    public int Exp_Batch_Id { get; set; }
}
