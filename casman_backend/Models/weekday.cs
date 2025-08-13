using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("weekday")]
public partial class weekday
{
    [Key]
    public short week_day { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string day_name { get; set; } = null!;
}
