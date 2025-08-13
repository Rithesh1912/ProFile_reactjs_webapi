using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("staff_a")]
public partial class staff_a
{
    [Column(TypeName = "datetime")]
    public DateTime audit_date_time { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string change_type { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string? staff_no { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string staff_id { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? staff_name { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? dept_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? sol_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? secretariat { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? office { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? adv_mgt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ren_retention { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? clms_mgt { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? division { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? job_title { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? staff_decor { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? team { get; set; }

    public long? TEAM_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? issol { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? auth_casescmte { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidToDate { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TaskAllocList { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Sub_Dept_ID { get; set; }

    public bool? IsTransGndrAllowed { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? modified_by { get; set; }

    public bool OutOfOfficeEmailAttachments { get; set; }
}
