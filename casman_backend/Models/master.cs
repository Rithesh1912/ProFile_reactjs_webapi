using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("master")]
public partial class master
{
    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string role { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string function_id { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string level { get; set; } = null!;
}
