using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class Batch_Payment
{
    public int? Seq_No { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Case_ID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Sub_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Practitioner { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Payee_Type { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Requested_by { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Amount { get; set; }
}
