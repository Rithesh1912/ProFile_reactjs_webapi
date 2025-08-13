using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("review_diary")]
public partial class review_diary
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime review_date { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? review_description { get; set; }

    public short? review_type { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? requested_by { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? next_review { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_file_request { get; set; }

    public short? lock_no { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? prac_num { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public int? Report_ID { get; set; }

    public int? DiaryEntryID { get; set; }
}
