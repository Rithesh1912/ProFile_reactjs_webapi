using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_Classification")]
public partial class t_Classification
{
    public int ID { get; set; }

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Clfn_Code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Clfn_Description { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }
}
