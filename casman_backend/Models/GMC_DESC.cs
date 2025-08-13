using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("GMC_DESC")]
public partial class GMC_DESC
{
    [Key]
    [StringLength(25)]
    public string DESC_ID { get; set; } = null!;

    public string DESCRIPTION { get; set; } = null!;
}
