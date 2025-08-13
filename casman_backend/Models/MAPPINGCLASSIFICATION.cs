using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("MAPPINGCLASSIFICATION")]
public partial class MAPPINGCLASSIFICATION
{
    [Key]
    public int ID { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Splty_Code { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? Clfn_Code { get; set; }
}
