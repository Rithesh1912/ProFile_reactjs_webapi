using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Tbl_Rsrv_HvrHistory")]
public partial class Tbl_Rsrv_HvrHistory
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_Id { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Sub_Id { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string User_Id { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? Html_Page { get; set; }
}
