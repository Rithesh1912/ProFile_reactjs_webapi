using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class DOD_DestroyFile
{
    public int ID { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string CaseId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateDestroyed { get; set; }

    public bool? IsActioned { get; set; }

    [Unicode(false)]
    public string? ErrorMessage { get; set; }
}
