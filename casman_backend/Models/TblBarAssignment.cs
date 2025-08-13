using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblBarAssignment")]
public partial class TblBarAssignment
{
    public int? Barrister_ID { get; set; }

    public int? Chambers_ID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_Id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_Id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Date_Inst { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Actions { get; set; }

    [StringLength(2500)]
    [Unicode(false)]
    public string? Comments { get; set; }

    public bool? Bar_Direct { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
