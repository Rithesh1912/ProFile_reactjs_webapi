using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblDDRCoverType")]
public partial class TblDDRCoverType
{
    [StringLength(3)]
    [Unicode(false)]
    public string? Cover_type { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CoverDescription { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Valid { get; set; }
}
