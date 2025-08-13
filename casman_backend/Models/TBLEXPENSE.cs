using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TBLEXPENSE")]
public partial class TBLEXPENSE
{
    [StringLength(100)]
    [Unicode(false)]
    public string? ExpenseType { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Account_code_on_contra_entry { get; set; }
}
