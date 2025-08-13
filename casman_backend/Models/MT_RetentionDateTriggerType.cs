using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MT_RetentionDateTriggerType")]
public partial class MT_RetentionDateTriggerType
{
    [Key]
    public int ID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Field { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TableName { get; set; }
}
