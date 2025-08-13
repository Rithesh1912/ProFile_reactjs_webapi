using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("basiscase_list_at")]
public partial class basiscase_list_at
{
    [StringLength(8)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? staff_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime insertdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? updatetype { get; set; }
}
