using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_productType")]
public partial class t_productType
{
    [Key]
    public int id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? prodTypeCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? prodTypeName { get; set; }
}
