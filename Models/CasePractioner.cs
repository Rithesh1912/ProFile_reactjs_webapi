
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CasmanSln.Models
{

    public class CasePractioner
    {
        [Key]
        [Column("case_id")]
        public string CaseId { get; set; }

        [Column("subsid_id")]
        public string? SubsidId { get; set; }

        [Column("prac_num")]
        public string PracNum { get; set; }

        [Column("prac_role")]
        public string PracRole { get; set; }

        [Column("prac_def_org")]
        public string? PracDefOrg { get; set; }

        [Column("prac_last_name")]
        public string? PracLastName { get; set; }

        [Column("prac_first_name")]
        public string? PracFirstName { get; set; }

        [Column("prac_init")]
        public string? PracInit { get; set; }

        [Column("prac_sex")]
        public string? PracSex { get; set; }

        [Column("prac_tow")]
        public string? PracTow { get; set; }

        [Column("prac_invl")]
        public string? PracInvl { get; set; }

        [Column("prac_seq_num")]
        public int? PracSeqNum { get; set; }

        [Column("date_involved")]
        public DateTime? DateInvolved { get; set; }

        [Column("date_notified")]
        public DateTime? DateNotified { get; set; }

        [Column("date_claim_made")]
        public DateTime? DateClaimMade { get; set; }

        [Column("prac_source")]
        public string? PracSource { get; set; }

        [Column("cover_type")]
        public string? CoverType { get; set; }

        [Column("user_id")]
        public string? UserId { get; set; }

        [Column("date_last_updated")]
        public DateTime? DateLastUpdated { get; set; }

        [Column("lock_no")]
        public int? LockNo { get; set; }

        [Column("DDRApplicable")]
        public bool? DdrApplicable { get; set; }

        [Column("DDRCoverType")]
        public string? DdrCoverType { get; set; }

        [Column("CharmPolicyNumber")]
        public string? CharmPolicyNumber { get; set; }

        [Column("CharmPolicyVersion")]
        public string? CharmPolicyVersion { get; set; }

        [Column("group_type")]
        public string? GroupType { get; set; }

        [Column("group_num")]
        public string? GroupNum { get; set; }

        [Column("orgname")]
        public string? OrgName { get; set; }

        [Column("Disc_Reason")]
        public string? DiscReason { get; set; }

        [Column("Member_Entitled")]
        public bool? MemberEntitled { get; set; }

        [Column("date_nonirish_claim_made")]
        public DateTime? DateNonIrishClaimMade { get; set; }

        [Column("ProdRefNo_SubSegCode")]
        public string? ProdRefNoSubSegCode { get; set; }

        [Column("DON_Polselection")]
        public string? DonPolSelection { get; set; }

        [Column("Member_Entitled_DateModified")]
        public DateTime? MemberEntitledDateModified { get; set; }

        [Column("PrivateGPClaims")]
        public bool? PrivateGpClaims { get; set; }
    }
}
