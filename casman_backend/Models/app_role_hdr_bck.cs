using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("app_role_hdr_bck")]
public partial class app_role_hdr_bck
{
    [StringLength(8)]
    [Unicode(false)]
    public string role { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string role_desc { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? department_id { get; set; }
}
