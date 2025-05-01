using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIAP.Hackathon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    EspecialidadeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.EspecialidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    MedicoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EspecialidadeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CRM = table.Column<string>(type: "text", nullable: false),
                    Endereco = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    CEP = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.MedicoId);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidade",
                        principalColumn: "EspecialidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medico_EspecialidadeId",
                table: "Medico",
                column: "EspecialidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Especialidade");
        }
    }
}
