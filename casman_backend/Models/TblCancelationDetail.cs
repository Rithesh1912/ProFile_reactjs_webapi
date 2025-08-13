using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class TblCancelationDetail
{
    public int Meeting_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Cancellation_date { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Cancellation_text { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Cancellation_reason { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string User_ID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date_last_updated { get; set; }
}
