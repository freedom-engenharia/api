using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomacaoFreedomApi.Migrations
{
    public partial class addIpEmDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IP",
                schema: "Hardware",
                table: "Device",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mac",
                schema: "Hardware",
                table: "Device",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IP",
                schema: "Hardware",
                table: "Device");

            migrationBuilder.DropColumn(
                name: "Mac",
                schema: "Hardware",
                table: "Device");
        }
    }
}
