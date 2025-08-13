using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

[Keyless]
[Table("casebreak")]
public partial class casebreak
{
    [StringLength(7)]
    [Unicode(false)]
    public string Case_ID { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string Subsid_ID { get; set; } = null!;

    public bool? State_Claims_Agency { get; set; }

    public bool? Cond_Fee_Arrang { get; set; }

    public bool? Case_Pleaded_AvH { get; set; }

    public bool? Case_Pleaded_PD { get; set; }

    public bool? Case_Pleaded_PP { get; set; }

    public bool? Case_Pleaded_PPV { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? Brkdn_General { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_Special { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_General_Damages { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_General_Interest { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_General_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Earnings { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Care { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Services { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Accom { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Equip { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Transport0 { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Medical { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Misc { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Interest { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Past_Loss_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Earnings { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_SvM { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Pension { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Care { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Services { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Accom { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Equip { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Transport { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Medical { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Misc { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Court_Prot { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_AvH { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fut_Loss_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Beareavment { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Pre_Death { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Loss_Parent { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Loss_Depend { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Loss_Services { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Funeral_Exp { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Interest { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Fatal_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? FATAL_DEPENDENCY { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? FATAL_LOSS_EARNINGS { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? FATAL_PENSION { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? FATAL_OTHER { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? COMMENTS { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_Gen_Past_Fut_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Brkdn_Gen_Fatal_Total { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? user_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? date_last_updated { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RsrvFlag { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Interest_Frm_Proc { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Past_Fin_Dep { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Past_Serv_Dep { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Hosp_Rel_Costs { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Psycho_Damage { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Fut_loss_Serv { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Interest_Past_Loss { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Past_Loss_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_Accdt_Claim_Total { get; set; }

    [Column(TypeName = "decimal(12, 0)")]
    public decimal? Fatal_PLoss_AccdtClm_Total { get; set; }

    public bool? Fatal_Case { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Probability { get; set; }
}
