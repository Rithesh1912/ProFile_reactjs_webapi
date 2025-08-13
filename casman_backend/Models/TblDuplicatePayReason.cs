using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblDuplicatePayReason")]
public partial class TblDuplicatePayReason
{
    public int PayReason_id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string PayReason_Desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string valid { get; set; } = null!;
}
