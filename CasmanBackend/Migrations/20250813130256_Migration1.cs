using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasmanSln.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
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
