using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("AssignTaskToIntrlSolicitor_AT")]
public partial class AssignTaskToIntrlSolicitor_AT
{
    public int? assign_id { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Operation { get; set; }

    public int? assign_seq_num { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Comments { get; set; }

    public bool? AssignTask { get; set; }

    public bool? Inst_Sol { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Last_UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Last_UpdatedDate { get; set; }
}
