using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("paymt_status")]
public partial class paymt_status
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string status_code { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? status_desc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? valid { get; set; }
}
