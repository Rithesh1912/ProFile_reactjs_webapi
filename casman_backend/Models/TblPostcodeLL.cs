using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblPostcodeLL")]
public partial class TblPostcodeLL
{
    [StringLength(2)]
    [Unicode(false)]
    public string Postcode { get; set; } = null!;

    public double Longitude { get; set; }

    public double Latitude { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Area { get; set; } = null!;
}
