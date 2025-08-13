using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TEMPTBLRESULTKEY")]
public partial class TEMPTBLRESULTKEY
{
    [StringLength(8)]
    [Unicode(false)]
    public string? STAFF_NO { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? CASE_ID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SUBSID_ID { get; set; }
}
