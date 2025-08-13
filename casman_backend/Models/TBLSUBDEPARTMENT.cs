using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TBLSUBDEPARTMENT")]
public partial class TBLSUBDEPARTMENT
{
    [Key]
    [StringLength(3)]
    [Unicode(false)]
    public string Sub_Dept_ID { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Sub_Dept_Desc { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Valid { get; set; } = null!;

    [InverseProperty("Sub_Dept")]
    public virtual ICollection<TblAdvProgType> TblAdvProgTypes { get; set; } = new List<TblAdvProgType>();
}
