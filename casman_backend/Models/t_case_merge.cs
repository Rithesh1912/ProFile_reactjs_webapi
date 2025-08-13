using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("t_case_merge")]
public partial class t_case_merge
{
    [StringLength(7)]
    [Unicode(false)]
    public string? case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? subsid_id { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? merged_case_id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? merged_subsid_id { get; set; }
}
