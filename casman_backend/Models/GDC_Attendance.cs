using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("GDC_Attendance")]
public partial class GDC_Attendance
{
    [Key]
    public int Attendance_Id { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string Attendance_TYPE { get; set; } = null!;
}
