using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class TblChamber
{
    [Key]
    public int Chambers_Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Chambers_Desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }
}
