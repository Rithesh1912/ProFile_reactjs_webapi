using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
public partial class vw_ViewLimit1
{
    [StringLength(7)]
    [Unicode(false)]
    public string case_id { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string subsid_id { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string? mdu_unit { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? case_type { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? case_stat { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? scrt_usr { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? offc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? case_cat { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? case_class { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? spclty_maj_code { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? spclty_min_code { get; set; }

    [StringLength(130)]
    [Unicode(false)]
    public string? hptl_loc { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ha_fpc_name { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? area_code { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? prac_area_code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? incdt_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? open_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? close_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pymnt_data_avail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? reins_data_avail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ref_data_avail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? case_notes_avail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? case_of_int { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ha_aprvd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? mdureins_hal { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? mfiche_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? cru { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? first_pg_loc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? mdu_liability { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? old_case_type { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? second_scrt_usr { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    public short lock_no { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? file_class_code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? shared_case { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? third_scrt_usr { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? fac_postcode { get; set; }

    public short? YearOfCase { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? redact_case { get; set; }

    public short? redact_case_rule { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Case_Document_Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? case_uri { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? clfn_code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CLAIM_DATE { get; set; }

    [Unicode(false)]
    public string Legal_case_Document_Status { get; set; } = null!;
}
