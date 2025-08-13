using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class IF_GETCASEDETAILS_Kofax_VW
{
    [StringLength(30)]
    [Unicode(false)]
    public string? staff_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? team { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? prac_num { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? prac_last_name { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? prac_init { get; set; }

    [StringLength(6729)]
    [Unicode(false)]
    public string? CaseDescription { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? staff_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string RedactionRequired { get; set; } = null!;

    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string FullCaseID { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? Shared { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Department { get; set; }

    [StringLength(41)]
    [Unicode(false)]
    public string? Secretariat1 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Secretariat1Department { get; set; }

    [StringLength(41)]
    [Unicode(false)]
    public string? Secretariat2 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Secretariat2Department { get; set; }

    [StringLength(41)]
    [Unicode(false)]
    public string? Secretariat3 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Secretariat3Department { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Patient_Surname { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Patient_Initials { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Patient_Sex { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Patient_Deceased { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? patient_informed { get; set; }
}
