using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblTariff_Code")]
public partial class TblTariff_Code
{
    public int Tariff_code_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Tariff_code_Description { get; set; } = null!;
}
