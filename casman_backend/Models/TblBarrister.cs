using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblBarrister")]
public partial class TblBarrister
{
    [Key]
    public int Barrister_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Barrister_Cat { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    public int? Chambers_Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Contact { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Expertise { get; set; }

    public bool? Bar_Direct { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }
}
