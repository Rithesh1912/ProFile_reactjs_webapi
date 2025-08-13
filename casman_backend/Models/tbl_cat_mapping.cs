using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("tbl_cat_mapping")]
public partial class tbl_cat_mapping
{
    [Key]
    public int MappingId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? categoryCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? specialityCode { get; set; }
}
