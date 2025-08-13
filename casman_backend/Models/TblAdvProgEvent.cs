using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("Adv_Type_id", "Adv_Event_Id")]
[Table("TblAdvProgEvent")]
public partial class TblAdvProgEvent
{
    [Key]
    public int Adv_Type_id { get; set; }

    [Key]
    public int Adv_Event_Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Adv_Event_Desc { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Summary { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Keyword { get; set; }

    public bool Outcome { get; set; }

    public bool Review { get; set; }

    public bool Active { get; set; }

    public int? Adv_Dept_ID { get; set; }
}
