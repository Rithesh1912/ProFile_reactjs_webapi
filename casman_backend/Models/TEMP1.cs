using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TEMP1")]
public partial class TEMP1
{
    [StringLength(7)]
    [Unicode(false)]
    public string? CASE_ID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SUBSID_ID { get; set; }
}
