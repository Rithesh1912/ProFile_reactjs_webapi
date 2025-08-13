using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_file_classification")]
public partial class t_file_classification
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string file_class_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? class_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
