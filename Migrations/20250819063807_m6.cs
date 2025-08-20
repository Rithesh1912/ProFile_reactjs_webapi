using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasmanSln.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_staff",
                table: "staff");

            migrationBuilder.RenameTable(
                name: "staff",
                newName: "t_staff");

            migrationBuilder.AddPrimaryKey(
                name: "PK_t_staff",
                table: "t_staff",
                column: "StaffId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_dept");

            migrationBuilder.DropPrimaryKey(
                name: "PK_t_staff",
                table: "t_staff");

            migrationBuilder.RenameTable(
                name: "t_staff",
                newName: "staff");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staff",
                table: "staff",
                column: "StaffId");
        }
    }
}
