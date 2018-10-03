using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomacaoFreedomApi.Migrations
{
    public partial class CorrecaoNomeDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divece_SubLocal_SubLocalId",
                schema: "Hardware",
                table: "Divece");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Divece",
                schema: "Hardware",
                table: "Divece");

            migrationBuilder.RenameTable(
                name: "Divece",
                schema: "Hardware",
                newName: "Device",
                newSchema: "Hardware");

            migrationBuilder.RenameIndex(
                name: "IX_Divece_SubLocalId",
                schema: "Hardware",
                table: "Device",
                newName: "IX_Device_SubLocalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Device",
                schema: "Hardware",
                table: "Device",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Device_SubLocal_SubLocalId",
                schema: "Hardware",
                table: "Device",
                column: "SubLocalId",
                principalSchema: "Tipologia",
                principalTable: "SubLocal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Device_SubLocal_SubLocalId",
                schema: "Hardware",
                table: "Device");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Device",
                schema: "Hardware",
                table: "Device");

            migrationBuilder.RenameTable(
                name: "Device",
                schema: "Hardware",
                newName: "Divece",
                newSchema: "Hardware");

            migrationBuilder.RenameIndex(
                name: "IX_Device_SubLocalId",
                schema: "Hardware",
                table: "Divece",
                newName: "IX_Divece_SubLocalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Divece",
                schema: "Hardware",
                table: "Divece",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Divece_SubLocal_SubLocalId",
                schema: "Hardware",
                table: "Divece",
                column: "SubLocalId",
                principalSchema: "Tipologia",
                principalTable: "SubLocal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
