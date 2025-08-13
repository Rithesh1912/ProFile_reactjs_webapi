using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id", "pt_number")]
[Table("t_pt_info")]
public partial class t_pt_info
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Key]
    public short pt_number { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? pt_lname { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? pt_fname { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pt_title { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? pt_init { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pt_sex { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? pt_nino { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? pt_dob { get; set; }

    public short? pt_age_inc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_sol { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_addr_1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_addr_2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_addr_3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_addr_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_addr_5 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? pt_addr_post_code { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_sol_addr_1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_sol_addr_2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_sol_addr_3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_sol_addr_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pt_sol_addr_5 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? pt_sol_post_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pt_incomplete { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pt_deceased { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public short lock_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? patient_informed { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pt_lname_init { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Problem { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sanction { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Sanction_Date { get; set; }
}
