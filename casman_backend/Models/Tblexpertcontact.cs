using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[PrimaryKey("Expert_id", "Exp_Cont_id")]
[Table("Tblexpertcontact")]
public partial class Tblexpertcontact
{
    [Key]
    public int Expert_id { get; set; }

    [Key]
    public int Exp_Cont_id { get; set; }

    public int Exp_Cont_type_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Contact_Dtls { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }
}
