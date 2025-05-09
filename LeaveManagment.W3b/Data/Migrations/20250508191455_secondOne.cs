using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.W3b.Data.Migrations
{
    public partial class secondOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultDays",
                table: "LeaveTypes",
                newName: "NumberOfDays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfDays",
                table: "LeaveTypes",
                newName: "DefaultDays");
        }
    }
}
