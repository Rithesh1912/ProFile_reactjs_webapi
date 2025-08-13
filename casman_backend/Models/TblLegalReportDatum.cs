using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

public partial class TblLegalReportDatum
{
    [Key]
    public int DESC_ID { get; set; }

    [StringLength(75)]
    public string DESCRIPTION { get; set; } = null!;

    public int Type_ID { get; set; }

    public string TYPE { get; set; } = null!;

    [InverseProperty("DESC")]
    public virtual ICollection<TblQuarterlyReportDatum> TblQuarterlyReportData { get; set; } = new List<TblQuarterlyReportDatum>();
}
