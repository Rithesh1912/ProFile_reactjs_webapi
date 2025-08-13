using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("Sub_Dept_ID", "Parent_Dept_ID")]
[Table("TBLSUBDEPARTMENT_MAPPING")]
public partial class TBLSUBDEPARTMENT_MAPPING
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Sub_Dept_ID { get; set; } = null!;

    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Parent_Dept_ID { get; set; } = null!;

    [ForeignKey("Parent_Dept_ID")]
    [InverseProperty("TBLSUBDEPARTMENT_MAPPINGs")]
    public virtual department Parent_Dept { get; set; } = null!;
}
