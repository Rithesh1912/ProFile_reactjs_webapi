using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("MT_RetentionDateTriggerType_Audit")]
public partial class MT_RetentionDateTriggerType_Audit
{
    public int? ID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("event")]
    [StringLength(250)]
    [Unicode(false)]
    public string? _event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TableName { get; set; }
}
