using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MDUC_Footer")]
public partial class MDUC_Footer
{
    [Key]
    public int ID { get; set; }

    public string? HTMLContent { get; set; }
}
