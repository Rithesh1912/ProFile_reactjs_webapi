using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("ApprovedEmailList")]
[Index("Case_ID", "SubSid", "EmailAddress", Name = "PK_ApprovedEmailList", IsUnique = true)]
public partial class ApprovedEmailList
{
    [Key]
    public int Sno { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SubSid { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string EmailAddress { get; set; } = null!;

    public bool Approved { get; set; }

    public bool Disabled { get; set; }
}
