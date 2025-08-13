using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class CMS_Message
{
    [StringLength(6)]
    [Unicode(false)]
    public string MessageID { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? Message { get; set; }

    public int KEYNO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MessageType { get; set; }
}
