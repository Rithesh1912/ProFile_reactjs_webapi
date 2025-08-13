using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("AssignTaskToIntrlSolicitor")]
public partial class AssignTaskToIntrlSolicitor
{
    [Key]
    public int assign_id { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    public int assign_seq_num { get; set; }

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
