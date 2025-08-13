using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TEMPCRCY")]
public partial class TEMPCRCY
{
    [StringLength(30)]
    [Unicode(false)]
    public string? CRCYDESC { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CRCYCODE { get; set; }
}
