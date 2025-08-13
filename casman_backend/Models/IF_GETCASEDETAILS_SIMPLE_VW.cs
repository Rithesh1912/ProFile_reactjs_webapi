using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class IF_GETCASEDETAILS_SIMPLE_VW
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? redact_case { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? case_uri { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string Case_Id_SubId { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? prac_last_name { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? prac_first_name { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? scrt_usr { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? second_scrt_usr { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? third_scrt_usr { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? scrt_usr_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? second_scrt_usr_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? third_scrt_usr_id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? scrt_usr_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? second_scrt_usr_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? third_scrt_usr_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? scrt_usr_team { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? second_scrt_usr_team { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? third_scrt_usr_team { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? scrt_usr_dept { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? second_scrt_usr_dept { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? third_scrt_usr_dept { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? case_dept { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? shared_case { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? case_stat { get; set; }
}
