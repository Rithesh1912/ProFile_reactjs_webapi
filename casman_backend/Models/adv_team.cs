using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("adv_team")]
public partial class adv_team
{
    [Key]
    public long Team_Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Team { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Team_Name { get; set; }

    public bool? Valid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Dept_Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TeamADAccount { get; set; }
}
