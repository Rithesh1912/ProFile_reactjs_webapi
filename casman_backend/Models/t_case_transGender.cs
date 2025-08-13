using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("t_case_transGender")]
public partial class t_case_transGender
{
    [Key]
    public int ID { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? caseID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SubsID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAdded { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateLastUpdated { get; set; }
}
