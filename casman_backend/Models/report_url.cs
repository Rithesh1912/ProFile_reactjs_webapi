using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("report_url")]
public partial class report_url
{
    [Key]
    public int rpt_url_id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? rpt_path { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? rpt_file { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? rpt_url_desc { get; set; }
}
