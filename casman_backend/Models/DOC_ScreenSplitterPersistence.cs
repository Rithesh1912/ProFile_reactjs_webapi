using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Table("DOC_ScreenSplitterPersistence")]
public partial class DOC_ScreenSplitterPersistence
{
    [Key]
    public long Keyno { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string Staff_Id { get; set; } = null!;

    public int PANELSETUP { get; set; }

    public bool LeftToggleModeOn { get; set; }

    public bool RightToggleModeOn { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal LEFTPANELSIZE_PERCENTAGE { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal RIGHTPANELSIZE_PERCENTAGE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModified { get; set; }

    public bool LegalToggleModeOn { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal LEGALPANELSIZE_PERCENTAGE { get; set; }
}
