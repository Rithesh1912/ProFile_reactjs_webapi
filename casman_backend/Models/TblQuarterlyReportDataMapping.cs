using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblQuarterlyReportDataMapping")]
public partial class TblQuarterlyReportDataMapping
{
    [Key]
    public int SDN_ID { get; set; }

    public string ReportDataMapDesc { get; set; } = null!;

    public int FDN_ID { get; set; }

    public int POSITION_ID { get; set; }

    [ForeignKey("FDN_ID")]
    [InverseProperty("TblQuarterlyReportDataMappings")]
    public virtual TblQuarterlyReportDatum FDN { get; set; } = null!;
}
