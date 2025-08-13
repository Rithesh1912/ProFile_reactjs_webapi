using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblExpertContact_a")]
public partial class TblExpertContact_a
{
    [StringLength(20)]
    [Unicode(false)]
    public string Expert_id { get; set; } = null!;

    public int Exp_Cont_id { get; set; }

    public int Exp_Cont_type_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Contact_Dtls { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;
}
