using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("DOC_ZETTAPERSISTENCE_BackUp")]
public partial class DOC_ZETTAPERSISTENCE_BackUp
{
    public long Keyno { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string Staff_Id { get; set; } = null!;

    public int ZettaPanelValue { get; set; }

    public bool LeftToggleModeOn { get; set; }

    public bool RightToggleModeOn { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal LeftPanelSize_Pixel { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal RightPanelSize_Pixel { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModified { get; set; }

    public bool LegalToggleModeOn { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal LegalPanelSize_Pixel { get; set; }
}
