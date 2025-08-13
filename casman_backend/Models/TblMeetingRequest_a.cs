using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblMeetingRequest_a")]
public partial class TblMeetingRequest_a
{
    public int meeting_id { get; set; }

    public int? cca_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_inst { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_file_sent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_meeting { get; set; }

    public int? time_meeting { get; set; }

    public int meeting_type_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string arranged_by { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string? prac_num { get; set; }

    public bool meeting_status { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string address1 { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? address2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? address3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? town { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? county { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? postcode { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? on_behalf_of { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;

    [StringLength(2500)]
    [Unicode(false)]
    public string? comments { get; set; }

    public bool postponed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_created { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
