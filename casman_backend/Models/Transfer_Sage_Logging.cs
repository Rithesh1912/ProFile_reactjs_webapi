using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("Transfer_Sage_Logging")]
public partial class Transfer_Sage_Logging
{
    [Key]
    public long ID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? CASE_ID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SUB_ID { get; set; }

    public int? SEQUENCE_NO { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? User_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Execution_Date { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Message { get; set; }
}
