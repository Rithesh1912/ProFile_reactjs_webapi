using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasmanSln.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_adv_team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_adv_team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "t_app_user",
                columns: table => new
                {
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    appId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_app_user", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "t_area",
                columns: table => new
                {
                    AreaDesc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryTax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CtryNominalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortColumn = table.Column<int>(type: "int", nullable: false),
                    AreaJurisdiction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdultLimitationMonths = table.Column<int>(type: "int", nullable: true),
                    ChildrenLimitationMonths = table.Column<int>(type: "int", nullable: true),
                    BrainDamageLimitationMonths = table.Column<int>(type: "int", nullable: true),
                    Valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_area", x => x.AreaDesc);
                });

            migrationBuilder.CreateTable(
                name: "t_case",
                columns: table => new
                {
                    case_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subsid_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mdu_unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    incdt_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    open_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    close_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    second_scrt_usr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_last_updated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    third_scrt_usr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfCase = table.Column<int>(type: "int", nullable: true),
                    CLAIM_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Legal_case_Document_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Case_Create_Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_uri = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    prac_def_org = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_init = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_tow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_invl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prac_seq_num = table.Column<int>(type: "int", nullable: true),
                    date_involved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    date_notified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    date_claim_made = table.Column<DateTime>(type: "datetime2", nullable: true),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_last_updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_case_prac", x => x.case_id);
                });

            migrationBuilder.CreateTable(
                name: "t_caseType",
                columns: table => new
                {
                    case_type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    type_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_caseType", x => x.case_type);
                });

            migrationBuilder.CreateTable(
                name: "t_Category",
                columns: table => new
                {
                    Category_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cat_nominal_code = table.Column<int>(type: "int", nullable: false),
                    valid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Category", x => x.Category_no);
                });

            migrationBuilder.CreateTable(
                name: "t_country",
                columns: table => new
                {
                    CountryCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryNominalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_country", x => x.CountryCode);
                });

            migrationBuilder.CreateTable(
                name: "t_dept",
                columns: table => new
                {
                    DeptId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_dept", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "t_mduLiability",
                columns: table => new
                {
                    case_type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    mdu_liability = table.Column<int>(type: "int", nullable: false),
                    liab_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_mduLiability", x => x.case_type);
                });

            migrationBuilder.CreateTable(
                name: "t_pracArea",
                columns: table => new
                {
                    prac_area_code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prac_area_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_pracArea", x => x.prac_area_code);
                });

            migrationBuilder.CreateTable(
                name: "t_specialties",
                columns: table => new
                {
                    SpcltyCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpcltyDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaimsUse = table.Column<bool>(type: "bit", nullable: false),
                    MemUse = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_specialties", x => x.SpcltyCode);
                });

            migrationBuilder.CreateTable(
                name: "t_staff",
                columns: table => new
                {
                    StaffNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_staff", x => x.StaffNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_adv_team");

            migrationBuilder.DropTable(
                name: "t_app_user");

            migrationBuilder.DropTable(
                name: "t_area");

            migrationBuilder.DropTable(
                name: "t_case");

            migrationBuilder.DropTable(
                name: "t_case_prac");

            migrationBuilder.DropTable(
                name: "t_caseType");

            migrationBuilder.DropTable(
                name: "t_Category");

            migrationBuilder.DropTable(
                name: "t_country");

            migrationBuilder.DropTable(
                name: "t_dept");

            migrationBuilder.DropTable(
                name: "t_mduLiability");

            migrationBuilder.DropTable(
                name: "t_pracArea");

            migrationBuilder.DropTable(
                name: "t_specialties");

            migrationBuilder.DropTable(
                name: "t_staff");
        }
    }
}
