using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class IF_GETCASEDETAILS_VW
{
    public short? pracsource { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_Id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_Id { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? redact_case { get; set; }

    public short? redact_case_rule { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? case_uri { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? MDUNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string pt_lname { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? IncidentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NotificationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Liability { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Office { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Department { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Secretariat1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Secretariat2 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Speciality { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PracticeArea { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Fileclassification { get; set; }

    [StringLength(130)]
    [Unicode(false)]
    public string? Location { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Solicitor { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Summary { get; set; }
}
