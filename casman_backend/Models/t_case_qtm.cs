using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("case_id", "subsid_id")]
[Table("t_case_qtm")]
public partial class t_case_qtm
{
    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? gross_quantum { get; set; }

    public short? mdu_apptmt { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? net_quantum { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
