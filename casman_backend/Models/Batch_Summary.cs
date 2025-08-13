using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("Batch_Summary")]
public partial class Batch_Summary
{
    public int? Batch_ID { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Batch_Date { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? Payee_Name { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Batch_Currency { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Batch_Total { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Batch_Ref { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Staff_Name { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Status_Desc { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Curr_Rate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Payee_Code { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Priority_Desc { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Batch_User { get; set; }
}
