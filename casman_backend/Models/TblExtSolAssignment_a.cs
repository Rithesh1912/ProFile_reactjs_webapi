using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblExtSolAssignment_a")]
public partial class TblExtSolAssignment_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_Id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_Id { get; set; } = null!;

    public int Ext_Sol_Code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date_Inst { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? Reference { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Contact_Name { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Control_No { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? User_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date_Last_Updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    public bool? Fixed_Costs { get; set; }
}
