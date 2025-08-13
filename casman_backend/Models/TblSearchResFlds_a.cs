using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("TblSearchResFlds_a")]
public partial class TblSearchResFlds_a
{
    public bool Case_Id { get; set; }

    public bool Scrt_User { get; set; }

    public bool Incdt_Date { get; set; }

    public bool Summary { get; set; }

    public bool Case_Stat { get; set; }

    public bool Case_Type { get; set; }

    public bool Prac_Last_Name { get; set; }

    public bool Case_Spclty { get; set; }

    public bool Prac_Invl { get; set; }

    public bool Prac_Role { get; set; }

    public bool Cover_Type { get; set; }

    public bool Pt_Lname { get; set; }

    public bool Pt_Init { get; set; }

    public bool Pt_Dob { get; set; }

    public bool Pt_Sex { get; set; }

    public bool Pt_Loc { get; set; }

    public bool Indem_Res { get; set; }

    public bool Indem_Pay { get; set; }

    public bool Claimant_Costs { get; set; }

    public bool IHL_INVOLVE { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime date_last_updated { get; set; }

    [Column("event")]
    [StringLength(1)]
    [Unicode(false)]
    public string _event { get; set; } = null!;

    public bool mdu_pcnt { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? STAFF_ID { get; set; }

    public bool Prac_Group { get; set; }

    public bool? Redact_Case { get; set; }

    public bool? LEGAL_DISP_RESERVE { get; set; }

    public bool? LEGAL_DISP_PAID { get; set; }

    public bool? case_document_status { get; set; }

    public bool? PRAC_NUMBER { get; set; }

    public bool? CLAIM_DATE { get; set; }

    public bool? IHL_LEGALINSTRUCTION_ACTIVE { get; set; }

    public bool? Latest_Correspondance { get; set; }

    public bool? Case_File_Classification { get; set; }

    public bool? Case_Location { get; set; }

    public bool? Facility_Postcode { get; set; }

    public bool? Experts { get; set; }

    public bool MDU_Connect { get; set; }
}
