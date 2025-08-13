using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblDiscretionaryReason")]
public partial class TblDiscretionaryReason
{
    public int DiscReason_id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string DiscReason_Desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
