using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ri_app_det_a")]
public partial class ri_app_det_a
{
    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string org { get; set; } = null!;

    public short? percnt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? comments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? insert_update_delete { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }
}
