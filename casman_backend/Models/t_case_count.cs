using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_case_count")]
public partial class t_case_count
{
    [StringLength(2)]
    [Unicode(false)]
    public string? office { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_created { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? user_id { get; set; }
}
