using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("CASE_ID", "SUBSID")]
[Table("tblFileStrategy")]
public partial class tblFileStrategy
{
    public int ID { get; set; }

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string CASE_ID { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SUBSID { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? USERID { get; set; }

    [Unicode(false)]
    public string? LIABILITY { get; set; }

    [Unicode(false)]
    public string? QUANTUM { get; set; }

    [Unicode(false)]
    public string? PROCEDURE { get; set; }

    [Unicode(false)]
    public string? Membership { get; set; }
}
