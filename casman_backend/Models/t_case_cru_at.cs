using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_case_cru_at")]
public partial class t_case_cru_at
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? date_to_claimant { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_cru4_reqd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_statement_req { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_expires { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? cru_amount { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? cru_final_amount { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? cru_status { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? cru_comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    public bool? Rec_of_NHS_Charges { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Rec_of_NHS_Charges_Amt { get; set; }
}
