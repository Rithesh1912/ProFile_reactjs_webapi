using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("PhysicalItem_Id", "case_id", "subsid_id")]
public partial class TblPhysicalItem
{
    [Key]
    public int PhysicalItem_Id { get; set; }

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? Batch_id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Physical_Type { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Current_Location { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CheckOut_Date { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Original_Copy { get; set; }

    public bool? Return { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Return_Date { get; set; }

    public bool? Copies_Retain { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Recieve_Date { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Store_Return { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Add_Name { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Add_Address1 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Add_Address2 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Add_Address3 { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Add_Address4 { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Add_PostCode { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Home_Location { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? PIPassword { get; set; }
}
