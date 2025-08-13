using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblAdvProgType")]
public partial class TblAdvProgType
{
    [Key]
    public int Adv_Type_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Adv_Type_Desc { get; set; } = null!;

    public bool Active { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Sub_Dept_ID { get; set; } = null!;

    [ForeignKey("Sub_Dept_ID")]
    [InverseProperty("TblAdvProgTypes")]
    public virtual TBLSUBDEPARTMENT Sub_Dept { get; set; } = null!;
}
