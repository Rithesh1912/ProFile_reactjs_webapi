using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("res_hist_net")]
public partial class res_hist_net
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? net_settle_val { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? net_plaintiff_val { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? settle_reason { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;
}
