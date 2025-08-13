using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("ProfileUrlTimeout")]
public partial class ProfileUrlTimeout
{
    public long ID { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string URL { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timeout { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Datemodified { get; set; }
}
