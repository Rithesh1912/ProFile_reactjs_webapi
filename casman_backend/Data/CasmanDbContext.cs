using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using casman.Models;

namespace casman.Data;

public partial class CasmanDbContext : DbContext
{
    public CasmanDbContext()
    {
    }

    public CasmanDbContext(DbContextOptions<CasmanDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<A_Invoice> A_Invoices { get; set; }

    public virtual DbSet<A_Supplier> A_Suppliers { get; set; }

    public virtual DbSet<AmountValue> AmountValues { get; set; }

    public virtual DbSet<ApprovedEmailList> ApprovedEmailLists { get; set; }

    public virtual DbSet<AssignTaskToIntrlSolicitor> AssignTaskToIntrlSolicitors { get; set; }

    public virtual DbSet<AssignTaskToIntrlSolicitor_AT> AssignTaskToIntrlSolicitor_ATs { get; set; }

    public virtual DbSet<B_Supplier> B_Suppliers { get; set; }

    public virtual DbSet<Batch_Payment> Batch_Payments { get; set; }

    public virtual DbSet<Batch_Summary> Batch_Summaries { get; set; }

    public virtual DbSet<CD_VW_SEARCHVIEW> CD_VW_SEARCHVIEWs { get; set; }

    public virtual DbSet<CHM_GETCASEDETAILS_VW> CHM_GETCASEDETAILS_VWs { get; set; }

    public virtual DbSet<CMS_Message> CMS_Messages { get; set; }

    public virtual DbSet<DOC_ScreenSplitterPanelValue> DOC_ScreenSplitterPanelValues { get; set; }

    public virtual DbSet<DOC_ScreenSplitterPersistence> DOC_ScreenSplitterPersistences { get; set; }

    public virtual DbSet<DOC_ScreenSplitterPersistence_AT> DOC_ScreenSplitterPersistence_ATs { get; set; }

    public virtual DbSet<DOC_ZETTAPERSISTENCE_BackUp> DOC_ZETTAPERSISTENCE_BackUps { get; set; }

    public virtual DbSet<DOD_DestroyFile> DOD_DestroyFiles { get; set; }

    public virtual DbSet<E_Invoice> E_Invoices { get; set; }

    public virtual DbSet<Expense_Detail> Expense_Details { get; set; }

    public virtual DbSet<GDCDecision> GDCDecisions { get; set; }

    public virtual DbSet<GDC_Attendance> GDC_Attendances { get; set; }

    public virtual DbSet<GDC_IOC> GDC_IOCs { get; set; }

    public virtual DbSet<GMC_DESC> GMC_DESCs { get; set; }

    public virtual DbSet<IF_GETCASEDETAILS_Kofax_VW> IF_GETCASEDETAILS_Kofax_VWs { get; set; }

    public virtual DbSet<IF_GETCASEDETAILS_SIMPLE_VW> IF_GETCASEDETAILS_SIMPLE_VWs { get; set; }

    public virtual DbSet<IF_GETCASEDETAILS_VW> IF_GETCASEDETAILS_VWs { get; set; }

    public virtual DbSet<IF_GETCASE_BAR_SOLICITOR_DETAILS_VW> IF_GETCASE_BAR_SOLICITOR_DETAILS_VWs { get; set; }

    public virtual DbSet<IF_GETCASE_EXT_SOLICITOR_DETAILS_VW> IF_GETCASE_EXT_SOLICITOR_DETAILS_VWs { get; set; }

    public virtual DbSet<IF_GETCASE_INT_SOLICITOR_DETAILS_VW> IF_GETCASE_INT_SOLICITOR_DETAILS_VWs { get; set; }

    public virtual DbSet<IF_GETSTAFFDETAILS_VW> IF_GETSTAFFDETAILS_VWs { get; set; }

    public virtual DbSet<IOC_Outcome> IOC_Outcomes { get; set; }

    public virtual DbSet<L_Invoice> L_Invoices { get; set; }

    public virtual DbSet<MAPPINGCLASSIFICATION> MAPPINGCLASSIFICATIONs { get; set; }

    public virtual DbSet<MDUC_Footer> MDUC_Footers { get; set; }

    public virtual DbSet<MT_Entity> MT_Entities { get; set; }

    public virtual DbSet<MT_EntityHistory> MT_EntityHistories { get; set; }

    public virtual DbSet<MT_EntityHistory_Audit> MT_EntityHistory_Audits { get; set; }

    public virtual DbSet<MT_EntityRelationship> MT_EntityRelationships { get; set; }

    public virtual DbSet<MT_EntityRelationships_Audit> MT_EntityRelationships_Audits { get; set; }

    public virtual DbSet<MT_EntityType> MT_EntityTypes { get; set; }

    public virtual DbSet<MT_EntityType_Audit> MT_EntityType_Audits { get; set; }

    public virtual DbSet<MT_Entity_Audit> MT_Entity_Audits { get; set; }

    public virtual DbSet<MT_Location> MT_Locations { get; set; }

    public virtual DbSet<MT_LocationType> MT_LocationTypes { get; set; }

    public virtual DbSet<MT_LocationType_Audit> MT_LocationType_Audits { get; set; }

    public virtual DbSet<MT_Location_Audit> MT_Location_Audits { get; set; }

    public virtual DbSet<MT_RetentionDateTriggerType> MT_RetentionDateTriggerTypes { get; set; }

    public virtual DbSet<MT_RetentionDateTriggerType_Audit> MT_RetentionDateTriggerType_Audits { get; set; }

    public virtual DbSet<MT_RetentionPeriod> MT_RetentionPeriods { get; set; }

    public virtual DbSet<MT_RetentionPeriodType> MT_RetentionPeriodTypes { get; set; }

    public virtual DbSet<MT_RetentionSchedule> MT_RetentionSchedules { get; set; }

    public virtual DbSet<MT_RetentionSchedule_Audit> MT_RetentionSchedule_Audits { get; set; }

    public virtual DbSet<MduMemberDetail> MduMemberDetails { get; set; }

    public virtual DbSet<ProfileUrlTimeout> ProfileUrlTimeouts { get; set; }

    public virtual DbSet<RetentionPolicyMapping> RetentionPolicyMappings { get; set; }

    public virtual DbSet<ScriptHistory> ScriptHistories { get; set; }

    public virtual DbSet<Search_Logging> Search_Loggings { get; set; }

    public virtual DbSet<StageofInvestication> StageofInvestications { get; set; }

    public virtual DbSet<TBLEXPENSE> TBLEXPENSEs { get; set; }

    public virtual DbSet<TBLFunding> TBLFundings { get; set; }

    public virtual DbSet<TBLQUARTERLYREPORTCLAIM> TBLQUARTERLYREPORTCLAIMs { get; set; }

    public virtual DbSet<TBLQUARTERLYREPORTCLAIMS_A> TBLQUARTERLYREPORTCLAIMS_As { get; set; }

    public virtual DbSet<TBLSUBDEPARTMENT> TBLSUBDEPARTMENTs { get; set; }

    public virtual DbSet<TBLSUBDEPARTMENT_MAPPING> TBLSUBDEPARTMENT_MAPPINGs { get; set; }

    public virtual DbSet<TBLWITNESS> TBLWITNESSes { get; set; }

    public virtual DbSet<TEMP1> TEMP1s { get; set; }

    public virtual DbSet<TEMPCRCY> TEMPCRCies { get; set; }

    public virtual DbSet<TEMPRANKING> TEMPRANKINGs { get; set; }

    public virtual DbSet<TEMPTBLANDSUMM> TEMPTBLANDSUMMs { get; set; }

    public virtual DbSet<TEMPTBLCURRENTRESULT> TEMPTBLCURRENTRESULTs { get; set; }

    public virtual DbSet<TEMPTBLFINAL> TEMPTBLFINALs { get; set; }

    public virtual DbSet<TEMPTBLINTRESULT> TEMPTBLINTRESULTs { get; set; }

    public virtual DbSet<TEMPTBLINTRESULT1> TEMPTBLINTRESULT1s { get; set; }

    public virtual DbSet<TEMPTBLNOTSUMM> TEMPTBLNOTSUMMs { get; set; }

    public virtual DbSet<TEMPTBLORSUMM> TEMPTBLORSUMMs { get; set; }

    public virtual DbSet<TEMPTBLRESULTKEY> TEMPTBLRESULTKEYs { get; set; }

    public virtual DbSet<TEMPTBLRESULTSUMM> TEMPTBLRESULTSUMMs { get; set; }

    public virtual DbSet<T_Invoice> T_Invoices { get; set; }

    public virtual DbSet<TblAdvCaseProgress> TblAdvCaseProgresses { get; set; }

    public virtual DbSet<TblAdvCaseProgress_a> TblAdvCaseProgress_as { get; set; }

    public virtual DbSet<TblAdvProgEvent> TblAdvProgEvents { get; set; }

    public virtual DbSet<TblAdvProgType> TblAdvProgTypes { get; set; }

    public virtual DbSet<TblBackCaseId> TblBackCaseIds { get; set; }

    public virtual DbSet<TblBarAssignment> TblBarAssignments { get; set; }

    public virtual DbSet<TblBarAssignment_a> TblBarAssignment_as { get; set; }

    public virtual DbSet<TblBarrister> TblBarristers { get; set; }

    public virtual DbSet<TblBenefitHistory> TblBenefitHistories { get; set; }

    public virtual DbSet<TblCCA> TblCCAs { get; set; }

    public virtual DbSet<TblCCA_a> TblCCA_as { get; set; }

    public virtual DbSet<TblCCAaddr> TblCCAaddrs { get; set; }

    public virtual DbSet<TblCCAaddr_a> TblCCAaddr_as { get; set; }

    public virtual DbSet<TblCancelationDetail> TblCancelationDetails { get; set; }

    public virtual DbSet<TblCancelationDetails_a> TblCancelationDetails_as { get; set; }

    public virtual DbSet<TblCaseHandlingNote> TblCaseHandlingNotes { get; set; }

    public virtual DbSet<TblCaseHandlingNote_a> TblCaseHandlingNote_as { get; set; }

    public virtual DbSet<TblCaseResbreakdown> TblCaseResbreakdowns { get; set; }

    public virtual DbSet<TblCaseResbreakdown_241396> TblCaseResbreakdown_241396s { get; set; }

    public virtual DbSet<TblCaseResbreakdown_A_Audit> TblCaseResbreakdown_A_Audits { get; set; }

    public virtual DbSet<TblCaseResbreakdown_a> TblCaseResbreakdown_as { get; set; }

    public virtual DbSet<TblChamber> TblChambers { get; set; }

    public virtual DbSet<TblClosingSummary> TblClosingSummaries { get; set; }

    public virtual DbSet<TblClosingSummary_a> TblClosingSummary_as { get; set; }

    public virtual DbSet<TblDDRCoverType> TblDDRCoverTypes { get; set; }

    public virtual DbSet<TblDentalSpclty> TblDentalSpclties { get; set; }

    public virtual DbSet<TblDiscretionaryReason> TblDiscretionaryReasons { get; set; }

    public virtual DbSet<TblDuplicatePayReason> TblDuplicatePayReasons { get; set; }

    public virtual DbSet<TblExpert> TblExperts { get; set; }

    public virtual DbSet<TblExpertAdultSpclty> TblExpertAdultSpclties { get; set; }

    public virtual DbSet<TblExpertContType> TblExpertContTypes { get; set; }

    public virtual DbSet<TblExpertContact_a> TblExpertContact_as { get; set; }

    public virtual DbSet<TblExpertDentalSpclty> TblExpertDentalSpclties { get; set; }

    public virtual DbSet<TblExpertPaedSpclty> TblExpertPaedSpclties { get; set; }

    public virtual DbSet<TblExpertReport> TblExpertReports { get; set; }

    public virtual DbSet<TblExpertReport_a> TblExpertReport_as { get; set; }

    public virtual DbSet<TblExpertVATCharged> TblExpertVATChargeds { get; set; }

    public virtual DbSet<TblExpert_EngagementStatus> TblExpert_EngagementStatuses { get; set; }

    public virtual DbSet<TblExpert_a> TblExpert_as { get; set; }

    public virtual DbSet<TblExpert_bck> TblExpert_bcks { get; set; }

    public virtual DbSet<TblExtSol> TblExtSols { get; set; }

    public virtual DbSet<TblExtSolAssignment_a> TblExtSolAssignment_as { get; set; }

    public virtual DbSet<TblExtSol_a> TblExtSol_as { get; set; }

    public virtual DbSet<TblFinding> TblFindings { get; set; }

    public virtual DbSet<TblGroupType> TblGroupTypes { get; set; }

    public virtual DbSet<TblHighValueReview> TblHighValueReviews { get; set; }

    public virtual DbSet<TblHighValueReview_a> TblHighValueReview_as { get; set; }

    public virtual DbSet<TblKeyword> TblKeywords { get; set; }

    public virtual DbSet<TblKeyword_a> TblKeyword_as { get; set; }

    public virtual DbSet<TblLegalReportDatum> TblLegalReportData { get; set; }

    public virtual DbSet<TblMeetingRequest> TblMeetingRequests { get; set; }

    public virtual DbSet<TblMeetingRequest_a> TblMeetingRequest_as { get; set; }

    public virtual DbSet<TblMeetingType> TblMeetingTypes { get; set; }

    public virtual DbSet<TblPhysicalItem> TblPhysicalItems { get; set; }

    public virtual DbSet<TblPhysicalItems_a> TblPhysicalItems_as { get; set; }

    public virtual DbSet<TblPostcodeLL> TblPostcodeLLs { get; set; }

    public virtual DbSet<TblPotCaseKeyword_a> TblPotCaseKeyword_as { get; set; }

    public virtual DbSet<TblQuarterlyReportDataMapping> TblQuarterlyReportDataMappings { get; set; }

    public virtual DbSet<TblQuarterlyReportDatum> TblQuarterlyReportData { get; set; }

    public virtual DbSet<TblQuarterlyReportGDC> TblQuarterlyReportGDCs { get; set; }

    public virtual DbSet<TblQuarterlyReportGDC_A> TblQuarterlyReportGDC_As { get; set; }

    public virtual DbSet<TblQuarterlyReportGMC> TblQuarterlyReportGMCs { get; set; }

    public virtual DbSet<TblQuarterlyReportGMC_A> TblQuarterlyReportGMC_As { get; set; }

    public virtual DbSet<TblReallocation_a> TblReallocation_as { get; set; }

    public virtual DbSet<TblReleaseInfo> TblReleaseInfos { get; set; }

    public virtual DbSet<TblSearchResFld> TblSearchResFlds { get; set; }

    public virtual DbSet<TblSearchResFlds_a> TblSearchResFlds_as { get; set; }

    public virtual DbSet<TblTariff_Code> TblTariff_Codes { get; set; }

    public virtual DbSet<TblTempCCA> TblTempCCAs { get; set; }

    public virtual DbSet<TblTemplateForCase> TblTemplateForCases { get; set; }

    public virtual DbSet<TblTemplateForCase_Audit> TblTemplateForCase_Audits { get; set; }

    public virtual DbSet<TblTmpccaaddr> TblTmpccaaddrs { get; set; }

    public virtual DbSet<TblType> TblTypes { get; set; }

    public virtual DbSet<Tbl_ConfltSerHist> Tbl_ConfltSerHists { get; set; }

    public virtual DbSet<Tbl_Fund_SettlementType> Tbl_Fund_SettlementTypes { get; set; }

    public virtual DbSet<Tbl_Rsrv_HvrHistory> Tbl_Rsrv_HvrHistories { get; set; }

    public virtual DbSet<TbladultSpclty> TbladultSpclties { get; set; }

    public virtual DbSet<Tblcasekeyword> Tblcasekeywords { get; set; }

    public virtual DbSet<Tblcasekeyword_a> Tblcasekeyword_as { get; set; }

    public virtual DbSet<Tbldisbursementtemp> Tbldisbursementtemps { get; set; }

    public virtual DbSet<Tblexpensebatch> Tblexpensebatches { get; set; }

    public virtual DbSet<Tblexpensebatch_a> Tblexpensebatch_as { get; set; }

    public virtual DbSet<Tblexpensedtl> Tblexpensedtls { get; set; }

    public virtual DbSet<Tblexpensedtls_a> Tblexpensedtls_as { get; set; }

    public virtual DbSet<Tblexpertcontact> Tblexpertcontacts { get; set; }

    public virtual DbSet<Tblextsolassignment> Tblextsolassignments { get; set; }

    public virtual DbSet<TblpaediatricSpclty> TblpaediatricSpclties { get; set; }

    public virtual DbSet<Tblpotcasekeyword> Tblpotcasekeywords { get; set; }

    public virtual DbSet<Tblreallocation> Tblreallocations { get; set; }

    public virtual DbSet<Tblrecoverybatch> Tblrecoverybatches { get; set; }

    public virtual DbSet<Tblrecoverybatch_a> Tblrecoverybatch_as { get; set; }

    public virtual DbSet<Tblrecoverydtl> Tblrecoverydtls { get; set; }

    public virtual DbSet<Tblrecoverydtls_Temp> Tblrecoverydtls_Temps { get; set; }

    public virtual DbSet<Tblrecoverydtls_a> Tblrecoverydtls_as { get; set; }

    public virtual DbSet<Tblsechistory> Tblsechistories { get; set; }

    public virtual DbSet<Tbltarrif> Tbltarrifs { get; set; }

    public virtual DbSet<Tbltempinvoice> Tbltempinvoices { get; set; }

    public virtual DbSet<Temp_Supplier> Temp_Suppliers { get; set; }

    public virtual DbSet<Transfer_Sage_Logging> Transfer_Sage_Loggings { get; set; }

    public virtual DbSet<_new> news { get; set; }

    public virtual DbSet<activity> activities { get; set; }

    public virtual DbSet<activity_pt> activity_pts { get; set; }

    public virtual DbSet<activity_temp> activity_temps { get; set; }

    public virtual DbSet<adv_team> adv_teams { get; set; }

    public virtual DbSet<app_authority> app_authorities { get; set; }

    public virtual DbSet<app_authority_a> app_authority_as { get; set; }

    public virtual DbSet<app_function> app_functions { get; set; }

    public virtual DbSet<app_function_a> app_function_as { get; set; }

    public virtual DbSet<app_role> app_roles { get; set; }

    public virtual DbSet<app_role_a> app_role_as { get; set; }

    public virtual DbSet<app_role_bck> app_role_bcks { get; set; }

    public virtual DbSet<app_role_hdr> app_role_hdrs { get; set; }

    public virtual DbSet<app_role_hdr_bck> app_role_hdr_bcks { get; set; }

    public virtual DbSet<app_user> app_users { get; set; }

    public virtual DbSet<app_user_a> app_user_as { get; set; }

    public virtual DbSet<assignment> assignments { get; set; }

    public virtual DbSet<assignment_a> assignment_as { get; set; }

    public virtual DbSet<auth_level> auth_levels { get; set; }

    public virtual DbSet<auth_level_a> auth_level_as { get; set; }

    public virtual DbSet<basiscase_list> basiscase_lists { get; set; }

    public virtual DbSet<basiscase_list_at> basiscase_list_ats { get; set; }

    public virtual DbSet<bkpT_CASE_PRAC> bkpT_CASE_PRACs { get; set; }

    public virtual DbSet<bsaltiim> bsaltiims { get; set; }

    public virtual DbSet<case_a> case_as { get; set; }

    public virtual DbSet<casebreak> casebreaks { get; set; }

    public virtual DbSet<caseview> caseviews { get; set; }

    public virtual DbSet<category> categories { get; set; }

    public virtual DbSet<cencurm> cencurms { get; set; }

    public virtual DbSet<ceratem> ceratems { get; set; }

    public virtual DbSet<cheque_recovery> cheque_recoveries { get; set; }

    public virtual DbSet<cheque_recovery_at> cheque_recovery_ats { get; set; }

    public virtual DbSet<country> countries { get; set; }

    public virtual DbSet<cover_type> cover_types { get; set; }

    public virtual DbSet<department> departments { get; set; }

    public virtual DbSet<destroyfile> destroyfiles { get; set; }

    public virtual DbSet<expert> experts { get; set; }

    public virtual DbSet<global_datum> global_data { get; set; }

    public virtual DbSet<indemnifier> indemnifiers { get; set; }

    public virtual DbSet<invoice> invoices { get; set; }

    public virtual DbSet<invoice_a> invoice_as { get; set; }

    public virtual DbSet<invoice_item_no> invoice_item_nos { get; set; }

    public virtual DbSet<legal_code> legal_codes { get; set; }

    public virtual DbSet<master> masters { get; set; }

    public virtual DbSet<mdu_liability> mdu_liabilities { get; set; }

    public virtual DbSet<nljrnm> nljrnms { get; set; }

    public virtual DbSet<paymt_status> paymt_statuses { get; set; }

    public virtual DbSet<plinvm> plinvms { get; set; }

    public virtual DbSet<plitemm> plitemms { get; set; }

    public virtual DbSet<plsuppm> plsuppms { get; set; }

    public virtual DbSet<plxrefm> plxrefms { get; set; }

    public virtual DbSet<priority> priorities { get; set; }

    public virtual DbSet<recent_payee> recent_payees { get; set; }

    public virtual DbSet<report_url> report_urls { get; set; }

    public virtual DbSet<report_url1> report_url1s { get; set; }

    public virtual DbSet<res_hist_net> res_hist_nets { get; set; }

    public virtual DbSet<reserve_hist> reserve_hists { get; set; }

    public virtual DbSet<reserve_hist_a> reserve_hist_as { get; set; }

    public virtual DbSet<review_diary> review_diaries { get; set; }

    public virtual DbSet<review_diary_a> review_diary_as { get; set; }

    public virtual DbSet<review_reason> review_reasons { get; set; }

    public virtual DbSet<ri_app_det> ri_app_dets { get; set; }

    public virtual DbSet<ri_app_det_a> ri_app_det_as { get; set; }

    public virtual DbSet<ri_batch> ri_batches { get; set; }

    public virtual DbSet<ri_batch_a> ri_batch_as { get; set; }

    public virtual DbSet<ri_head> ri_heads { get; set; }

    public virtual DbSet<ri_head_282531> ri_head_282531s { get; set; }

    public virtual DbSet<ri_head_a> ri_head_as { get; set; }

    public virtual DbSet<ri_leg_det> ri_leg_dets { get; set; }

    public virtual DbSet<ri_leg_det_a> ri_leg_det_as { get; set; }

    public virtual DbSet<ri_pay_cat> ri_pay_cats { get; set; }

    public virtual DbSet<ri_pay_cat2> ri_pay_cat2s { get; set; }

    public virtual DbSet<ri_pay_type> ri_pay_types { get; set; }

    public virtual DbSet<ri_pc_det> ri_pc_dets { get; set; }

    public virtual DbSet<ri_pc_det_a> ri_pc_det_as { get; set; }

    public virtual DbSet<ri_pc_det_temp> ri_pc_det_temps { get; set; }

    public virtual DbSet<ri_solictor> ri_solictors { get; set; }

    public virtual DbSet<ri_suspend> ri_suspends { get; set; }

    public virtual DbSet<ri_suspend_a> ri_suspend_as { get; set; }

    public virtual DbSet<ri_suspend_temp> ri_suspend_temps { get; set; }

    public virtual DbSet<ri_txt> ri_txts { get; set; }

    public virtual DbSet<ri_txt_a> ri_txt_as { get; set; }

    public virtual DbSet<sequence_number> sequence_numbers { get; set; }

    public virtual DbSet<split_reason> split_reasons { get; set; }

    public virtual DbSet<splitcase_list> splitcase_lists { get; set; }

    public virtual DbSet<staff> staff { get; set; }

    public virtual DbSet<staff_a> staff_as { get; set; }

    public virtual DbSet<sysdirm> sysdirms { get; set; }

    public virtual DbSet<t_Classification> t_Classifications { get; set; }

    public virtual DbSet<t_MissedKPIReason> t_MissedKPIReasons { get; set; }

    public virtual DbSet<t_ReasonsForMissedKPI> t_ReasonsForMissedKPIs { get; set; }

    public virtual DbSet<t_area> t_areas { get; set; }

    public virtual DbSet<t_basis_result> t_basis_results { get; set; }

    public virtual DbSet<t_case> t_cases { get; set; }

    public virtual DbSet<t_case_Splt> t_case_Splts { get; set; }

    public virtual DbSet<t_case_US56053> t_case_US56053s { get; set; }

    public virtual DbSet<t_case_a> t_case_as { get; set; }

    public virtual DbSet<t_case_close> t_case_closes { get; set; }

    public virtual DbSet<t_case_count> t_case_counts { get; set; }

    public virtual DbSet<t_case_cru> t_case_crus { get; set; }

    public virtual DbSet<t_case_cru_at> t_case_cru_ats { get; set; }

    public virtual DbSet<t_case_merge> t_case_merges { get; set; }

    public virtual DbSet<t_case_mliab_a> t_case_mliab_as { get; set; }

    public virtual DbSet<t_case_prac> t_case_pracs { get; set; }

    public virtual DbSet<t_case_prac_a> t_case_prac_as { get; set; }

    public virtual DbSet<t_case_qtm> t_case_qtms { get; set; }

    public virtual DbSet<t_case_qtm_a> t_case_qtm_as { get; set; }

    public virtual DbSet<t_case_rest> t_case_rests { get; set; }

    public virtual DbSet<t_case_rest_a> t_case_rest_as { get; set; }

    public virtual DbSet<t_case_rmk> t_case_rmks { get; set; }

    public virtual DbSet<t_case_rmks_a> t_case_rmks_as { get; set; }

    public virtual DbSet<t_case_scan> t_case_scans { get; set; }

    public virtual DbSet<t_case_scan_a> t_case_scan_as { get; set; }

    public virtual DbSet<t_case_scrt_a> t_case_scrt_as { get; set; }

    public virtual DbSet<t_case_split> t_case_splits { get; set; }

    public virtual DbSet<t_case_split_a> t_case_split_as { get; set; }

    public virtual DbSet<t_case_stat> t_case_stats { get; set; }

    public virtual DbSet<t_case_summ> t_case_summs { get; set; }

    public virtual DbSet<t_case_summ_a> t_case_summ_as { get; set; }

    public virtual DbSet<t_case_transGender> t_case_transGenders { get; set; }

    public virtual DbSet<t_case_type> t_case_types { get; set; }

    public virtual DbSet<t_cmtee> t_cmtees { get; set; }

    public virtual DbSet<t_cmtee_a> t_cmtee_as { get; set; }

    public virtual DbSet<t_cmtee_apptmt> t_cmtee_apptmts { get; set; }

    public virtual DbSet<t_cmtee_apptmt_a> t_cmtee_apptmt_as { get; set; }

    public virtual DbSet<t_cmtee_dcsn_code> t_cmtee_dcsn_codes { get; set; }

    public virtual DbSet<t_cmtee_type> t_cmtee_types { get; set; }

    public virtual DbSet<t_cru_stat> t_cru_stats { get; set; }

    public virtual DbSet<t_def_org> t_def_orgs { get; set; }

    public virtual DbSet<t_file_classification> t_file_classifications { get; set; }

    public virtual DbSet<t_non_mbr> t_non_mbrs { get; set; }

    public virtual DbSet<t_non_mbr_a> t_non_mbr_as { get; set; }

    public virtual DbSet<t_offc> t_offcs { get; set; }

    public virtual DbSet<t_prac_area> t_prac_areas { get; set; }

    public virtual DbSet<t_productType> t_productTypes { get; set; }

    public virtual DbSet<t_pt_info> t_pt_infos { get; set; }

    public virtual DbSet<t_recent_case> t_recent_cases { get; set; }

    public virtual DbSet<t_role> t_roles { get; set; }

    public virtual DbSet<t_spclty> t_spclties { get; set; }

    public virtual DbSet<tblCaseDocumentStatus> tblCaseDocumentStatuses { get; set; }

    public virtual DbSet<tblFileStrategy> tblFileStrategies { get; set; }

    public virtual DbSet<tblFileStrategyHistory> tblFileStrategyHistories { get; set; }

    public virtual DbSet<tblSupActivity> tblSupActivities { get; set; }

    public virtual DbSet<tbl_LegalCaseDocumentStatus> tbl_LegalCaseDocumentStatuses { get; set; }

    public virtual DbSet<tbl_cat_mapping> tbl_cat_mappings { get; set; }

    public virtual DbSet<tblexpensedtls_temp> tblexpensedtls_temps { get; set; }

    public virtual DbSet<timesheet> timesheets { get; set; }

    public virtual DbSet<timesheet_a> timesheet_as { get; set; }

    public virtual DbSet<timesheet_act> timesheet_acts { get; set; }

    public virtual DbSet<timesheet_act_a> timesheet_act_as { get; set; }

    public virtual DbSet<update> updates { get; set; }

    public virtual DbSet<vw_ViewLimit1> vw_ViewLimit1s { get; set; }

    public virtual DbSet<weekday> weekdays { get; set; }

    public virtual DbSet<work_category> work_categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=172.16.0.43;Database=Casman2;User Id=sa;Password=Database@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A_Supplier>(entity =>
        {
            entity.Property(e => e.Email1).IsFixedLength();
        });

        modelBuilder.Entity<ApprovedEmailList>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__Approved__CA1FE46458B5F393");

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.SubSid).IsFixedLength();
        });

        modelBuilder.Entity<AssignTaskToIntrlSolicitor>(entity =>
        {
            entity.HasKey(e => e.assign_id)
                .HasName("PK__AssignTaskToIntr__65C770CB")
                .HasFillFactor(100);

            entity.ToTable("AssignTaskToIntrlSolicitor", tb =>
                {
                    tb.HasTrigger("AuditForInsertAssignTask_In_AssignTasktoIntrlSolicitor");
                    tb.HasTrigger("AuditForRemoveAssignTask_In_AssignTasktoIntrlSolicitor");
                    tb.HasTrigger("AuditForUpdateAssignTask_In_AssignTasktoIntrlSolicitor");
                });

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<AssignTaskToIntrlSolicitor_AT>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<CD_VW_SEARCHVIEW>(entity =>
        {
            entity.ToView("CD_VW_SEARCHVIEW");

            entity.Property(e => e.Case_Handler1).IsFixedLength();
            entity.Property(e => e.Case_Handler2).IsFixedLength();
            entity.Property(e => e.Case_Handler3).IsFixedLength();
            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Pt_Init).IsFixedLength();
            entity.Property(e => e.Speciality1).IsFixedLength();
            entity.Property(e => e.Speciality2).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
        });

        modelBuilder.Entity<CHM_GETCASEDETAILS_VW>(entity =>
        {
            entity.ToView("CHM_GETCASEDETAILS_VW");

            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Category).IsFixedLength();
            entity.Property(e => e.Country).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Liability).IsFixedLength();
            entity.Property(e => e.MDUNumber).IsFixedLength();
            entity.Property(e => e.Office).IsFixedLength();
            entity.Property(e => e.PracticeArea).IsFixedLength();
            entity.Property(e => e.Secretariat1).IsFixedLength();
            entity.Property(e => e.Secretariat2).IsFixedLength();
            entity.Property(e => e.Solicitor).IsFixedLength();
            entity.Property(e => e.Speciality).IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
            entity.Property(e => e.Type).IsFixedLength();
        });

        modelBuilder.Entity<CMS_Message>(entity =>
        {
            entity.Property(e => e.MessageType).IsFixedLength();
        });

        modelBuilder.Entity<DOC_ScreenSplitterPanelValue>(entity =>
        {
            entity.HasKey(e => e.Keyno)
                .HasName("PK__DOC_ZettaPanelVa__5DD6161A")
                .HasFillFactor(100);

            entity.Property(e => e.Keyno).ValueGeneratedNever();
        });

        modelBuilder.Entity<DOC_ScreenSplitterPersistence>(entity =>
        {
            entity.HasKey(e => e.Keyno)
                .HasName("PK__DOC_ZettaPersist__5AF9A96F")
                .HasFillFactor(100);

            entity.ToTable("DOC_ScreenSplitterPersistence", tb =>
                {
                    tb.HasTrigger("TR_DOC_SCREENSPLITTERPERSISTENCE_INS");
                    tb.HasTrigger("TR_DOC_SCREENSPLITTERPERSISTENCE_UPD");
                });

            entity.Property(e => e.LegalToggleModeOn).HasDefaultValue(true);
            entity.Property(e => e.Staff_Id).IsFixedLength();
        });

        modelBuilder.Entity<DOC_ScreenSplitterPersistence_AT>(entity =>
        {
            entity.Property(e => e.LEGALPANELSIZE_PERCENTAGE).HasDefaultValue(0.000m);
            entity.Property(e => e.LegalToggleModeOn).HasDefaultValue(true);
            entity.Property(e => e.Operation).IsFixedLength();
            entity.Property(e => e.Staff_Id).IsFixedLength();
        });

        modelBuilder.Entity<DOC_ZETTAPERSISTENCE_BackUp>(entity =>
        {
            entity.Property(e => e.Keyno).ValueGeneratedOnAdd();
            entity.Property(e => e.Staff_Id).IsFixedLength();
        });

        modelBuilder.Entity<DOD_DestroyFile>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.IsActioned).HasDefaultValue(false);
        });

        modelBuilder.Entity<GDCDecision>(entity =>
        {
            entity.HasKey(e => e.Decision_Id).HasName("Pk_GDCDecision_Decision_Id");

            entity.HasOne(d => d.Investication).WithMany(p => p.GDCDecisions).HasConstraintName("Fk_StageofInvestication_Investication_Id");
        });

        modelBuilder.Entity<GDC_Attendance>(entity =>
        {
            entity.HasKey(e => e.Attendance_Id).HasName("Pk_GDC_Attendance_Attendance_Id");
        });

        modelBuilder.Entity<GDC_IOC>(entity =>
        {
            entity.HasKey(e => e.IOC_Id).HasName("Pk_GDC_IOC_IOC_Id");
        });

        modelBuilder.Entity<GMC_DESC>(entity =>
        {
            entity.HasKey(e => e.DESC_ID).HasName("PK__GMC_DESC__A734D70100FB511C");
        });

        modelBuilder.Entity<IF_GETCASEDETAILS_Kofax_VW>(entity =>
        {
            entity.ToView("IF_GETCASEDETAILS_Kofax_VW");

            entity.Property(e => e.Country).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Patient_Deceased).IsFixedLength();
            entity.Property(e => e.Patient_Initials).IsFixedLength();
            entity.Property(e => e.Patient_Sex).IsFixedLength();
            entity.Property(e => e.Secretariat1Department).IsFixedLength();
            entity.Property(e => e.Secretariat2Department).IsFixedLength();
            entity.Property(e => e.Secretariat3Department).IsFixedLength();
            entity.Property(e => e.Type).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.patient_informed).IsFixedLength();
            entity.Property(e => e.prac_init).IsFixedLength();
            entity.Property(e => e.prac_num).IsFixedLength();
            entity.Property(e => e.staff_name).IsFixedLength();
            entity.Property(e => e.staff_no).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.team).IsFixedLength();
        });

        modelBuilder.Entity<IF_GETCASEDETAILS_SIMPLE_VW>(entity =>
        {
            entity.ToView("IF_GETCASEDETAILS_SIMPLE_VW");

            entity.Property(e => e.Case_Id_SubId).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.case_uri).IsFixedLength();
            entity.Property(e => e.redact_case).IsFixedLength();
            entity.Property(e => e.scrt_usr).IsFixedLength();
            entity.Property(e => e.scrt_usr_id).IsFixedLength();
            entity.Property(e => e.scrt_usr_name).IsFixedLength();
            entity.Property(e => e.scrt_usr_team).IsFixedLength();
            entity.Property(e => e.second_scrt_usr).IsFixedLength();
            entity.Property(e => e.second_scrt_usr_dept).IsFixedLength();
            entity.Property(e => e.second_scrt_usr_id).IsFixedLength();
            entity.Property(e => e.second_scrt_usr_name).IsFixedLength();
            entity.Property(e => e.second_scrt_usr_team).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.third_scrt_usr).IsFixedLength();
            entity.Property(e => e.third_scrt_usr_dept).IsFixedLength();
            entity.Property(e => e.third_scrt_usr_id).IsFixedLength();
            entity.Property(e => e.third_scrt_usr_name).IsFixedLength();
            entity.Property(e => e.third_scrt_usr_team).IsFixedLength();
        });

        modelBuilder.Entity<IF_GETCASEDETAILS_VW>(entity =>
        {
            entity.ToView("IF_GETCASEDETAILS_VW");

            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Category).IsFixedLength();
            entity.Property(e => e.Country).IsFixedLength();
            entity.Property(e => e.Liability).IsFixedLength();
            entity.Property(e => e.MDUNumber).IsFixedLength();
            entity.Property(e => e.Office).IsFixedLength();
            entity.Property(e => e.PracticeArea).IsFixedLength();
            entity.Property(e => e.Secretariat1).IsFixedLength();
            entity.Property(e => e.Secretariat2).IsFixedLength();
            entity.Property(e => e.Solicitor).IsFixedLength();
            entity.Property(e => e.Speciality).IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
            entity.Property(e => e.Type).IsFixedLength();
            entity.Property(e => e.case_uri).IsFixedLength();
            entity.Property(e => e.redact_case).IsFixedLength();
        });

        modelBuilder.Entity<IF_GETCASE_BAR_SOLICITOR_DETAILS_VW>(entity =>
        {
            entity.ToView("IF_GETCASE_BAR_SOLICITOR_DETAILS_VW");

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<IF_GETCASE_EXT_SOLICITOR_DETAILS_VW>(entity =>
        {
            entity.ToView("IF_GETCASE_EXT_SOLICITOR_DETAILS_VW");

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<IF_GETCASE_INT_SOLICITOR_DETAILS_VW>(entity =>
        {
            entity.ToView("IF_GETCASE_INT_SOLICITOR_DETAILS_VW");

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<IF_GETSTAFFDETAILS_VW>(entity =>
        {
            entity.ToView("IF_GETSTAFFDETAILS_VW");

            entity.Property(e => e.TeamADAccount).IsFixedLength();
            entity.Property(e => e.staff_name).IsFixedLength();
            entity.Property(e => e.staff_no).IsFixedLength();
        });

        modelBuilder.Entity<IOC_Outcome>(entity =>
        {
            entity.HasKey(e => e.IOC_Outcome_Id).HasName("Pk_IOC_Outcome_IOC_Outcome_Id");

            entity.HasOne(d => d.IOC).WithMany(p => p.IOC_Outcomes).HasConstraintName("Fk_IOC_Outcome_IOC_Id");
        });

        modelBuilder.Entity<MAPPINGCLASSIFICATION>(entity =>
        {
            entity.HasKey(e => e.ID).HasFillFactor(100);

            entity.Property(e => e.Clfn_Code).IsFixedLength();
        });

        modelBuilder.Entity<MDUC_Footer>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__MDUC_Foo__3214EC2750A23284");

            entity.Property(e => e.ID).ValueGeneratedNever();
        });

        modelBuilder.Entity<MT_Entity>(entity =>
        {
            entity.Property(e => e.EID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MT_EntityHistory>(entity =>
        {
            entity.HasKey(e => e.EHID).HasFillFactor(100);

            entity.ToTable("MT_EntityHistory", tb => tb.HasTrigger("TR_EntityHistory"));

            entity.HasIndex(e => e.EID, "Index_MT_EntityHistory_EID").HasFillFactor(100);
        });

        modelBuilder.Entity<MT_EntityRelationship>(entity =>
        {
            entity.HasKey(e => e.ERID).HasFillFactor(100);

            entity.ToTable(tb => tb.HasTrigger("TR_EntityRelationships"));

            entity.HasIndex(e => new { e.RelationshipID, e.subsid_id }, "MT_EntityRelationships_RelationshipID_subsidID").HasFillFactor(100);
        });

        modelBuilder.Entity<MT_EntityType>(entity =>
        {
            entity.HasKey(e => e.ETID).HasFillFactor(100);

            entity.ToTable("MT_EntityType", tb => tb.HasTrigger("TR_EntityType"));

            entity.HasIndex(e => e.ETID, "Index_MT_EntityType_ETID").HasFillFactor(100);
        });

        modelBuilder.Entity<MT_Location>(entity =>
        {
            entity.HasKey(e => e.LID)
                .HasName("PK_MTLocation")
                .HasFillFactor(100);

            entity.ToTable("MT_Location", tb => tb.HasTrigger("TR_Location"));

            entity.HasIndex(e => e.BarCode, "IX_MT_Location")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => e.LID, "Index_MT_Location_LID").HasFillFactor(100);

            entity.HasIndex(e => e.LocationType, "Index_MT_Location_LocationType").HasFillFactor(100);

            entity.HasIndex(e => e.ParentLocation, "Index_MT_Location_ParentLocation").HasFillFactor(100);

            entity.HasIndex(e => new { e.LocationName, e.ParentLocation }, "uq_MT_Location")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasOne(d => d.LocationTypeNavigation).WithMany(p => p.MT_Locations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MT_Location_MT_LocationType");
        });

        modelBuilder.Entity<MT_LocationType>(entity =>
        {
            entity.HasKey(e => e.LTID)
                .HasName("PK_MTLocationType")
                .HasFillFactor(100);

            entity.ToTable("MT_LocationType", tb => tb.HasTrigger("TR_LocationType"));

            entity.HasIndex(e => e.LTID, "MT_LT_LTIDIndex").HasFillFactor(100);
        });

        modelBuilder.Entity<MT_RetentionDateTriggerType>(entity =>
        {
            entity.HasKey(e => e.ID).HasFillFactor(100);

            entity.ToTable("MT_RetentionDateTriggerType", tb => tb.HasTrigger("TR_RetentionDateTriggerType"));

            entity.HasIndex(e => e.ID, "Index_MT_MT_RetentionDateTriggerType_ID").HasFillFactor(100);
        });

        modelBuilder.Entity<MT_RetentionPeriod>(entity =>
        {
            entity.HasKey(e => e.RetentionPeriodID)
                .HasName("PK__MT_RetentionPeri__028315AC")
                .HasFillFactor(100);

            entity.HasIndex(e => e.RetentionPeriod, "UQ__MT_RetentionPeri__037739E5")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasOne(d => d.RetentionPeriodType).WithMany(p => p.MT_RetentionPeriods).HasConstraintName("FK__MT_Retent__Reten__046B5E1E");
        });

        modelBuilder.Entity<MT_RetentionPeriodType>(entity =>
        {
            entity.HasKey(e => e.RetentionPeriodTypeID)
                .HasName("PK__MT_RetentionPeri__7FA6A901")
                .HasFillFactor(100);

            entity.HasIndex(e => e.RetentionPeriodType, "UQ__MT_RetentionPeri__009ACD3A")
                .IsUnique()
                .HasFillFactor(100);
        });

        modelBuilder.Entity<MT_RetentionSchedule>(entity =>
        {
            entity.Property(e => e.RSID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MduMemberDetail>(entity =>
        {
            entity.Property(e => e.GENDERCODE).IsFixedLength();
        });

        modelBuilder.Entity<ProfileUrlTimeout>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RetentionPolicyMapping>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_RetentionPolicyMapping_ID");

            entity.ToTable("RetentionPolicyMapping", tb => tb.HasComment("This describes the active and inactive polices attached to a case."));

            entity.Property(e => e.ActionedDT).HasComment("Marks the case as having been actioned (deleted)");
            entity.Property(e => e.AssignedByUserID).HasComment("The user name that triggered the process that first assigned the policy to the entity. This will typically be the retention engine userID. However if a user action causes the calculation to be done then there userID will be recorded here.");
            entity.Property(e => e.AssignedDT).HasComment("The DT the policy was assigned to the entity");
            entity.Property(e => e.AssingedByProcess).HasComment("The name of the process that first calculated / assigned this policy to the entity. Typically this process will be the retention engine.");
            entity.Property(e => e.EntityID).HasComment("The unique identifier for an entity.  e.g case_id + subsid_id for Pro-File");
            entity.Property(e => e.IsInforcePolicy).HasComment("Whether this policy is the enforce policy for a case.\n\nIMPORTANT, if the IsProvisional flag is true then it this policy is only provisionaly InForce.");
            entity.Property(e => e.IsProvisional).HasComment("Whether this entry is provisional, that is, the entity is not yet in a state for it to fall under retention, but if it were to be at the moment the calculation was done this entry would have been added.\n\nThis filed");
            entity.Property(e => e.PolicyInitialActionDate).HasComment("The date after which the action should be run.");
            entity.Property(e => e.PolicyStartDate).HasComment("The base date used for calculating ActionDate and WarningDate. This is typically when an entity is closed / made inactive / last active");
            entity.Property(e => e.PolicyWarningDate).HasComment("The date the case/policy is in it warning period. This will be calculated as PolicyTimespan+");
            entity.Property(e => e.UnassignedByUserID).HasComment("The user name that triggered the process that caused the policy to be removed from the entity. This will typically be the retention engine userID. However if a user action causes the calculation to be done then there userID will be recorded here.");
            entity.Property(e => e.UnassignedDT).HasComment("If a policy is no longer applicable (whether it was in-force or not) for a case this will be the DT that happened.");
            entity.Property(e => e.UnassingedByProcess).HasComment("The name of the process that caused this policy to be removed from being applicable to the entity. Typically this process will be the retention engine.");
        });

        modelBuilder.Entity<ScriptHistory>(entity =>
        {
            entity.Property(e => e.ScriptRowNumber).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Search_Logging>(entity =>
        {
            entity.HasKey(e => e.ID).HasFillFactor(100);

            entity.Property(e => e.PATISEX).IsFixedLength();
            entity.Property(e => e.PRACDDR).IsFixedLength();
            entity.Property(e => e.PRACLEAD).IsFixedLength();
            entity.Property(e => e.SUBS_ID).IsFixedLength();
        });

        modelBuilder.Entity<StageofInvestication>(entity =>
        {
            entity.HasKey(e => e.Investication_Id).HasName("Pk_StageofInvestication_Investication_Id");
        });

        modelBuilder.Entity<TBLFunding>(entity =>
        {
            entity.HasKey(e => new { e.Case_ID, e.Sub_ID }).HasFillFactor(100);

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Sub_ID).IsFixedLength();
            entity.Property(e => e.ATE_New_ExpertRpt).IsFixedLength();
        });

        modelBuilder.Entity<TBLQUARTERLYREPORTCLAIM>(entity =>
        {
            entity.ToTable("TBLQUARTERLYREPORTCLAIMS", tb => tb.HasTrigger("TR_TblQuarterlyReportClaims"));

            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUB_ID).IsFixedLength();
        });

        modelBuilder.Entity<TBLQUARTERLYREPORTCLAIMS_A>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.EVENT).IsFixedLength();
            entity.Property(e => e.SUB_ID).IsFixedLength();
        });

        modelBuilder.Entity<TBLSUBDEPARTMENT>(entity =>
        {
            entity.HasKey(e => e.Sub_Dept_ID).HasName("PK_TBLSUBDEPARTMENT_Sub_Dept_ID");

            entity.Property(e => e.Sub_Dept_ID).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
        });

        modelBuilder.Entity<TBLSUBDEPARTMENT_MAPPING>(entity =>
        {
            entity.HasKey(e => new { e.Sub_Dept_ID, e.Parent_Dept_ID }).HasName("PK_TBLSUBDEPARTMENT_MAPPING_Sub_Dept_ID");

            entity.Property(e => e.Sub_Dept_ID).IsFixedLength();
            entity.Property(e => e.Parent_Dept_ID).IsFixedLength();

            entity.HasOne(d => d.Parent_Dept).WithMany(p => p.TBLSUBDEPARTMENT_MAPPINGs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBLSUBDEPARTMENT_MAPPING_Department");
        });

        modelBuilder.Entity<TBLWITNESS>(entity =>
        {
            entity.HasKey(e => e.WitnessId)
                .HasName("PK__TBLWITNESS__37FD3AD2")
                .HasFillFactor(100);

            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Sex).IsFixedLength();
            entity.Property(e => e.Sub_Id).IsFixedLength();
        });

        modelBuilder.Entity<TEMP1>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPCRCY>(entity =>
        {
            entity.Property(e => e.CRCYCODE).IsFixedLength();
            entity.Property(e => e.CRCYDESC).IsFixedLength();
        });

        modelBuilder.Entity<TEMPRANKING>(entity =>
        {
            entity.Property(e => e.MILESSORTORDER).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLANDSUMM>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLCURRENTRESULT>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLFINAL>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLINTRESULT>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLINTRESULT1>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLNOTSUMM>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLORSUMM>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLRESULTKEY>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<TEMPTBLRESULTSUMM>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID_ID).IsFixedLength();
        });

        modelBuilder.Entity<T_Invoice>(entity =>
        {
            entity.Property(e => e.BPR).IsFixedLength();
            entity.Property(e => e.BPRPay).IsFixedLength();
            entity.Property(e => e.BPRVCR).IsFixedLength();
            entity.Property(e => e.PTE).IsFixedLength();
            entity.Property(e => e.YcaseId).IsFixedLength();
            entity.Property(e => e.Yledprac).IsFixedLength();
            entity.Property(e => e.Yprofinref).IsFixedLength();
        });

        modelBuilder.Entity<TblAdvCaseProgress>(entity =>
        {
            entity.ToTable("TblAdvCaseProgress", tb => tb.HasTrigger("TR_TBLADVCASEPROGRESS"));

            entity.HasIndex(e => new { e.Case_ID, e.Subsid_ID }, "IX_TbladvcaseProgress_1").HasFillFactor(100);

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.Subsid_ID).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblAdvCaseProgress_a>(entity =>
        {
            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Subsid_ID).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblAdvProgEvent>(entity =>
        {
            entity.HasKey(e => new { e.Adv_Type_id, e.Adv_Event_Id }).HasFillFactor(100);

            entity.Property(e => e.Adv_Event_Desc).IsFixedLength();
            entity.Property(e => e.Keyword).IsFixedLength();
        });

        modelBuilder.Entity<TblAdvProgType>(entity =>
        {
            entity.HasKey(e => e.Adv_Type_ID).HasFillFactor(100);

            entity.Property(e => e.Adv_Type_ID).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Adv_Type_Desc).IsFixedLength();
            entity.Property(e => e.Sub_Dept_ID).IsFixedLength();

            entity.HasOne(d => d.Sub_Dept).WithMany(p => p.TblAdvProgTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblAdvProgType_TBLSUBDEPARTMENT");
        });

        modelBuilder.Entity<TblBackCaseId>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
        });

        modelBuilder.Entity<TblBarAssignment>(entity =>
        {
            entity.ToTable("TblBarAssignment", tb => tb.HasTrigger("TR_TBLBARASSIGNMENT"));

            entity.HasIndex(e => new { e.Case_Id, e.Subsid_Id }, "IX_TblBarAssignment1").HasFillFactor(100);

            entity.HasIndex(e => e.Barrister_ID, "IX_TblBarAssignment2").HasFillFactor(100);

            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblBarAssignment_a>(entity =>
        {
            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblBarrister>(entity =>
        {
            entity.HasKey(e => e.Barrister_ID).HasFillFactor(100);

            entity.Property(e => e.Valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<TblBenefitHistory>(entity =>
        {
            entity.HasKey(e => e.History_id).HasFillFactor(100);
        });

        modelBuilder.Entity<TblCCA>(entity =>
        {
            entity.HasKey(e => e.cca_id).HasFillFactor(100);

            entity.ToTable("TblCCA", tb => tb.HasTrigger("TR_TBLCCA"));

            entity.Property(e => e.TELEPHONE1).IsFixedLength();
            entity.Property(e => e.TELEPHONE2).IsFixedLength();
            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.country).IsFixedLength();
            entity.Property(e => e.email).IsFixedLength();
            entity.Property(e => e.extn).IsFixedLength();
            entity.Property(e => e.fax).IsFixedLength();
            entity.Property(e => e.first_name).IsFixedLength();
            entity.Property(e => e.home_tel).IsFixedLength();
            entity.Property(e => e.initial).IsFixedLength();
            entity.Property(e => e.last_name).IsFixedLength();
            entity.Property(e => e.mobile).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
            entity.Property(e => e.work_tel).IsFixedLength();
        });

        modelBuilder.Entity<TblCCA_a>(entity =>
        {
            entity.Property(e => e.TELEPHONE1).IsFixedLength();
            entity.Property(e => e.TELEPHONE2).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.country).IsFixedLength();
            entity.Property(e => e.email).IsFixedLength();
            entity.Property(e => e.extn).IsFixedLength();
            entity.Property(e => e.fax).IsFixedLength();
            entity.Property(e => e.first_name).IsFixedLength();
            entity.Property(e => e.home_tel).IsFixedLength();
            entity.Property(e => e.initial).IsFixedLength();
            entity.Property(e => e.last_name).IsFixedLength();
            entity.Property(e => e.mobile).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
            entity.Property(e => e.work_tel).IsFixedLength();
        });

        modelBuilder.Entity<TblCCAaddr>(entity =>
        {
            entity.HasKey(e => new { e.Cca_id, e.Addr_id }).HasFillFactor(100);

            entity.ToTable("TblCCAaddr", tb => tb.HasTrigger("TR_TBLCCAADDR"));

            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.country).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.prefered).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCCAaddr_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.country).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.prefered).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCancelationDetail>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_TBLCANCELATIONDETAILS"));

            entity.HasIndex(e => e.Meeting_ID, "IX_TblCancelationDetails")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.Cancellation_reason).IsFixedLength();
            entity.Property(e => e.Cancellation_text).IsFixedLength();
            entity.Property(e => e.User_ID).IsFixedLength();
        });

        modelBuilder.Entity<TblCancelationDetails_a>(entity =>
        {
            entity.Property(e => e.Cancellation_reason).IsFixedLength();
            entity.Property(e => e.Cancellation_text).IsFixedLength();
            entity.Property(e => e.User_ID).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
        });

        modelBuilder.Entity<TblCaseHandlingNote>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("TblCaseHandlingNote", tb => tb.HasTrigger("TR_CaseHandlingNote"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCaseHandlingNote_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCaseResbreakdown>(entity =>
        {
            entity.ToTable("TblCaseResbreakdown", tb => tb.HasTrigger("TR_TBLCASERESBREAKDOWN"));

            entity.HasIndex(e => new { e.Case_ID, e.Subsid_ID }, "IX_TblCaseResbreakdown_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Probability).IsFixedLength();
            entity.Property(e => e.RsrvFlag).IsFixedLength();
            entity.Property(e => e.Subsid_ID).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCaseResbreakdown_241396>(entity =>
        {
            entity.Property(e => e.Probability).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCaseResbreakdown_A_Audit>(entity =>
        {
            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Probability).IsFixedLength();
            entity.Property(e => e.RsrvFlag).IsFixedLength();
            entity.Property(e => e.Subsid_ID).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblCaseResbreakdown_a>(entity =>
        {
            entity.ToTable("TblCaseResbreakdown_a", tb => tb.HasTrigger("TR_TBLCASERESBREAKDOWN_A"));

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Probability).IsFixedLength();
            entity.Property(e => e.RsrvFlag).IsFixedLength();
            entity.Property(e => e.Subsid_ID).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblChamber>(entity =>
        {
            entity.HasKey(e => e.Chambers_Id).HasFillFactor(100);

            entity.Property(e => e.Valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<TblClosingSummary>(entity =>
        {
            entity.ToTable("TblClosingSummary", tb => tb.HasTrigger("TR_TBLCLOSINGSUMMARY"));

            entity.HasIndex(e => new { e.Case_ID, e.Sub_ID }, "IX_TblClosingSummary_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.FileDestroyed_Reason).IsFixedLength();
            entity.Property(e => e.Sub_ID).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblClosingSummary_a>(entity =>
        {
            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.FileDestroyed_Reason).IsFixedLength();
            entity.Property(e => e.Sub_ID).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblDDRCoverType>(entity =>
        {
            entity.Property(e => e.CoverDescription).IsFixedLength();
            entity.Property(e => e.Cover_type).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
        });

        modelBuilder.Entity<TblDentalSpclty>(entity =>
        {
            entity.Property(e => e.Dental_spclty).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<TblDiscretionaryReason>(entity =>
        {
            entity.Property(e => e.DiscReason_Desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<TblDuplicatePayReason>(entity =>
        {
            entity.Property(e => e.PayReason_Desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<TblExpert>(entity =>
        {
            entity.ToTable("TblExpert", tb => tb.HasTrigger("TR_TBLEXPERT"));

            entity.HasIndex(e => e.Expert_id, "IX_TblExpert_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.DataControlPolicy)
                .HasDefaultValue("0")
                .IsFixedLength();
            entity.Property(e => e.Expert_id).ValueGeneratedOnAdd();
            entity.Property(e => e.First_Name).IsFixedLength();
            entity.Property(e => e.Last_Name).IsFixedLength();
            entity.Property(e => e.PAYEE_CODE).IsFixedLength();
            entity.Property(e => e.PAYEE_NAME).IsFixedLength();
            entity.Property(e => e.Street).IsFixedLength();
            entity.Property(e => e.Tariff_terms).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.VATCharged).IsFixedLength();
            entity.Property(e => e.Valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.county).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertAdultSpclty>(entity =>
        {
            entity.HasIndex(e => new { e.Expert_id, e.Adult_spclty_id }, "IX_TblExpertAdultSpclty_1").HasFillFactor(100);

            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertContType>(entity =>
        {
            entity.HasKey(e => e.Expert_Cont_Type_Id).HasFillFactor(100);

            entity.Property(e => e.Expert_Cont_type).IsFixedLength();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<TblExpertContact_a>(entity =>
        {
            entity.Property(e => e.Contact_Dtls).IsFixedLength();
            entity.Property(e => e.Expert_id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertDentalSpclty>(entity =>
        {
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertPaedSpclty>(entity =>
        {
            entity.HasIndex(e => new { e.Expert_id, e.Paed_spclty_id }, "IX_TblExpertPaedSpclty_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertReport>(entity =>
        {
            entity.HasKey(e => new { e.Report_ID, e.Expert_id }).HasFillFactor(100);

            entity.ToTable("TblExpertReport", tb => tb.HasTrigger("TR_TBLEXPERTREPORT"));

            entity.HasIndex(e => new { e.Case_id, e.Subsid_id }, "IX_TblExpertReport_1").HasFillFactor(100);

            entity.Property(e => e.Report_ID).ValueGeneratedOnAdd();
            entity.Property(e => e.Accepted_tariff).IsFixedLength();
            entity.Property(e => e.Case_Handler).IsFixedLength();
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Comments).IsFixedLength();
            entity.Property(e => e.Instruction_type).IsFixedLength();
            entity.Property(e => e.Instruction_type2).IsFixedLength();
            entity.Property(e => e.Instruction_type3).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.User_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertReport_a>(entity =>
        {
            entity.Property(e => e.Accepted_tariff).IsFixedLength();
            entity.Property(e => e.Case_Handler).IsFixedLength();
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Comments).IsFixedLength();
            entity.Property(e => e.Expert_id).IsFixedLength();
            entity.Property(e => e.Instruction_type).IsFixedLength();
            entity.Property(e => e.Instruction_type2).IsFixedLength();
            entity.Property(e => e.Instruction_type3).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.User_id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
        });

        modelBuilder.Entity<TblExpertVATCharged>(entity =>
        {
            entity.HasKey(e => e.VATID).HasName("PK_VATID");
        });

        modelBuilder.Entity<TblExpert_EngagementStatus>(entity =>
        {
            entity.HasKey(e => e.Engagement_Id).HasName("PK_ExpertEngagementId");
        });

        modelBuilder.Entity<TblExpert_a>(entity =>
        {
            entity.Property(e => e.DataControlPolicy).IsFixedLength();
            entity.Property(e => e.Expert_id).IsFixedLength();
            entity.Property(e => e.First_Name).IsFixedLength();
            entity.Property(e => e.Last_Name).IsFixedLength();
            entity.Property(e => e.PAYEE_CODE).IsFixedLength();
            entity.Property(e => e.PAYEE_NAME).IsFixedLength();
            entity.Property(e => e.Street).IsFixedLength();
            entity.Property(e => e.Tariff_terms).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.VATCharged).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.county).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExpert_bck>(entity =>
        {
            entity.Property(e => e.DataControlPolicy).IsFixedLength();
            entity.Property(e => e.Expert_id).ValueGeneratedOnAdd();
            entity.Property(e => e.First_Name).IsFixedLength();
            entity.Property(e => e.Last_Name).IsFixedLength();
            entity.Property(e => e.PAYEE_CODE).IsFixedLength();
            entity.Property(e => e.PAYEE_NAME).IsFixedLength();
            entity.Property(e => e.Street).IsFixedLength();
            entity.Property(e => e.Tariff_terms).IsFixedLength();
            entity.Property(e => e.Title).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.county).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExtSol>(entity =>
        {
            entity.HasKey(e => e.Ext_Sol_Code).HasFillFactor(100);

            entity.ToTable("TblExtSol", tb => tb.HasTrigger("TR_TBLEXTSOL"));

            entity.Property(e => e.Ext_Sol_Code).ValueGeneratedNever();
            entity.Property(e => e.PAYEE_CODE).IsFixedLength();
            entity.Property(e => e.PAYEE_NAME).IsFixedLength();
            entity.Property(e => e.Valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblExtSolAssignment_a>(entity =>
        {
            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Fixed_Costs).HasDefaultValue(false);
            entity.Property(e => e.Subsid_Id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
        });

        modelBuilder.Entity<TblExtSol_a>(entity =>
        {
            entity.Property(e => e.PAYEE_CODE).IsFixedLength();
            entity.Property(e => e.PAYEE_NAME).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblFinding>(entity =>
        {
            entity.HasIndex(e => e.Finding_id, "IX_TblFindings_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.Finding_desc).IsFixedLength();
            entity.Property(e => e.Finding_id).ValueGeneratedOnAdd();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<TblGroupType>(entity =>
        {
            entity.HasKey(e => e.group_type).HasFillFactor(100);

            entity.Property(e => e.group_type).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<TblHighValueReview>(entity =>
        {
            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
        });

        modelBuilder.Entity<TblHighValueReview_a>(entity =>
        {
            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Event).IsFixedLength();
            entity.Property(e => e.Subsid_Id).IsFixedLength();
        });

        modelBuilder.Entity<TblKeyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Keyword");

            entity.ToTable("TblKeyword", tb => tb.HasTrigger("TR_Keyword"));

            entity.Property(e => e.ModifiedBy).IsFixedLength();
        });

        modelBuilder.Entity<TblKeyword_a>(entity =>
        {
            entity.HasKey(e => e.AuditId).HasName("PK_Keyword_a");

            entity.Property(e => e.Event).IsFixedLength();
            entity.Property(e => e.ModifiedBy).IsFixedLength();
        });

        modelBuilder.Entity<TblLegalReportDatum>(entity =>
        {
            entity.HasKey(e => e.DESC_ID).HasName("PK__TblLegal__A734D7015C470D23");
        });

        modelBuilder.Entity<TblMeetingRequest>(entity =>
        {
            entity.HasKey(e => e.meeting_id).HasFillFactor(100);

            entity.ToTable("TblMeetingRequest", tb => tb.HasTrigger("TR_TBLMEETINGREQUEST"));

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "IX_TblMeetingRequest_1").HasFillFactor(100);

            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.arranged_by).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.county).IsFixedLength();
            entity.Property(e => e.on_behalf_of).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.town).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<TblMeetingRequest_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.arranged_by).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.county).IsFixedLength();
            entity.Property(e => e.on_behalf_of).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.town).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<TblMeetingType>(entity =>
        {
            entity.HasKey(e => e.Meeting_Type_ID).HasFillFactor(100);

            entity.Property(e => e.Meeting_Type).IsFixedLength();
            entity.Property(e => e.Valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<TblPhysicalItem>(entity =>
        {
            entity.HasKey(e => new { e.PhysicalItem_Id, e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable(tb => tb.HasTrigger("TR_PhysicalItems"));

            entity.Property(e => e.PhysicalItem_Id).ValueGeneratedOnAdd();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.Return).HasDefaultValue(false);
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblPhysicalItems_a>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblPostcodeLL>(entity =>
        {
            entity.HasIndex(e => e.Postcode, "IX_TblPostCodeLL_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.Postcode).IsFixedLength();
        });

        modelBuilder.Entity<TblPotCaseKeyword_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pot_keyword).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblQuarterlyReportDataMapping>(entity =>
        {
            entity.HasKey(e => e.SDN_ID).HasName("PK_TblQuarterlyReportDataMapping_SDN_ID");

            entity.HasOne(d => d.FDN).WithMany(p => p.TblQuarterlyReportDataMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblQuarterlyReportDataMapping_FDN_ID");
        });

        modelBuilder.Entity<TblQuarterlyReportDatum>(entity =>
        {
            entity.HasKey(e => e.FDN_ID).HasName("PK_TblQuarterlyReportData_FDN_ID");

            entity.HasOne(d => d.DESC).WithMany(p => p.TblQuarterlyReportData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TblQuarterlyReportData_DESC_ID");
        });

        modelBuilder.Entity<TblQuarterlyReportGDC>(entity =>
        {
            entity.ToTable("TblQuarterlyReportGDC", tb => tb.HasTrigger("TR_TblQuarterlyReportGDC"));

            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUB_ID).IsFixedLength();
        });

        modelBuilder.Entity<TblQuarterlyReportGDC_A>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.EVENT).IsFixedLength();
            entity.Property(e => e.SUB_ID).IsFixedLength();
        });

        modelBuilder.Entity<TblQuarterlyReportGMC>(entity =>
        {
            entity.ToTable("TblQuarterlyReportGMC", tb => tb.HasTrigger("TR_TblQuarterlyReportGMC"));

            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.DATE_LAST_UPDATED).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SUB_ID).IsFixedLength();
        });

        modelBuilder.Entity<TblQuarterlyReportGMC_A>(entity =>
        {
            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.DATE_LAST_UPDATED).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Event).IsFixedLength();
            entity.Property(e => e.SUB_ID).IsFixedLength();
        });

        modelBuilder.Entity<TblReallocation_a>(entity =>
        {
            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Staff_from).IsFixedLength();
            entity.Property(e => e.Staff_to).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblReleaseInfo>(entity =>
        {
            entity.Property(e => e.Enable)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy).IsFixedLength();
        });

        modelBuilder.Entity<TblSearchResFld>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_TBLSEARCHRESFLDS"));

            entity.HasIndex(e => e.STAFF_ID, "IX_TblSearchResFlds_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.STAFF_ID).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblSearchResFlds_a>(entity =>
        {
            entity.Property(e => e.IHL_LEGALINSTRUCTION_ACTIVE).HasDefaultValue(false);
            entity.Property(e => e.Latest_Correspondance).HasDefaultValue(false);
            entity.Property(e => e.STAFF_ID).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<TblTariff_Code>(entity =>
        {
            entity.Property(e => e.Tariff_code_Description).IsFixedLength();
        });

        modelBuilder.Entity<TblTempCCA>(entity =>
        {
            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.cca_id).ValueGeneratedOnAdd();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.country).IsFixedLength();
            entity.Property(e => e.email).IsFixedLength();
            entity.Property(e => e.extn).IsFixedLength();
            entity.Property(e => e.fax).IsFixedLength();
            entity.Property(e => e.first_name).IsFixedLength();
            entity.Property(e => e.home_tel).IsFixedLength();
            entity.Property(e => e.initial).IsFixedLength();
            entity.Property(e => e.last_name).IsFixedLength();
            entity.Property(e => e.mobile).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
            entity.Property(e => e.work_tel).IsFixedLength();
        });

        modelBuilder.Entity<TblTemplateForCase>(entity =>
        {
            entity.ToTable("TblTemplateForCase", tb => tb.HasTrigger("TR_TblTemplateForCase_Audit"));

            entity.Property(e => e.TemplateID).ValueGeneratedOnAdd();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<TblTemplateForCase_Audit>(entity =>
        {
            entity.Property(e => e.AuditAction).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<TblTmpccaaddr>(entity =>
        {
            entity.Property(e => e.User_Id).IsFixedLength();
            entity.Property(e => e.address1).IsFixedLength();
            entity.Property(e => e.address2).IsFixedLength();
            entity.Property(e => e.address3).IsFixedLength();
            entity.Property(e => e.city).IsFixedLength();
            entity.Property(e => e.country).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.prefered).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
        });

        modelBuilder.Entity<TblType>(entity =>
        {
            entity.HasKey(e => e.Type_id).HasFillFactor(100);
        });

        modelBuilder.Entity<Tbl_ConfltSerHist>(entity =>
        {
            entity.Property(e => e.Hist_id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Tbl_Fund_SettlementType>(entity =>
        {
            entity.HasKey(e => e.CostId).HasName("PK_CostSettlementID");
        });

        modelBuilder.Entity<Tbl_Rsrv_HvrHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(100);

            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Sub_Id).IsFixedLength();
        });

        modelBuilder.Entity<TbladultSpclty>(entity =>
        {
            entity.HasKey(e => e.Adult_spclty_id).HasFillFactor(100);

            entity.Property(e => e.Adult_spclty).IsFixedLength();
            entity.Property(e => e.Valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<Tblcasekeyword>(entity =>
        {
            entity.ToTable("Tblcasekeyword", tb => tb.HasTrigger("TR_TBLCASEKEYWORD"));

            entity.HasIndex(e => e.Rowid, "IX_Tblcasekeyword")
                .IsUnique()
                .IsClustered()
                .HasFillFactor(100);

            entity.HasIndex(e => e.keyword, "IX_Tblcasekeyword_1").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "IX_Tblcasekeyword_2").HasFillFactor(100);

            entity.Property(e => e.Rowid).ValueGeneratedOnAdd();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblcasekeyword_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tbldisbursementtemp>(entity =>
        {
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Invoice_Id).ValueGeneratedOnAdd();
            entity.Property(e => e.pc_type).IsFixedLength();
            entity.Property(e => e.sub_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblexpensebatch>(entity =>
        {
            entity.HasKey(e => e.Exp_Batch_ID).HasFillFactor(100);

            entity.ToTable("Tblexpensebatch", tb => tb.HasTrigger("TR_TBLEXPENSEBATCH"));

            entity.Property(e => e.Exp_Batch_ID).ValueGeneratedNever();
            entity.Property(e => e.created_by).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblexpensebatch_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.created_by).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblexpensedtl>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_TBLEXPENSEDTLS"));

            entity.HasIndex(e => new { e.Case_id, e.Subsid_id }, "IX_TblExpensedtls_1").HasFillFactor(100);

            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Reference).IsFixedLength();
            entity.Property(e => e.Staff).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblexpensedtls_a>(entity =>
        {
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Reference).IsFixedLength();
            entity.Property(e => e.Staff).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblexpertcontact>(entity =>
        {
            entity.HasKey(e => new { e.Expert_id, e.Exp_Cont_id }).HasFillFactor(100);

            entity.ToTable("Tblexpertcontact", tb => tb.HasTrigger("TR_TBLEXPERTCONTACT"));

            entity.HasIndex(e => new { e.Expert_id, e.Exp_Cont_id }, "IX_TblExpertContact_1")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.Contact_Dtls).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblextsolassignment>(entity =>
        {
            entity.ToTable("Tblextsolassignment", tb => tb.HasTrigger("TR_TBLEXTSOLASSIGNMENT"));

            entity.HasIndex(e => new { e.Case_Id, e.Subsid_Id }, "IX_TblExtSolAssignment_1").HasFillFactor(100);

            entity.HasIndex(e => e.Ext_Sol_Code, "IX_TblExtSolAssignment_2").HasFillFactor(100);

            entity.HasIndex(e => new { e.Case_Id, e.Subsid_Id, e.Ext_Sol_Code }, "_dta_index_Tblextsolassignment_12_789577851__K1_K2_K3_6").HasFillFactor(100);

            entity.HasIndex(e => new { e.Ext_Sol_Code, e.Case_Id, e.Subsid_Id }, "_dta_index_Tblextsolassignment_12_789577851__K3_K1_K2_6").HasFillFactor(100);

            entity.HasIndex(e => new { e.Case_Id, e.Subsid_Id }, "_dta_index_Tblextsolassignment_c_12_789577851__K1_K2")
                .IsClustered()
                .HasFillFactor(100);

            entity.Property(e => e.Case_Id).IsFixedLength();
            entity.Property(e => e.Fixed_Costs).HasDefaultValue(false);
            entity.Property(e => e.Subsid_Id).IsFixedLength();
        });

        modelBuilder.Entity<TblpaediatricSpclty>(entity =>
        {
            entity.HasKey(e => e.Paed_spclty_id).HasFillFactor(100);

            entity.Property(e => e.Paed_splty).IsFixedLength();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<Tblpotcasekeyword>(entity =>
        {
            entity.ToTable("Tblpotcasekeyword", tb => tb.HasTrigger("TR_TBLPOTCASEKEYWORD"));

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "IX_TblPotCaseKeyword_1").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pot_keyword).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblreallocation>(entity =>
        {
            entity.ToTable("Tblreallocation", tb => tb.HasTrigger("TR_TBLREALLOCATION"));

            entity.HasIndex(e => new { e.Case_ID, e.Subsid_id }, "IX_TblReallocation_1").HasFillFactor(100);

            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Staff_from).IsFixedLength();
            entity.Property(e => e.Staff_to).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblrecoverybatch>(entity =>
        {
            entity.HasKey(e => e.Recvr_Batch_ID).HasFillFactor(100);

            entity.ToTable("Tblrecoverybatch", tb => tb.HasTrigger("TR_Tblrecoverybatch"));

            entity.Property(e => e.Recvr_Batch_ID).ValueGeneratedNever();
            entity.Property(e => e.Created_By).IsFixedLength();
            entity.Property(e => e.Currency).IsFixedLength();
            entity.Property(e => e.Exchange_Rate).IsFixedLength();
            entity.Property(e => e.User_Id).IsFixedLength();
        });

        modelBuilder.Entity<Tblrecoverybatch_a>(entity =>
        {
            entity.HasKey(e => e.ID).HasFillFactor(100);

            entity.Property(e => e.Currency).IsFixedLength();
            entity.Property(e => e.Exchange_Rate).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.created_by).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblrecoverydtl>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_Tblrecoverydtls"));

            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Recovery_Type).IsFixedLength();
            entity.Property(e => e.Reference).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblrecoverydtls_Temp>(entity =>
        {
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Recovery_Type).IsFixedLength();
            entity.Property(e => e.Reference).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblrecoverydtls_a>(entity =>
        {
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Recovery_Type).IsFixedLength();
            entity.Property(e => e.Reference).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tblsechistory>(entity =>
        {
            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "IX_TblSecHistory_1").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.newsec1).IsFixedLength();
            entity.Property(e => e.newsec2).IsFixedLength();
            entity.Property(e => e.newsec3).IsFixedLength();
            entity.Property(e => e.oldsec1).IsFixedLength();
            entity.Property(e => e.oldsec2).IsFixedLength();
            entity.Property(e => e.oldsec3).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<Tbltarrif>(entity =>
        {
            entity.HasKey(e => e.Tarrif_id).HasFillFactor(100);

            entity.Property(e => e.tarrif).IsFixedLength();
            entity.Property(e => e.valid)
                .HasDefaultValue("Y")
                .IsFixedLength();
        });

        modelBuilder.Entity<Tbltempinvoice>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<Temp_Supplier>(entity =>
        {
            entity.Property(e => e.Email1).IsFixedLength();
        });

        modelBuilder.Entity<Transfer_Sage_Logging>(entity =>
        {
            entity.HasKey(e => e.ID).HasFillFactor(100);

            entity.Property(e => e.SUB_ID).IsFixedLength();
            entity.Property(e => e.User_Id).IsFixedLength();
        });

        modelBuilder.Entity<_new>(entity =>
        {
            entity.Property(e => e.function_id).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
        });

        modelBuilder.Entity<activity>(entity =>
        {
            entity.HasKey(e => new { e.activity1, e.dept_id }).HasFillFactor(100);

            entity.Property(e => e.activity1).IsFixedLength();
            entity.Property(e => e.dept_id)
                .HasDefaultValue("LGL")
                .IsFixedLength();
            entity.Property(e => e.activity_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<activity_pt>(entity =>
        {
            entity.HasKey(e => e.activity).HasFillFactor(100);

            entity.Property(e => e.activity).IsFixedLength();
            entity.Property(e => e.activity_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<activity_temp>(entity =>
        {
            entity.Property(e => e.activity).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<adv_team>(entity =>
        {
            entity.HasKey(e => e.Team_Id).HasFillFactor(100);

            entity.Property(e => e.Dept_Id).IsFixedLength();
            entity.Property(e => e.Team).IsFixedLength();
            entity.Property(e => e.TeamADAccount).IsFixedLength();
            entity.Property(e => e.Team_Name).IsFixedLength();
            entity.Property(e => e.Valid).HasDefaultValue(true);
        });

        modelBuilder.Entity<app_authority>(entity =>
        {
            entity.HasKey(e => new { e.staff_id, e.app_id, e.authority_function, e.authority_level })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("app_authority", tb => tb.HasTrigger("TR_APP_AUTHORITY"));

            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.authority_function).IsFixedLength();
            entity.Property(e => e.authority_level).IsFixedLength();
        });

        modelBuilder.Entity<app_authority_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.authority_function).IsFixedLength();
            entity.Property(e => e.authority_level).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
        });

        modelBuilder.Entity<app_function>(entity =>
        {
            entity.HasKey(e => new { e.app_id, e.function_id })
                .HasName("PK__app_function__2022C2A6")
                .HasFillFactor(100);

            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.function_id).IsFixedLength();
            entity.Property(e => e.description).IsFixedLength();
        });

        modelBuilder.Entity<app_function_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.description).IsFixedLength();
            entity.Property(e => e.function_id).IsFixedLength();
        });

        modelBuilder.Entity<app_role>(entity =>
        {
            entity.HasKey(e => new { e.app_id, e.role, e.function_id })
                .HasName("PK__app_role__4B0D20AB")
                .HasFillFactor(100);

            entity.ToTable("app_role", tb => tb.HasTrigger("TR_APP_ROLE"));

            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
            entity.Property(e => e.function_id).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
        });

        modelBuilder.Entity<app_role_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.function_id).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
        });

        modelBuilder.Entity<app_role_bck>(entity =>
        {
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.function_id).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
        });

        modelBuilder.Entity<app_role_hdr>(entity =>
        {
            entity.Property(e => e.department_id).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
            entity.Property(e => e.role_desc).IsFixedLength();
        });

        modelBuilder.Entity<app_role_hdr_bck>(entity =>
        {
            entity.Property(e => e.department_id).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
            entity.Property(e => e.role_desc).IsFixedLength();
        });

        modelBuilder.Entity<app_user>(entity =>
        {
            entity.HasKey(e => new { e.user_id, e.app_id, e.role })
                .HasName("PK__app_user__49C3F6B7")
                .HasFillFactor(100);

            entity.ToTable("app_user", tb => tb.HasTrigger("TR_APP_USER"));

            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
        });

        modelBuilder.Entity<app_user_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<assignment>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.assign_seq_num })
                .HasName("PK__assignment__693CA210")
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("assignment", tb => tb.HasTrigger("TR_ASSIGNMENT"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.legal_code).IsFixedLength();
            entity.Property(e => e.solicitor_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<assignment_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.legal_code).IsFixedLength();
            entity.Property(e => e.solicitor_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<auth_level>(entity =>
        {
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.authority_function).IsFixedLength();
            entity.Property(e => e.authority_level).IsFixedLength();
            entity.Property(e => e.country_code).IsFixedLength();
            entity.Property(e => e.level_desc).IsFixedLength();
            entity.Property(e => e.sort_order).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<auth_level_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.authority_function).IsFixedLength();
            entity.Property(e => e.authority_level).IsFixedLength();
            entity.Property(e => e.country_code).IsFixedLength();
            entity.Property(e => e.last_upd_userid).IsFixedLength();
            entity.Property(e => e.level_desc).IsFixedLength();
        });

        modelBuilder.Entity<basiscase_list>(entity =>
        {
            entity.ToTable("basiscase_list", tb =>
                {
                    tb.HasTrigger("tr_basiscasedelete");
                    tb.HasTrigger("tr_basiscaseinsert");
                    tb.HasTrigger("tr_basiscaseupdate");
                });

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<basiscase_list_at>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.insertdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.updatetype).IsFixedLength();
        });

        modelBuilder.Entity<bkpT_CASE_PRAC>(entity =>
        {
            entity.Property(e => e.CharmPolicyNumber).IsFixedLength();
            entity.Property(e => e.CharmPolicyVersion).IsFixedLength();
            entity.Property(e => e.DDRApplicable).IsFixedLength();
            entity.Property(e => e.DDRCoverType).IsFixedLength();
            entity.Property(e => e.Member_Entitled).IsFixedLength();
            entity.Property(e => e.Transitional_Benefits).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.group_type).IsFixedLength();
            entity.Property(e => e.prac_def_org).IsFixedLength();
            entity.Property(e => e.prac_init).IsFixedLength();
            entity.Property(e => e.prac_role).IsFixedLength();
            entity.Property(e => e.prac_sex).IsFixedLength();
            entity.Property(e => e.prac_tow).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<bsaltiim>(entity =>
        {
            entity.Property(e => e.alt_item).IsFixedLength();
            entity.Property(e => e.item).IsFixedLength();
            entity.Property(e => e.supplier).IsFixedLength();
        });

        modelBuilder.Entity<case_a>(entity =>
        {
            entity.HasIndex(e => new { e.table_name, e.subsid_id, e.case_id }, "_dta_index_case_a_c_12_1189579276__K3_K2_K1")
                .IsClustered()
                .HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.chgd_action).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.table_name).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<casebreak>(entity =>
        {
            entity.Property(e => e.Case_ID).IsFixedLength();
            entity.Property(e => e.Probability).IsFixedLength();
            entity.Property(e => e.RsrvFlag).IsFixedLength();
            entity.Property(e => e.Subsid_ID).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<caseview>(entity =>
        {
            entity.ToView("caseview");

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.prac_def_org).IsFixedLength();
            entity.Property(e => e.prac_init).IsFixedLength();
            entity.Property(e => e.prac_num).IsFixedLength();
            entity.Property(e => e.prac_role).IsFixedLength();
            entity.Property(e => e.prac_sex).IsFixedLength();
            entity.Property(e => e.prac_tow).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<category>(entity =>
        {
            entity.HasKey(e => e.category1).HasFillFactor(100);

            entity.Property(e => e.category1).IsFixedLength();
            entity.Property(e => e.cat_nominal_code).IsFixedLength();
            entity.Property(e => e.description).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<cencurm>(entity =>
        {
            entity.Property(e => e.cheque_lang).IsFixedLength();
            entity.Property(e => e.conv_operator).IsFixedLength();
            entity.Property(e => e.currency_base).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.currency_desc).IsFixedLength();
            entity.Property(e => e.currency_type).IsFixedLength();
            entity.Property(e => e.currency_year).IsFixedLength();
            entity.Property(e => e.frequency).IsFixedLength();
            entity.Property(e => e.round_acct).IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.type_desc).IsFixedLength();
        });

        modelBuilder.Entity<ceratem>(entity =>
        {
            entity.Property(e => e.currency_base).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.currency_type).IsFixedLength();
            entity.Property(e => e.currency_year).IsFixedLength();
            entity.Property(e => e.period).IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.spot_date).IsFixedLength();
        });

        modelBuilder.Entity<cheque_recovery>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.sequence_no })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("cheque_recovery", tb => tb.HasTrigger("TR_CHEQUE_RECOVERY"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.currency).IsFixedLength();
            entity.Property(e => e.recovery_type).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<cheque_recovery_at>(entity =>
        {
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.currency).IsFixedLength();
            entity.Property(e => e.recovery_type).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<country>(entity =>
        {
            entity.HasKey(e => e.country1).HasFillFactor(100);

            entity.Property(e => e.country1).IsFixedLength();
            entity.Property(e => e.ctry_nominal_code).IsFixedLength();
            entity.Property(e => e.currency).IsFixedLength();
            entity.Property(e => e.description).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<cover_type>(entity =>
        {
            entity.HasKey(e => e.cover_type_code).HasFillFactor(100);

            entity.Property(e => e.cover_type_code).IsFixedLength();
            entity.Property(e => e.cover_type_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<department>(entity =>
        {
            entity.HasKey(e => e.dept_id)
                .HasName("PK__department__24E777C3")
                .HasFillFactor(100);

            entity.Property(e => e.dept_id).IsFixedLength();
            entity.Property(e => e.depatAdAccount).IsFixedLength();
            entity.Property(e => e.dept_name).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<destroyfile>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<global_datum>(entity =>
        {
            entity.Property(e => e.bank_code).IsFixedLength();
            entity.Property(e => e.chief_exec).IsFixedLength();
            entity.Property(e => e.master_policy_no).IsFixedLength();
            entity.Property(e => e.mdu_address_1).IsFixedLength();
            entity.Property(e => e.mdu_address_2).IsFixedLength();
            entity.Property(e => e.mdu_address_3).IsFixedLength();
            entity.Property(e => e.mdu_address_4).IsFixedLength();
            entity.Property(e => e.mdu_address_5).IsFixedLength();
            entity.Property(e => e.mem_nominal_code).IsFixedLength();
            entity.Property(e => e.membership_vatc).IsFixedLength();
            entity.Property(e => e.new_std_letters).IsFixedLength();
            entity.Property(e => e.payment_batch).IsFixedLength();
            entity.Property(e => e.system_country).IsFixedLength();
        });

        modelBuilder.Entity<indemnifier>(entity =>
        {
            entity.HasKey(e => e.org).HasFillFactor(100);

            entity.Property(e => e.org).IsFixedLength();
            entity.Property(e => e.org_desc).IsFixedLength();
        });

        modelBuilder.Entity<invoice>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.sequence_no })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("invoice", tb => tb.HasTrigger("TR_INVOICE"));

            entity.HasIndex(e => e.requested_by, "i_invoice1").HasFillFactor(100);

            entity.HasIndex(e => e.mdu_reference, "i_invoice2").HasFillFactor(100);

            entity.HasIndex(e => e.payment_date, "i_invoice3").HasFillFactor(100);

            entity.HasIndex(e => new { e.requested_by, e.pc_type, e.authorised_by, e.case_id, e.subsid_id }, "i_invoice4").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.BANKACCOUNT).IsFixedLength();
            entity.Property(e => e.BANKSORTCODE).IsFixedLength();
            entity.Property(e => e.alpha_code).IsFixedLength();
            entity.Property(e => e.analysis_codes3).IsFixedLength();
            entity.Property(e => e.authorised_by).IsFixedLength();
            entity.Property(e => e.batch_id).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.invoice_status).IsFixedLength();
            entity.Property(e => e.mdu_reference).IsFixedLength();
            entity.Property(e => e.payee).IsFixedLength();
            entity.Property(e => e.pc_type).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.priority).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<invoice_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.alpha_code).IsFixedLength();
            entity.Property(e => e.analysis_codes3).IsFixedLength();
            entity.Property(e => e.authorised_by).IsFixedLength();
            entity.Property(e => e.batch_id).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.invoice_status).IsFixedLength();
            entity.Property(e => e.mdu_reference).IsFixedLength();
            entity.Property(e => e.payee).IsFixedLength();
            entity.Property(e => e.pc_type).IsFixedLength();
            entity.Property(e => e.postcode).IsFixedLength();
            entity.Property(e => e.priority).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<legal_code>(entity =>
        {
            entity.HasKey(e => e.legal_code1)
                .HasName("PK__legal_code__27C3E46E")
                .HasFillFactor(100);

            entity.Property(e => e.legal_code1).IsFixedLength();
            entity.Property(e => e.category).IsFixedLength();
            entity.Property(e => e.legal_code_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<master>(entity =>
        {
            entity.Property(e => e.app_id).IsFixedLength();
            entity.Property(e => e.function_id).IsFixedLength();
            entity.Property(e => e.level).IsFixedLength();
            entity.Property(e => e.role).IsFixedLength();
        });

        modelBuilder.Entity<mdu_liability>(entity =>
        {
            entity.HasKey(e => new { e.case_type, e.mdu_liability1 }).HasFillFactor(100);

            entity.Property(e => e.case_type).IsFixedLength();
            entity.Property(e => e.mdu_liability1).IsFixedLength();
            entity.Property(e => e.liab_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<nljrnm>(entity =>
        {
            entity.Property(e => e.action_indicator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis1)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis2)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis3)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_code10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_freq10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.curr_type10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.dated).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.expiry_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.fix_rate_ind01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fix_rate_ind10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.group_journal)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.hold_indicator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.interco_flag)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.journal_no)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_narrative10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.line_vatcodes10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.multidiv10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.narrative)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nlyear)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.no_of_lines)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_codes10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.page_no)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.period_entered)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.period_indicator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rept_curr_cd10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.revalue_status10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.slash)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.source1)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.source2)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.total_no_of_lines)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.transaction_group)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.transdate).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
        });

        modelBuilder.Entity<paymt_status>(entity =>
        {
            entity.HasKey(e => e.status_code).HasFillFactor(100);

            entity.Property(e => e.status_code).IsFixedLength();
            entity.Property(e => e.status_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<plinvm>(entity =>
        {
            entity.Property(e => e.X3_Upload).IsFixedLength();
            entity.Property(e => e.alpha)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes1)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes2)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes3)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.auth_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.authoriser)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.batch)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.control)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency_operator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency_type)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.dated).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.due_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.effective_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.fixed_rate)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.goods_vat_ind10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.item)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_code10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.job_expense10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.name)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_code10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_desc10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.nominal_vatcode10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.our_reference)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.page_no)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.period)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.plyear)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.posting_ind)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.posting_sel)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.refernce)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.reg_batch)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.reg_status)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.sett_category)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.sett_due_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.sett_due_date2).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.sett_due_date3).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.sett_due_date4).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.short_name)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.supplier)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes01)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes02)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes03)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes04)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes05)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes06)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes07)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes08)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes09)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tax_codes10)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.userdate).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.username)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.usertime)
                .HasDefaultValue(" ")
                .IsFixedLength();
        });

        modelBuilder.Entity<plitemm>(entity =>
        {
            entity.Property(e => e.analysis_codes1)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes2)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes3)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.auth_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.authorisor)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.control)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency_operator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency_type)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.dated).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.disc_sett_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.disc_sett_date2).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.disc_sett_date3).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.disc_sett_date4).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.due_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.effective_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.fixed_rate)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.hold_indicator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.item)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.kind)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.open_indicator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.our_reference)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.period)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.plyear)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.refernce)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.registered)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.sett_category)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.short_name)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.spare)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.supplier)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.supplier_and_date)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.transaction_group)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.userdate).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.username)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.usertime)
                .HasDefaultValue(" ")
                .IsFixedLength();
        });

        modelBuilder.Entity<plsuppm>(entity =>
        {
            entity.Property(e => e.account_type)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.address1)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.address2)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.address3)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.address4)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.address5)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.address6)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.alpha)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes1)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes2)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes3)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes_21)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes_22)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.analysis_codes_23)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.balance_fwd_ind)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.bank_account)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.bank_branch)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.bank_code)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.bank_name)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.bic)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.btx)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.cit_supplier)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.date_created).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.date_last_sale).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.edi_supplier)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.email)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.fax)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.iban)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.letter_code)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.name)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.pay_indicator)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.pay_terms)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.pay_type)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.payment_reference)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.pop_discount_cat)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.price_list)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.sett_category)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.spare)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.special_price_list)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.supplier)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.supplier_category)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.telex)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.tol_check)
                .HasDefaultValue("O")
                .IsFixedLength();
            entity.Property(e => e.transaction_email)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.vat_reg_number)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.vat_type)
                .HasDefaultValue(" ")
                .IsFixedLength();
        });

        modelBuilder.Entity<plxrefm>(entity =>
        {
            entity.HasKey(e => e.unique_no)
                .HasName("PK__plxrefm__4CAF440A")
                .HasFillFactor(100);

            entity.Property(e => e.allocated_date).HasDefaultValueSql("(CONVERT([datetime],'31/12/1899',(103)))");
            entity.Property(e => e.batch_item_no)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.currency_code)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.customer)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.item_type)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.second_ref)
                .HasDefaultValue(" ")
                .IsFixedLength();
            entity.Property(e => e.transaction_item)
                .HasDefaultValue(" ")
                .IsFixedLength();
        });

        modelBuilder.Entity<priority>(entity =>
        {
            entity.HasKey(e => e.priority_code).HasFillFactor(100);

            entity.Property(e => e.priority_code).IsFixedLength();
            entity.Property(e => e.priority_desc).IsFixedLength();
        });

        modelBuilder.Entity<recent_payee>(entity =>
        {
            entity.HasKey(e => new { e.staff_id, e.supplier })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.supplier).IsFixedLength();
        });

        modelBuilder.Entity<report_url>(entity =>
        {
            entity.HasKey(e => e.rpt_url_id).HasFillFactor(100);

            entity.Property(e => e.rpt_url_id).ValueGeneratedNever();
        });

        modelBuilder.Entity<res_hist_net>(entity =>
        {
            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.audit_date_time }, "i_resh_net1").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<reserve_hist>(entity =>
        {
            entity.ToTable("reserve_hist", tb => tb.HasTrigger("TR_RESERVE_HIST"));

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.audit_date_time }, "i_res_hist1").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<reserve_hist_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<review_diary>(entity =>
        {
            entity.ToTable("review_diary", tb => tb.HasTrigger("TR_REVIEW_DIARY"));

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.date_file_request, e.review_date, e.review_type }, "_dta_index_review_diary_12_1605580758__K1_K2_K8_K3_K5_4").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "review_diary_i1").HasFillFactor(100);

            entity.HasIndex(e => e.review_date, "review_diary_i2").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.next_review).IsFixedLength();
            entity.Property(e => e.prac_num).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<review_diary_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.next_review).IsFixedLength();
            entity.Property(e => e.prac_num).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<review_reason>(entity =>
        {
            entity.HasKey(e => e.review_type).HasFillFactor(100);

            entity.Property(e => e.review_type).ValueGeneratedNever();
            entity.Property(e => e.review_delete).IsFixedLength();
            entity.Property(e => e.review_reason1).IsFixedLength();
        });

        modelBuilder.Entity<ri_app_det>(entity =>
        {
            entity.ToTable("ri_app_det", tb =>
                {
                    tb.HasTrigger("DEL_RI_APP_DET");
                    tb.HasTrigger("INS_RI_APP_DET");
                    tb.HasTrigger("UPD_RI_APP_DET");
                });

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.org).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_app_det_a>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.insert_update_delete).IsFixedLength();
            entity.Property(e => e.org).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_batch>(entity =>
        {
            entity.HasKey(e => e.batch_id).HasFillFactor(100);

            entity.ToTable("ri_batch", tb => tb.HasTrigger("TR_RI_BATCH"));

            entity.Property(e => e.batch_id).ValueGeneratedNever();
            entity.Property(e => e.batch_currency).IsFixedLength();
            entity.Property(e => e.batch_ref).IsFixedLength();
            entity.Property(e => e.batch_status).IsFixedLength();
            entity.Property(e => e.batch_user).IsFixedLength();
            entity.Property(e => e.payee_alpha).IsFixedLength();
            entity.Property(e => e.payee_code).IsFixedLength();
            entity.Property(e => e.payee_name).IsFixedLength();
            entity.Property(e => e.priority).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_batch_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.batch_currency).IsFixedLength();
            entity.Property(e => e.batch_ref).IsFixedLength();
            entity.Property(e => e.batch_status).IsFixedLength();
            entity.Property(e => e.batch_user).IsFixedLength();
            entity.Property(e => e.payee_alpha).IsFixedLength();
            entity.Property(e => e.payee_code).IsFixedLength();
            entity.Property(e => e.payee_name).IsFixedLength();
            entity.Property(e => e.priority).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_head>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("ri_head", tb =>
                {
                    tb.HasTrigger("TR_RI_HEAD");
                    tb.HasTrigger("del_ri_head");
                    tb.HasTrigger("ins_ri_head");
                    tb.HasTrigger("upd_ri_head");
                });

            entity.HasIndex(e => e.sol_ref, "i_head2").HasFillFactor(100);

            entity.HasIndex(e => e.requested_by, "i_head3").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_AvH).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_PD).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_PP).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_PPV).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_AvH).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_PD).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_PP).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_PPV).IsFixedLength();
            entity.Property(e => e.State_Claims_Agency).IsFixedLength();
            entity.Property(e => e.authorised_by).IsFixedLength();
            entity.Property(e => e.cond_fee_arrang).IsFixedLength();
            entity.Property(e => e.cond_fee_arrang_ATE).IsFixedLength();
            entity.Property(e => e.cond_fee_arrang_BTE).IsFixedLength();
            entity.Property(e => e.period).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.sol_control_no).IsFixedLength();
            entity.Property(e => e.sol_ref).IsFixedLength();
            entity.Property(e => e.solicitor).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_head_282531>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
        });

        modelBuilder.Entity<ri_head_a>(entity =>
        {
            entity.Property(e => e.Case_Pleaded_AvH).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_PD).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_PP).IsFixedLength();
            entity.Property(e => e.Case_Pleaded_PPV).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_AvH).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_PD).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_PP).IsFixedLength();
            entity.Property(e => e.Prov_of_Settlement_PPV).IsFixedLength();
            entity.Property(e => e.State_Claims_Agency).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.authorised_by).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.cond_fee_arrang).IsFixedLength();
            entity.Property(e => e.cond_fee_arrang_ATE).IsFixedLength();
            entity.Property(e => e.cond_fee_arrang_BTE).IsFixedLength();
            entity.Property(e => e.period).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.sol_control_no).IsFixedLength();
            entity.Property(e => e.sol_ref).IsFixedLength();
            entity.Property(e => e.solicitor).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_leg_det>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid, e.leg_type })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("ri_leg_det", tb => tb.HasTrigger("TR_LEG_DET"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.leg_type).IsFixedLength();
            entity.Property(e => e.leg_other).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_leg_det_a>(entity =>
        {
            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "ari_leg1").HasFillFactor(100);

            entity.Property(e => e.KeyNo).ValueGeneratedOnAdd();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_pay_cat>(entity =>
        {
            entity.HasKey(e => e.pay_cat).HasFillFactor(100);

            entity.Property(e => e.pay_cat).IsFixedLength();
            entity.Property(e => e.old_pay_cat_desc).IsFixedLength();
            entity.Property(e => e.pay_cat_desc).IsFixedLength();
        });

        modelBuilder.Entity<ri_pay_cat2>(entity =>
        {
            entity.HasKey(e => e.pay_type_2).HasFillFactor(100);

            entity.Property(e => e.pay_type_2).IsFixedLength();
            entity.Property(e => e.pay_description).IsFixedLength();
        });

        modelBuilder.Entity<ri_pay_type>(entity =>
        {
            entity.HasKey(e => e.pay_codes).HasFillFactor(100);

            entity.Property(e => e.pay_codes).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.ind_lgl).IsFixedLength();
            entity.Property(e => e.pay_desc).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
            entity.Property(e => e.pay_type_2).IsFixedLength();
            entity.Property(e => e.quantum_reqd).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<ri_pc_det>(entity =>
        {
            entity.ToTable("ri_pc_det", tb => tb.HasTrigger("TR_RI_PC_DET"));

            entity.HasIndex(e => new { e.case_id, e.subsid, e.sequence_no }, "i_pc5").HasFillFactor(100);

            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Sanction).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pc_type).IsFixedLength();
            entity.Property(e => e.reference).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.type).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_pc_det_a>(entity =>
        {
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.EVENT).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pc_type).IsFixedLength();
            entity.Property(e => e.reference).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.type).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_pc_det_temp>(entity =>
        {
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Sanction).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pc_type).IsFixedLength();
            entity.Property(e => e.reference).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.type).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_solictor>(entity =>
        {
            entity.HasKey(e => e.sol_code).HasFillFactor(100);

            entity.Property(e => e.sol_code).IsFixedLength();
            entity.Property(e => e.int_ext).IsFixedLength();
            entity.Property(e => e.sol_name).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<ri_suspend>(entity =>
        {
            entity.ToTable("ri_suspend", tb => tb.HasTrigger("TR_RI_SUSPEND"));

            entity.HasIndex(e => e.batch_id, "i_sus1").HasFillFactor(100);

            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_suspend_a>(entity =>
        {
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.EVENT).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_suspend_temp>(entity =>
        {
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.pay_type).IsFixedLength();
            entity.Property(e => e.requested_by).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_txt>(entity =>
        {
            entity.ToTable("ri_txt", tb => tb.HasTrigger("TR_RI_TXT"));

            entity.HasIndex(e => new { e.case_id, e.subsid }, "i_txt1").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<ri_txt_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<split_reason>(entity =>
        {
            entity.HasKey(e => e.split_reason_code).HasFillFactor(100);

            entity.Property(e => e.split_reason_code).IsFixedLength();
            entity.Property(e => e.split_reason_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<splitcase_list>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
            entity.Property(e => e.processed).IsFixedLength();
            entity.Property(e => e.split_reason).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
        });

        modelBuilder.Entity<staff>(entity =>
        {
            entity.HasKey(e => e.staff_no).HasFillFactor(100);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("staff_del");
                    tb.HasTrigger("staff_ins");
                    tb.HasTrigger("staff_upd");
                });

            entity.HasIndex(e => e.staff_id, "IX_staff")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.staff_id, e.staff_no }, "_dta_index_staff_12_2005582183__K2_K1_3").HasFillFactor(100);

            entity.HasIndex(e => new { e.staff_id, e.staff_no, e.dept_id }, "_dta_index_staff_12_2005582183__K2_K1_K4_3_15").HasFillFactor(100);

            entity.HasIndex(e => e.staff_id, "staff_i")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.staff_no).IsFixedLength();
            entity.Property(e => e.Sub_Dept_ID).IsFixedLength();
            entity.Property(e => e.TaskAllocList).IsFixedLength();
            entity.Property(e => e.adv_mgt).IsFixedLength();
            entity.Property(e => e.auth_casescmte).IsFixedLength();
            entity.Property(e => e.clms_mgt).IsFixedLength();
            entity.Property(e => e.dept_id).IsFixedLength();
            entity.Property(e => e.division).IsFixedLength();
            entity.Property(e => e.issol).IsFixedLength();
            entity.Property(e => e.job_title).IsFixedLength();
            entity.Property(e => e.modified_by).IsFixedLength();
            entity.Property(e => e.office).IsFixedLength();
            entity.Property(e => e.ren_retention).IsFixedLength();
            entity.Property(e => e.secretariat).IsFixedLength();
            entity.Property(e => e.sol_code).IsFixedLength();
            entity.Property(e => e.staff_decor).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.staff_name).IsFixedLength();
            entity.Property(e => e.team).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<staff_a>(entity =>
        {
            entity.Property(e => e.Sub_Dept_ID).IsFixedLength();
            entity.Property(e => e.TaskAllocList).IsFixedLength();
            entity.Property(e => e.adv_mgt).IsFixedLength();
            entity.Property(e => e.auth_casescmte).IsFixedLength();
            entity.Property(e => e.change_type).IsFixedLength();
            entity.Property(e => e.clms_mgt).IsFixedLength();
            entity.Property(e => e.dept_id).IsFixedLength();
            entity.Property(e => e.division).IsFixedLength();
            entity.Property(e => e.issol).IsFixedLength();
            entity.Property(e => e.job_title).IsFixedLength();
            entity.Property(e => e.modified_by).IsFixedLength();
            entity.Property(e => e.office).IsFixedLength();
            entity.Property(e => e.ren_retention).IsFixedLength();
            entity.Property(e => e.secretariat).IsFixedLength();
            entity.Property(e => e.sol_code).IsFixedLength();
            entity.Property(e => e.staff_decor).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.staff_name).IsFixedLength();
            entity.Property(e => e.staff_no).IsFixedLength();
            entity.Property(e => e.team).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<sysdirm>(entity =>
        {
            entity.Property(e => e.description).IsFixedLength();
            entity.Property(e => e.key_value).IsFixedLength();
            entity.Property(e => e.rowstamp)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.system_key).IsFixedLength();
        });

        modelBuilder.Entity<t_Classification>(entity =>
        {
            entity.HasKey(e => e.Clfn_Code).HasFillFactor(100);

            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<t_MissedKPIReason>(entity =>
        {
            entity.HasKey(e => e.MissedKPI_Id).HasName("PK_t_MissedKPIReasons_MissedKPI_Id");

            entity.Property(e => e.MissedKPI_Code).IsFixedLength();
        });

        modelBuilder.Entity<t_ReasonsForMissedKPI>(entity =>
        {
            entity.HasKey(e => e.MissedKPI_Id).HasName("PK_t_ReasonsForMissedKPI_MissedKPI_Id");

            entity.Property(e => e.MissedKPI_Code).IsFixedLength();
        });

        modelBuilder.Entity<t_area>(entity =>
        {
            entity.HasKey(e => e.area_code).HasFillFactor(100);

            entity.Property(e => e.area_code).IsFixedLength();
            entity.Property(e => e.area_desc).IsFixedLength();
            entity.Property(e => e.area_jurisdiction).IsFixedLength();
            entity.Property(e => e.country_code).IsFixedLength();
            entity.Property(e => e.country_group).IsFixedLength();
            entity.Property(e => e.country_unit).IsFixedLength();
            entity.Property(e => e.ctry_nominal_code).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_basis_result>(entity =>
        {
            entity.HasIndex(e => e.owner, "basis_res_1i").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.case_type).IsFixedLength();
            entity.Property(e => e.owner).IsFixedLength();
            entity.Property(e => e.scrt_name).IsFixedLength();
            entity.Property(e => e.spclty_maj_desc).IsFixedLength();
            entity.Property(e => e.subsid).IsFixedLength();
        });

        modelBuilder.Entity<t_case>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case", tb =>
                {
                    tb.HasTrigger("TR_T_CASE");
                    tb.HasTrigger("Tr_Case_status_changes");
                    tb.HasTrigger("del_t_case");
                    tb.HasTrigger("ins_t_case");
                    tb.HasTrigger("upd_t_case");
                    tb.HasTrigger("update_history");
                });

            entity.HasIndex(e => e.fac_postcode, "IX_t_case_1").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.mdu_liability, e.case_stat, e.scrt_usr, e.second_scrt_usr, e.third_scrt_usr }, "_dta_index_t_case_12_2069582411__K1_K2_K29_K5_K6_K31_K37_36").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.YearOfCase }, "_dta_index_t_case_12_2069582411__K1_K2_K39").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.case_type, e.mdu_unit, e.scrt_usr, e.second_scrt_usr, e.third_scrt_usr, e.area_code }, "_dta_index_t_case_12_2069582411__K1_K2_K4_K3_K6_K31_K37_K14_36_40").HasFillFactor(100);

            entity.HasIndex(e => new { e.scrt_usr, e.case_id, e.subsid_id }, "_dta_index_t_case_12_2069582411__K6_K1_K2").HasFillFactor(100);

            entity.HasIndex(e => new { e.scrt_usr, e.case_stat }, "i_case4").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.Case_Document_Status).IsFixedLength();
            entity.Property(e => e.DOI_Status).IsFixedLength();
            entity.Property(e => e.Legal_case_Document_Status).HasDefaultValue("Electronic");
            entity.Property(e => e.area_code).IsFixedLength();
            entity.Property(e => e.case_cat).IsFixedLength();
            entity.Property(e => e.case_class).IsFixedLength();
            entity.Property(e => e.case_notes_avail).IsFixedLength();
            entity.Property(e => e.case_of_int).IsFixedLength();
            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.case_type).IsFixedLength();
            entity.Property(e => e.case_uri).IsFixedLength();
            entity.Property(e => e.clfn_code).IsFixedLength();
            entity.Property(e => e.cru).IsFixedLength();
            entity.Property(e => e.file_class_code).IsFixedLength();
            entity.Property(e => e.first_pg_loc).IsFixedLength();
            entity.Property(e => e.ha_aprvd).IsFixedLength();
            entity.Property(e => e.ha_fpc_name).IsFixedLength();
            entity.Property(e => e.mdu_liability).IsFixedLength();
            entity.Property(e => e.mdu_unit).IsFixedLength();
            entity.Property(e => e.mdureins_hal).IsFixedLength();
            entity.Property(e => e.mfiche_no).IsFixedLength();
            entity.Property(e => e.offc).IsFixedLength();
            entity.Property(e => e.old_case_type).IsFixedLength();
            entity.Property(e => e.prac_area_code).IsFixedLength();
            entity.Property(e => e.prodType).IsFixedLength();
            entity.Property(e => e.pymnt_data_avail).IsFixedLength();
            entity.Property(e => e.redact_case).IsFixedLength();
            entity.Property(e => e.ref_data_avail).IsFixedLength();
            entity.Property(e => e.reins_data_avail).IsFixedLength();
            entity.Property(e => e.scrt_usr).IsFixedLength();
            entity.Property(e => e.second_scrt_usr).IsFixedLength();
            entity.Property(e => e.spclty_maj_code).IsFixedLength();
            entity.Property(e => e.spclty_min_code).IsFixedLength();
            entity.Property(e => e.third_scrt_usr).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_Splt>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_US56053>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.case_uri).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_a>(entity =>
        {
            entity.Property(e => e.DOI_status).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.area_code).IsFixedLength();
            entity.Property(e => e.case_cat).IsFixedLength();
            entity.Property(e => e.case_class).IsFixedLength();
            entity.Property(e => e.case_document_status).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.case_notes_avail).IsFixedLength();
            entity.Property(e => e.case_of_int).IsFixedLength();
            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.case_type).IsFixedLength();
            entity.Property(e => e.case_uri).IsFixedLength();
            entity.Property(e => e.clfn_code).IsFixedLength();
            entity.Property(e => e.cru).IsFixedLength();
            entity.Property(e => e.file_class_code).IsFixedLength();
            entity.Property(e => e.first_pg_loc).IsFixedLength();
            entity.Property(e => e.ha_aprvd).IsFixedLength();
            entity.Property(e => e.ha_fpc_name).IsFixedLength();
            entity.Property(e => e.mdu_liability).IsFixedLength();
            entity.Property(e => e.mdu_unit).IsFixedLength();
            entity.Property(e => e.mdureins_hal).IsFixedLength();
            entity.Property(e => e.mfiche_no).IsFixedLength();
            entity.Property(e => e.offc).IsFixedLength();
            entity.Property(e => e.old_case_type).IsFixedLength();
            entity.Property(e => e.prac_area_code).IsFixedLength();
            entity.Property(e => e.prodType).IsFixedLength();
            entity.Property(e => e.pymnt_data_avail).IsFixedLength();
            entity.Property(e => e.redact_case).IsFixedLength();
            entity.Property(e => e.ref_data_avail).IsFixedLength();
            entity.Property(e => e.reins_data_avail).IsFixedLength();
            entity.Property(e => e.scrt_usr).IsFixedLength();
            entity.Property(e => e.second_scrt_usr).IsFixedLength();
            entity.Property(e => e.spclty_maj_code).IsFixedLength();
            entity.Property(e => e.spclty_min_code).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.third_scrt_usr).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_close>(entity =>
        {
            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "i_case_close").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.prac_chk).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_count>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.office).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_cru>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_cru", tb => tb.HasTrigger("TR_CASE_CRU"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.cru_status).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_cru_at>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.cru_status).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_merge>(entity =>
        {
            entity.HasIndex(e => new { e.subsid_id, e.case_id }, "_dta_index_t_case_merge_c_12_34099162__K2_K1")
                .IsClustered()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "t_case_merge_ix1").HasFillFactor(100);

            entity.HasIndex(e => new { e.merged_case_id, e.merged_subsid_id }, "t_case_merge_ix2").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.merged_case_id).IsFixedLength();
            entity.Property(e => e.merged_subsid_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_mliab_a>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.new_mliab).IsFixedLength();
            entity.Property(e => e.old_mliab).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_prac>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.prac_seq_num })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_prac", tb =>
                {
                    tb.HasTrigger("TR_T_CASE_PRAC");
                    tb.HasTrigger("del_t_c_prac");
                    tb.HasTrigger("ins_t_c_prac");
                    tb.HasTrigger("upd_t_c_prac");
                });

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "_dta_index_t_case_prac_12_66099276__K1_K2_3_6_8").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.prac_role }, "_dta_index_t_case_prac_12_66099276__K1_K2_K4_6_8").HasFillFactor(100);

            entity.HasIndex(e => new { e.subsid_id, e.prac_role, e.case_id }, "_dta_index_t_case_prac_12_66099276__K2_K4_K1_3_6_16").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.prac_role }, "i_case_prac3").HasFillFactor(100);

            entity.HasIndex(e => e.prac_num, "i_case_prac4").HasFillFactor(100);

            entity.HasIndex(e => e.prac_last_name, "i_case_prac5").HasFillFactor(100);

            entity.HasIndex(e => new { e.prac_role, e.case_id, e.subsid_id }, "i_case_prac6").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.CharmPolicyNumber).IsFixedLength();
            entity.Property(e => e.CharmPolicyVersion).IsFixedLength();
            entity.Property(e => e.DDRApplicable).IsFixedLength();
            entity.Property(e => e.DDRCoverType).IsFixedLength();
            entity.Property(e => e.Member_Entitled)
                .HasDefaultValue("U")
                .IsFixedLength();
            entity.Property(e => e.PrivateGPClaims).HasDefaultValue("N");
            entity.Property(e => e.group_type).IsFixedLength();
            entity.Property(e => e.prac_def_org).IsFixedLength();
            entity.Property(e => e.prac_init).IsFixedLength();
            entity.Property(e => e.prac_role).IsFixedLength();
            entity.Property(e => e.prac_sex).IsFixedLength();
            entity.Property(e => e.prac_tow).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_prac_a>(entity =>
        {
            entity.Property(e => e.CharmPolicyNumber).IsFixedLength();
            entity.Property(e => e.CharmPolicyVersion).IsFixedLength();
            entity.Property(e => e.DDRApplicable).IsFixedLength();
            entity.Property(e => e.DDRCoverType).IsFixedLength();
            entity.Property(e => e.Member_Entitled)
                .HasDefaultValue("0")
                .IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.group_type).IsFixedLength();
            entity.Property(e => e.insert_update_delete).IsFixedLength();
            entity.Property(e => e.prac_def_org).IsFixedLength();
            entity.Property(e => e.prac_init).IsFixedLength();
            entity.Property(e => e.prac_role).IsFixedLength();
            entity.Property(e => e.prac_sex).IsFixedLength();
            entity.Property(e => e.prac_tow).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_qtm>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_qtm", tb => tb.HasTrigger("TR_T_CASE_QTM"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_qtm_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_rest>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.usr_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_rest", tb => tb.HasTrigger("TR_CASE_REST"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.usr_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_rest_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_rmk>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable(tb => tb.HasTrigger("TR_CASE_RMKS"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_rmks_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_scan>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_scan", tb => tb.HasTrigger("TR_CASE_SCAN"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.barcode_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_scan_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.barcode_id).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_scrt_a>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.new_scrt).IsFixedLength();
            entity.Property(e => e.old_scrt).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_split>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_split", tb => tb.HasTrigger("TR_t_case_split"));

            entity.HasIndex(e => e.case_id, "_dta_index_t_case_split_12_242099903__K1").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.orig_subsid_id).IsFixedLength();
            entity.Property(e => e.split_reason).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_split_a>(entity =>
        {
            entity.Property(e => e.EventType).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.orig_subsid_id).IsFixedLength();
            entity.Property(e => e.split_reason).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_stat>(entity =>
        {
            entity.HasKey(e => e.case_stat).HasFillFactor(100);

            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.stat_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_case_summ>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_case_summ", tb =>
                {
                    tb.HasTrigger("TR_CASE_SUMM");
                    tb.HasTrigger("del_t_c_summ");
                    tb.HasTrigger("ins_t_c_summ");
                    tb.HasTrigger("upd_t_c_summ");
                });

            entity.HasIndex(e => e.Rowid, "IX_t_case_summ_1")
                .IsUnique()
                .IsClustered()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.Rowid }, "_dta_index_t_case_summ_12_274100017__K2_K3_K1_4").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.Rowid).ValueGeneratedOnAdd();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_summ_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_case_transGender>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_t_case_transGender_id");

            entity.Property(e => e.SubsID).IsFixedLength();
            entity.Property(e => e.caseID).IsFixedLength();
        });

        modelBuilder.Entity<t_case_type>(entity =>
        {
            entity.HasKey(e => e.case_type).HasFillFactor(100);

            entity.Property(e => e.case_type).IsFixedLength();
            entity.Property(e => e.type_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_cmtee>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.cmtee_date, e.cmtee_type, e.sequence_no })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_cmtee", tb =>
                {
                    tb.HasTrigger("TR_CMTEE");
                    tb.HasTrigger("TR_T_CMTEE");
                    tb.HasTrigger("del_t_cmtee");
                    tb.HasTrigger("ins_t_cmtee");
                    tb.HasTrigger("upd_t_cmtee");
                });

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.cmtee_type).IsFixedLength();
            entity.Property(e => e.RecommToTheBOM).IsFixedLength();
            entity.Property(e => e.auth).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn2).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn3).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn4).IsFixedLength();
            entity.Property(e => e.crcy).IsFixedLength();
            entity.Property(e => e.scrt_pres).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_cmtee_a>(entity =>
        {
            entity.Property(e => e.RecommToTheBOM).IsFixedLength();
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.auth).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn2).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn3).IsFixedLength();
            entity.Property(e => e.cmtee_dcsn4).IsFixedLength();
            entity.Property(e => e.cmtee_type).IsFixedLength();
            entity.Property(e => e.crcy).IsFixedLength();
            entity.Property(e => e.scrt_pres).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_cmtee_apptmt>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.cmtee_date, e.cmtee_type, e.sequence_no, e.org }).IsClustered(false);

            entity.ToTable("t_cmtee_apptmt", tb => tb.HasTrigger("TR_CMTEE_APPTMT"));

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.cmtee_type).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_cmtee_apptmt_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.cmtee_type).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_cmtee_dcsn_code>(entity =>
        {
            entity.HasKey(e => e.cmtee_dcsn).HasFillFactor(100);

            entity.Property(e => e.cmtee_dcsn).IsFixedLength();
            entity.Property(e => e.check_cru).IsFixedLength();
            entity.Property(e => e.dcsn_desc).IsFixedLength();
            entity.Property(e => e.full_desc).IsFixedLength();
            entity.Property(e => e.quantum_allowed).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_cmtee_type>(entity =>
        {
            entity.HasKey(e => e.cmtee_type).HasFillFactor(100);

            entity.Property(e => e.cmtee_type).IsFixedLength();
            entity.Property(e => e.cmtee_desc).IsFixedLength();
        });

        modelBuilder.Entity<t_cru_stat>(entity =>
        {
            entity.HasKey(e => e.cru_status)
                .HasName("PK__t_cru_stat__361203C5")
                .HasFillFactor(100);

            entity.Property(e => e.cru_status).IsFixedLength();
            entity.Property(e => e.cru_status_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_def_org>(entity =>
        {
            entity.Property(e => e.def_org).IsFixedLength();
            entity.Property(e => e.def_org_name).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_file_classification>(entity =>
        {
            entity.HasKey(e => e.file_class_code).HasFillFactor(100);

            entity.Property(e => e.file_class_code).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_non_mbr>(entity =>
        {
            entity.HasKey(e => e.gmc_num)
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_non_mbr", tb => tb.HasTrigger("TR_NON_MBR"));

            entity.HasIndex(e => e.last_name, "i_non_mbr2").HasFillFactor(100);

            entity.HasIndex(e => e.nee, "i_non_mbr3").HasFillFactor(100);

            entity.Property(e => e.addr_post_code).IsFixedLength();
            entity.Property(e => e.def_org).IsFixedLength();
            entity.Property(e => e.intls).IsFixedLength();
            entity.Property(e => e.nmbr_tow).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.spclty).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_non_mbr_a>(entity =>
        {
            entity.Property(e => e._event).IsFixedLength();
            entity.Property(e => e.addr_post_code).IsFixedLength();
            entity.Property(e => e.def_org).IsFixedLength();
            entity.Property(e => e.intls).IsFixedLength();
            entity.Property(e => e.nmbr_tow).IsFixedLength();
            entity.Property(e => e.sex).IsFixedLength();
            entity.Property(e => e.spclty).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_offc>(entity =>
        {
            entity.HasKey(e => e.offc).HasFillFactor(100);

            entity.Property(e => e.offc).IsFixedLength();
            entity.Property(e => e.offc_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_prac_area>(entity =>
        {
            entity.HasKey(e => e.prac_area_code).HasFillFactor(100);

            entity.Property(e => e.prac_area_code).IsFixedLength();
            entity.Property(e => e.prac_area_desc).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<t_productType>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK_t_productType_id");

            entity.Property(e => e.prodTypeCode).IsFixedLength();
        });

        modelBuilder.Entity<t_pt_info>(entity =>
        {
            entity.HasKey(e => new { e.case_id, e.subsid_id, e.pt_number })
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("t_pt_info", tb =>
                {
                    tb.HasTrigger("del_t_pt_info");
                    tb.HasTrigger("ins_t_pt_info");
                    tb.HasTrigger("upd_t_pt_info");
                });

            entity.HasIndex(e => e.pt_dob, "IX_t_pt_info_1").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "_dta_index_t_pt_info_12_530100929__K1_K2_4_7_8_26_30").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.pt_number }, "_dta_index_t_pt_info_12_530100929__K1_K2_K3_4").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id, e.pt_number }, "_dta_index_t_pt_info_12_530100929__K1_K2_K3_4_7").HasFillFactor(100);

            entity.HasIndex(e => new { e.pt_number, e.case_id, e.subsid_id }, "_dta_index_t_pt_info_12_530100929__K3_K1_K2_4").HasFillFactor(100);

            entity.HasIndex(e => e.pt_lname, "i_pt_info3").HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.Sanction).IsFixedLength();
            entity.Property(e => e.patient_informed).IsFixedLength();
            entity.Property(e => e.pt_addr_post_code).IsFixedLength();
            entity.Property(e => e.pt_deceased).IsFixedLength();
            entity.Property(e => e.pt_incomplete).IsFixedLength();
            entity.Property(e => e.pt_init).IsFixedLength();
            entity.Property(e => e.pt_lname_init).IsFixedLength();
            entity.Property(e => e.pt_nino).IsFixedLength();
            entity.Property(e => e.pt_sex).IsFixedLength();
            entity.Property(e => e.pt_sol_post_code).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<t_recent_case>(entity =>
        {
            entity.HasKey(e => new { e.staff_id, e.case_id, e.subsid_id }).HasName("pk_HistoryId");
        });

        modelBuilder.Entity<t_role>(entity =>
        {
            entity.HasKey(e => e.role).HasFillFactor(100);

            entity.Property(e => e.role).IsFixedLength();
            entity.Property(e => e.role_desc).IsFixedLength();
        });

        modelBuilder.Entity<t_spclty>(entity =>
        {
            entity.Property(e => e.claims_use).IsFixedLength();
            entity.Property(e => e.mem_use).IsFixedLength();
            entity.Property(e => e.spclty_code).IsFixedLength();
            entity.Property(e => e.spclty_desc).IsFixedLength();
        });

        modelBuilder.Entity<tblCaseDocumentStatus>(entity =>
        {
            entity.Property(e => e.Case_document_status).IsFixedLength();
            entity.Property(e => e.Description).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
        });

        modelBuilder.Entity<tblFileStrategy>(entity =>
        {
            entity.HasKey(e => new { e.CASE_ID, e.SUBSID })
                .HasName("PK__tblFileStrategy__42F37431")
                .HasFillFactor(100);

            entity.ToTable("tblFileStrategy", tb => tb.HasTrigger("Tr_FileStrategy"));

            entity.Property(e => e.CASE_ID).IsFixedLength();
            entity.Property(e => e.SUBSID).IsFixedLength();
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<tblFileStrategyHistory>(entity =>
        {
            entity.HasKey(e => e.id)
                .HasName("PK__tblFileStrategyH__7D01DA4F")
                .HasFillFactor(100);

            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subSid).IsFixedLength();
        });

        modelBuilder.Entity<tblSupActivity>(entity =>
        {
            entity.Property(e => e.activity).IsFixedLength();
            entity.Property(e => e.dept_id).IsFixedLength();
            entity.Property(e => e.valid).IsFixedLength();
        });

        modelBuilder.Entity<tbl_LegalCaseDocumentStatus>(entity =>
        {
            entity.Property(e => e.Description).IsFixedLength();
            entity.Property(e => e.Legal_Case_Document_Status).IsFixedLength();
            entity.Property(e => e.Valid).IsFixedLength();
        });

        modelBuilder.Entity<tbl_cat_mapping>(entity =>
        {
            entity.HasKey(e => e.MappingId).HasName("PK__tbl_cat___8B57819D1F7D7637");
        });

        modelBuilder.Entity<tblexpensedtls_temp>(entity =>
        {
            entity.Property(e => e.Case_id).IsFixedLength();
            entity.Property(e => e.Department).IsFixedLength();
            entity.Property(e => e.Reference).IsFixedLength();
            entity.Property(e => e.Staff).IsFixedLength();
            entity.Property(e => e.Subsid_id).IsFixedLength();
            entity.Property(e => e.currency_code).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<timesheet>(entity =>
        {
            entity.HasKey(e => new { e.staff_id, e.week_end, e.case_id, e.subsid_id, e.work_cat_code, e.week_day, e.order_no }).IsClustered(false);

            entity.ToTable("timesheet", tb => tb.HasTrigger("TR_TIMESHEET"));

            entity.HasIndex(e => new { e.week_end, e.staff_id, e.week_day, e.work_cat_code, e.case_id, e.subsid_id }, "_dta_index_timesheet_12_610101214__K2_K1_K6_K8_K3_K4_7_10").HasFillFactor(100);

            entity.HasIndex(e => new { e.case_id, e.subsid_id }, "timesheet_case_idx").HasFillFactor(100);

            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.work_cat_code).IsFixedLength();
            entity.Property(e => e.order_no).ValueGeneratedOnAdd();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<timesheet_a>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.change_type).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
            entity.Property(e => e.work_cat_code).IsFixedLength();
        });

        modelBuilder.Entity<timesheet_act>(entity =>
        {
            entity.ToTable("timesheet_act", tb => tb.HasTrigger("TR_TIMESHEET_ACT"));

            entity.Property(e => e.activity_code).IsFixedLength();
            entity.Property(e => e.activity_id).IsFixedLength();
            entity.Property(e => e.order_no).ValueGeneratedOnAdd();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<timesheet_act_a>(entity =>
        {
            entity.Property(e => e.activity_code).IsFixedLength();
            entity.Property(e => e.activity_id).IsFixedLength();
            entity.Property(e => e.change_type).IsFixedLength();
            entity.Property(e => e.staff_id).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<update>(entity =>
        {
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.selected).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
        });

        modelBuilder.Entity<vw_ViewLimit1>(entity =>
        {
            entity.ToView("vw_ViewLimit1");

            entity.Property(e => e.Case_Document_Status).IsFixedLength();
            entity.Property(e => e.area_code).IsFixedLength();
            entity.Property(e => e.case_cat).IsFixedLength();
            entity.Property(e => e.case_class).IsFixedLength();
            entity.Property(e => e.case_id).IsFixedLength();
            entity.Property(e => e.case_notes_avail).IsFixedLength();
            entity.Property(e => e.case_of_int).IsFixedLength();
            entity.Property(e => e.case_stat).IsFixedLength();
            entity.Property(e => e.case_type).IsFixedLength();
            entity.Property(e => e.case_uri).IsFixedLength();
            entity.Property(e => e.clfn_code).IsFixedLength();
            entity.Property(e => e.cru).IsFixedLength();
            entity.Property(e => e.file_class_code).IsFixedLength();
            entity.Property(e => e.first_pg_loc).IsFixedLength();
            entity.Property(e => e.ha_aprvd).IsFixedLength();
            entity.Property(e => e.ha_fpc_name).IsFixedLength();
            entity.Property(e => e.mdu_liability).IsFixedLength();
            entity.Property(e => e.mdu_unit).IsFixedLength();
            entity.Property(e => e.mdureins_hal).IsFixedLength();
            entity.Property(e => e.mfiche_no).IsFixedLength();
            entity.Property(e => e.offc).IsFixedLength();
            entity.Property(e => e.old_case_type).IsFixedLength();
            entity.Property(e => e.prac_area_code).IsFixedLength();
            entity.Property(e => e.pymnt_data_avail).IsFixedLength();
            entity.Property(e => e.redact_case).IsFixedLength();
            entity.Property(e => e.ref_data_avail).IsFixedLength();
            entity.Property(e => e.reins_data_avail).IsFixedLength();
            entity.Property(e => e.scrt_usr).IsFixedLength();
            entity.Property(e => e.second_scrt_usr).IsFixedLength();
            entity.Property(e => e.spclty_maj_code).IsFixedLength();
            entity.Property(e => e.spclty_min_code).IsFixedLength();
            entity.Property(e => e.subsid_id).IsFixedLength();
            entity.Property(e => e.third_scrt_usr).IsFixedLength();
            entity.Property(e => e.user_id).IsFixedLength();
        });

        modelBuilder.Entity<weekday>(entity =>
        {
            entity.HasKey(e => e.week_day).HasFillFactor(100);

            entity.Property(e => e.week_day).ValueGeneratedNever();
            entity.Property(e => e.day_name).IsFixedLength();
        });

        modelBuilder.Entity<work_category>(entity =>
        {
            entity.HasKey(e => e.work_cat_code).HasFillFactor(100);

            entity.Property(e => e.work_cat_code).IsFixedLength();
            entity.Property(e => e.billable).IsFixedLength();
            entity.Property(e => e.dept_id).IsFixedLength();
            entity.Property(e => e.work_cat_desc).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
