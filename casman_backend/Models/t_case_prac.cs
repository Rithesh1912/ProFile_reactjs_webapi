using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id", "prac_seq_num")]
[Table("t_case_prac")]
public partial class t_case_prac
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string? prac_num { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? prac_role { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? prac_def_org { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? prac_last_name { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? prac_first_name { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? prac_init { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? prac_sex { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? prac_tow { get; set; }

    public short? prac_invl { get; set; }

    [Key]
    public short prac_seq_num { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_involved { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_notified { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_claim_made { get; set; }

    public short? prac_source { get; set; }

    public short? cover_type { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public short lock_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DDRApplicable { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? DDRCoverType { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CharmPolicyNumber { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? CharmPolicyVersion { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? group_type { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? group_num { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? orgname { get; set; }

    public short Disc_Reason { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Member_Entitled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_nonirish_claim_made { get; set; }

    [StringLength(50)]
    public string? ProdRefNo_SubSegCode { get; set; }

    [StringLength(50)]
    public string? DON_Polselection { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Member_Entitled_DateModified { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PrivateGPClaims { get; set; } = null!;
}
