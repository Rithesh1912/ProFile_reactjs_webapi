using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Tbldisbursementtemp")]
public partial class Tbldisbursementtemp
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string sub_id { get; set; } = null!;

    public int sequence_no { get; set; }

    [Column("pc _data", TypeName = "datetime")]
    public DateTime? pc__data { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string pc_type { get; set; } = null!;

    public int Invoice_Id { get; set; }
}
