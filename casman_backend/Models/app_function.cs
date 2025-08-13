using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("app_id", "function_id")]
[Table("app_function")]
public partial class app_function
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string app_id { get; set; } = null!;

    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string function_id { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? description { get; set; }
}
