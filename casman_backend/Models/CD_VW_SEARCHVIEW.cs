using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class CD_VW_SEARCHVIEW
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_Id { get; set; } = null!;

    [StringLength(56)]
    [Unicode(false)]
    public string Prac_Name { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Case_Handler1 { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Case_Handler2 { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string Case_Handler3 { get; set; } = null!;

    [StringLength(56)]
    [Unicode(false)]
    public string Pt_Name { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string Pt_Init { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Pt_Dob { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Speciality1 { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Speciality2 { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Incdt_Date { get; set; }
}
