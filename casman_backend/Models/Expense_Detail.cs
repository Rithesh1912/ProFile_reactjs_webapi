using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class Expense_Detail
{
    public int? Id { get; set; }

    [Unicode(false)]
    public string? Data { get; set; }
}
