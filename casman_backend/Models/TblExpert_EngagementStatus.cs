using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblExpert_EngagementStatus")]
public partial class TblExpert_EngagementStatus
{
    [Key]
    public int Engagement_Id { get; set; }

    public string? Engagement_Desc { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? MessageId { get; set; }

    public bool Show_Contract { get; set; }

    [StringLength(500)]
    public string? Tooltip_Desc { get; set; }

    public bool Valid { get; set; }
}
