using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("sysdirm")]
public partial class sysdirm
{
    [StringLength(10)]
    [Unicode(false)]
    public string system_key { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string key_value { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string description { get; set; } = null!;

    public byte[] rowstamp { get; set; } = null!;
}
