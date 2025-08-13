using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class update
{
    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? case_stat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? statute_barred_dt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? selected { get; set; }
}
