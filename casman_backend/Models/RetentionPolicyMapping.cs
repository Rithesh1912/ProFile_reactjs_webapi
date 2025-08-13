using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace casman.Models;

/// <summary>
/// This describes the active and inactive polices attached to a case.
/// </summary>
[Table("RetentionPolicyMapping")]
public partial class RetentionPolicyMapping
{
    [Key]
    public long ID { get; set; }

    public long RetentionPolicyID { get; set; }

    public long SnapshotID { get; set; }

    /// <summary>
    /// The unique identifier for an entity.  e.g case_id + subsid_id for Pro-File
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string EntityID { get; set; } = null!;

    /// <summary>
    /// Whether this entry is provisional, that is, the entity is not yet in a state for it to fall under retention, but if it were to be at the moment the calculation was done this entry would have been added.
    /// 
    /// This filed
    /// </summary>
    public bool IsProvisional { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastCheckedDT { get; set; }

    /// <summary>
    /// The DT the policy was assigned to the entity
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime AssignedDT { get; set; }

    /// <summary>
    /// The name of the process that first calculated / assigned this policy to the entity. Typically this process will be the retention engine.
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string AssingedByProcess { get; set; } = null!;

    /// <summary>
    /// The user name that triggered the process that first assigned the policy to the entity. This will typically be the retention engine userID. However if a user action causes the calculation to be done then there userID will be recorded here.
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string AssignedByUserID { get; set; } = null!;

    /// <summary>
    /// If a policy is no longer applicable (whether it was in-force or not) for a case this will be the DT that happened.
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? UnassignedDT { get; set; }

    /// <summary>
    /// The name of the process that caused this policy to be removed from being applicable to the entity. Typically this process will be the retention engine.
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? UnassingedByProcess { get; set; }

    /// <summary>
    /// The user name that triggered the process that caused the policy to be removed from the entity. This will typically be the retention engine userID. However if a user action causes the calculation to be done then there userID will be recorded here.
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? UnassignedByUserID { get; set; }

    /// <summary>
    /// Whether this policy is the enforce policy for a case.
    /// 
    /// IMPORTANT, if the IsProvisional flag is true then it this policy is only provisionaly InForce.
    /// </summary>
    public bool IsInforcePolicy { get; set; }

    /// <summary>
    /// The base date used for calculating ActionDate and WarningDate. This is typically when an entity is closed / made inactive / last active
    /// </summary>
    public DateOnly PolicyStartDate { get; set; }

    /// <summary>
    /// The date after which the action should be run.
    /// </summary>
    public DateOnly PolicyInitialActionDate { get; set; }

    public DateOnly PolicyActualActionDate { get; set; }

    /// <summary>
    /// The date the case/policy is in it warning period. This will be calculated as PolicyTimespan+
    /// </summary>
    public DateOnly PolicyWarningDate { get; set; }

    /// <summary>
    /// Marks the case as having been actioned (deleted)
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? ActionedDT { get; set; }
}
