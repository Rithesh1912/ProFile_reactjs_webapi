using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasmanSln.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_case",
                columns: table => new
                {
                    case_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subsid_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mdu_unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_stat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scrt_usr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    offc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    case_cat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spclty_maj_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    spclty_min_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hptl_loc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ha_fpc_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    area_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_area_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    incdt_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    open_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    close_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    pymnt_data_avail = table.Column<bool>(type: "bit", nullable: true),
                    reins_data_avail = table.Column<bool>(type: "bit", nullable: true),
                    ref_data_avail = table.Column<bool>(type: "bit", nullable: true),
                    case_notes_avail = table.Column<bool>(type: "bit", nullable: true),
                    case_of_int = table.Column<bool>(type: "bit", nullable: true),
                    ha_aprvd = table.Column<bool>(type: "bit", nullable: true),
                    mdureins_hal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mfiche_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first_pg_loc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mdu_liability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    old_case_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    second_scrt_usr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_last_updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    lock_no = table.Column<int>(type: "int", nullable: true),
                    file_class_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shared_case = table.Column<bool>(type: "bit", nullable: true),
                    third_scrt_usr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fac_postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfCase = table.Column<int>(type: "int", nullable: true),
                    redact_case = table.Column<bool>(type: "bit", nullable: true),
                    redact_case_rule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Case_Document_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clfn_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLAIM_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Legal_case_Document_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOI_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Case_Create_Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetentionActionedDT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RetentionActionedPolicyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adv_Close_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    prodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_uri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MissedKPI_Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_case", x => x.case_id);
                });

            migrationBuilder.CreateTable(
                name: "t_case_prac",
                columns: table => new
                {
                    case_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subsid_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_def_org = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_init = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_tow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_invl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prac_seq_num = table.Column<int>(type: "int", nullable: true),
                    date_involved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    date_notified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    date_claim_made = table.Column<DateTime>(type: "datetime2", nullable: true),
                    prac_source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cover_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date_last_updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    lock_no = table.Column<int>(type: "int", nullable: true),
                    DDRApplicable = table.Column<bool>(type: "bit", nullable: true),
                    DDRCoverType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharmPolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharmPolicyVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    group_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    group_num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orgname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disc_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member_Entitled = table.Column<bool>(type: "bit", nullable: true),
                    date_nonirish_claim_made = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProdRefNo_SubSegCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DON_Polselection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Member_Entitled_DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrivateGPClaims = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_case_prac", x => x.case_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_case");

            migrationBuilder.DropTable(
                name: "t_case_prac");
        }
    }
}
