using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class MduMemberDetail
{
    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? FORENAMES { get; set; }

    [StringLength(10)]
    public string? INITIALS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? GENDERCODE { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? URL { get; set; }

    public int? TITLECODE { get; set; }
}
