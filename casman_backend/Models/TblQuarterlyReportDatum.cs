using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class TblQuarterlyReportDatum
{
    [Key]
    public int FDN_ID { get; set; }

    public string ReportDataDesc { get; set; } = null!;

    public int Type_ID { get; set; }

    public int DESC_ID { get; set; }

    public int POSITION_ID { get; set; }

    [ForeignKey("DESC_ID")]
    [InverseProperty("TblQuarterlyReportData")]
    public virtual TblLegalReportDatum DESC { get; set; } = null!;

    [InverseProperty("FDN")]
    public virtual ICollection<TblQuarterlyReportDataMapping> TblQuarterlyReportDataMappings { get; set; } = new List<TblQuarterlyReportDataMapping>();
}
