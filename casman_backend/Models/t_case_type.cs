using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_case_type")]
public partial class t_case_type
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string case_type { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string type_desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
