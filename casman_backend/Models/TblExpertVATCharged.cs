using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("TblExpertVATCharged")]
public partial class TblExpertVATCharged
{
    [Key]
    public int VATID { get; set; }

    public string VATDesc { get; set; } = null!;
}
