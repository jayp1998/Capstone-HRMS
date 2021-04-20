using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMS_Project.Migrations
{
    public partial class i4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EducationDetail",
                columns: table => new
                {
                    EducationDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DegreeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gpa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetail", x => x.EducationDetailsId);
                    table.ForeignKey(
                        name: "FK_EducationDetail_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobDetail",
                columns: table => new
                {
                    JobDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReportsTo = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProbationaryPeriodStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProbationaryPeriodEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetail", x => x.JobDetailsId);
                    table.ForeignKey(
                        name: "FK_JobDetail_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveApplication",
                columns: table => new
                {
                    LeaveApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveAppliedBy = table.Column<int>(type: "int", nullable: false),
                    LeaveApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hours = table.Column<int>(type: "int", nullable: true),
                    LeaveAppliedTo = table.Column<int>(type: "int", nullable: false),
                    LeaveStatusId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveStatusUpdatedBy = table.Column<int>(type: "int", nullable: false),
                    LeaveStatusUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveApplication", x => x.LeaveApplicationId);
                    table.ForeignKey(
                        name: "FK_LeaveApplication_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetail_EmployeeId",
                table: "EducationDetail",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobDetail_EmployeeId",
                table: "JobDetail",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApplication_EmployeeId",
                table: "LeaveApplication",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetail");

            migrationBuilder.DropTable(
                name: "JobDetail");

            migrationBuilder.DropTable(
                name: "LeaveApplication");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
