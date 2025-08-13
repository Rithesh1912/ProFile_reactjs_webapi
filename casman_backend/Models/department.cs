using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("department")]
public partial class department
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string dept_id { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? dept_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? depatAdAccount { get; set; }

    [InverseProperty("Parent_Dept")]
    public virtual ICollection<TBLSUBDEPARTMENT_MAPPING> TBLSUBDEPARTMENT_MAPPINGs { get; set; } = new List<TBLSUBDEPARTMENT_MAPPING>();
}
