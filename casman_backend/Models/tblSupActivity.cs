using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("tblSupActivity")]
public partial class tblSupActivity
{
    [StringLength(3)]
    [Unicode(false)]
    public string activity { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string activity_desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string dept_id { get; set; } = null!;
}
