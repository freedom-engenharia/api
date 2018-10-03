using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomacaoFreedomApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Tipologia");

            migrationBuilder.EnsureSchema(
                name: "Hardware");

            migrationBuilder.CreateTable(
                name: "Empresa",
                schema: "Tipologia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataModificacao = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                schema: "Tipologia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataModificacao = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unidade_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalSchema: "Tipologia",
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Local",
                schema: "Tipologia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataModificacao = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    UnidadeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Local_Unidade_UnidadeId",
                        column: x => x.UnidadeId,
                        principalSchema: "Tipologia",
                        principalTable: "Unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubLocal",
                schema: "Tipologia",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataModificacao = table.Column<DateTime>(nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    LocalId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubLocal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubLocal_Local_LocalId",
                        column: x => x.LocalId,
                        principalSchema: "Tipologia",
                        principalTable: "Local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Divece",
                schema: "Hardware",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    DataModificacao = table.Column<DateTime>(nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SubLocalId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divece", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divece_SubLocal_SubLocalId",
                        column: x => x.SubLocalId,
                        principalSchema: "Tipologia",
                        principalTable: "SubLocal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Divece_SubLocalId",
                schema: "Hardware",
                table: "Divece",
                column: "SubLocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Local_UnidadeId",
                schema: "Tipologia",
                table: "Local",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubLocal_LocalId",
                schema: "Tipologia",
                table: "SubLocal",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Unidade_EmpresaId",
                schema: "Tipologia",
                table: "Unidade",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divece",
                schema: "Hardware");

            migrationBuilder.DropTable(
                name: "SubLocal",
                schema: "Tipologia");

            migrationBuilder.DropTable(
                name: "Local",
                schema: "Tipologia");

            migrationBuilder.DropTable(
                name: "Unidade",
                schema: "Tipologia");

            migrationBuilder.DropTable(
                name: "Empresa",
                schema: "Tipologia");
        }
    }
}
