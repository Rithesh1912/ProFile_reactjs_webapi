using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("DOC_ScreenSplitterPanelValue")]
public partial class DOC_ScreenSplitterPanelValue
{
    [Key]
    public int Keyno { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string PanelDetails { get; set; } = null!;

    public int PanelValue { get; set; }

    public bool Valid { get; set; }
}
