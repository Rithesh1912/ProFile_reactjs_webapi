using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class IF_GETSTAFFDETAILS_VW
{
    [StringLength(8)]
    [Unicode(false)]
    public string staff_no { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string staff_name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? dept_name { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TeamADAccount { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DepatAdAccount { get; set; }
}
