using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_Entity_Audit")]
public partial class MT_Entity_Audit
{
    public int? EID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? EntityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? CurrentLocation { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? HomeLocation { get; set; }

    public int? EntityType { get; set; }

    public int? RetentionSchedule { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RetentionAddedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RetentionTriggerDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DestructionReviewDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PurgeDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? MDUBoxID { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StaffMemberDesk { get; set; }
}
