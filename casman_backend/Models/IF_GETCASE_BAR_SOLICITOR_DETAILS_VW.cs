using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class IF_GETCASE_BAR_SOLICITOR_DETAILS_VW
{
    [StringLength(2000)]
    [Unicode(false)]
    public string? barsol_name { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;
}
