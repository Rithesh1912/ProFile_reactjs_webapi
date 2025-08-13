using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblGroupType")]
public partial class TblGroupType
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string group_type { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? grp_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
