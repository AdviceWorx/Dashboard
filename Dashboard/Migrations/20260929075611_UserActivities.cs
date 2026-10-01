using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard.Migrations
{
    /// <inheritdoc />
    public partial class UserActivities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActiveHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DowntimeHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    M365Hours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InteractiveEvents = table.Column<long>(type: "bigint", nullable: true),
                    ClockIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClockOut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationVerdict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstPublicIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastPublicIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPChanges = table.Column<int>(type: "int", nullable: true),
                    XplanSessions = table.Column<int>(type: "int", nullable: true),
                    XplanHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XplanResources = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XplanOvernightSessions = table.Column<int>(type: "int", nullable: true),
                    XplanAfterHoursSessions = table.Column<int>(type: "int", nullable: true),
                    AnomalyFlags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagCount = table.Column<int>(type: "int", nullable: true),
                    PreviousDayWorkHours = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WorkHoursChange = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NewUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResearchNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActivities");
        }
    }
}
