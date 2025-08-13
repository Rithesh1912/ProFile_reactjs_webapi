using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblMeetingType")]
public partial class TblMeetingType
{
    [Key]
    public int Meeting_Type_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Meeting_Type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Valid { get; set; } = null!;
}
