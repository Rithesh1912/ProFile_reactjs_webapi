using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TBLWITNESS")]
public partial class TBLWITNESS
{
    [Key]
    public int WitnessId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Comment { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? Case_Id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Sub_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? LastModifiedBy { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? instructed_by { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? type { get; set; }
}
