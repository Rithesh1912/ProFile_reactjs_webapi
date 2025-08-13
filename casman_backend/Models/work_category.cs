using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("work_category")]
public partial class work_category
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string work_cat_code { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string work_cat_desc { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string dept_id { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string billable { get; set; } = null!;
}
