using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("Report_ID", "Expert_id")]
[Table("TblExpertReport")]
public partial class TblExpertReport
{
    [Key]
    public int Report_ID { get; set; }

    [Key]
    public int Expert_id { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? Prac_num { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string Case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? Subsid_id { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Case_Handler { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date_Inst { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date_Rcvd { get; set; }

    public int? Rating { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Instruction_type { get; set; }

    public int? Findings_id { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Comments { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? User_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Accepted_tariff { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Instruction_type2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Instruction_type3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PSC_ContSent { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PSC_ContSign { get; set; }
}
