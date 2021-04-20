using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMS_Project.Migrations
{
    public partial class i5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveStatus",
                columns: table => new
                {
                    LeaveStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveStatus", x => x.LeaveStatusId);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfHours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.LeaveTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplication_LeaveStatusId",
                table: "LeaveApplication",
                column: "LeaveStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplication_LeaveTypeId",
                table: "LeaveApplication",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApplication_LeaveStatus_LeaveStatusId",
                table: "LeaveApplication",
                column: "LeaveStatusId",
                principalTable: "LeaveStatus",
                principalColumn: "LeaveStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveApplication_LeaveType_LeaveTypeId",
                table: "LeaveApplication",
                column: "LeaveTypeId",
                principalTable: "LeaveType",
                principalColumn: "LeaveTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApplication_LeaveStatus_LeaveStatusId",
                table: "LeaveApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveApplication_LeaveType_LeaveTypeId",
                table: "LeaveApplication");

            migrationBuilder.DropTable(
                name: "LeaveStatus");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApplication_LeaveStatusId",
                table: "LeaveApplication");

            migrationBuilder.DropIndex(
                name: "IX_LeaveApplication_LeaveTypeId",
                table: "LeaveApplication");
        }
    }
}
