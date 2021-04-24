using Microsoft.EntityFrameworkCore.Migrations;

namespace TRexWebApi.Data.Migrations
{
    public partial class Modification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MachineId",
                table: "Machine",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Machine",
                newName: "MachineId");
        }
    }
}
