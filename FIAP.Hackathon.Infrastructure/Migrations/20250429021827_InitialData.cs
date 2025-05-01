using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIAP.Hackathon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Especialidade",
                columns: new[] { "EspecialidadeId", "Descricao" },
                values: new object[,]
                {
                    { "cc307c44-ed03-4f01-9352-673fceb0dc7a", "Clínica Médica" },
                    { "c78f9400-f27e-422d-abe1-6818925c24ba", "Cardiologista" },
                    { "8a00c1cc-92fb-4deb-8f39-39af6c43e2c3", "Traumatologista" },
                    { "213810de-0266-49cb-b1fb-25ebb216bda0", "Neurologia" },
                    { "869bb6e4-257d-4e55-aabf-d700df1917d0", "Dermatologista" },
                    { "b9cee573-fbe1-4558-9abd-9eb0d619fe9e", "Cirurgia Geral" },
                });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "MedicoId", "EspecialidadeId", "Nome", "CRM", "Endereco", "Cidade", "Estado", "CEP", "Email", "Senha" },
                values: new object[,]
                {
                    { "ea65c818-2fae-464a-a6eb-ba7784a41ec0", "cc307c44-ed03-4f01-9352-673fceb0dc7a", "Ana Maria", "159753", "Av. Dr. Maurício Cardoso, 833 - Hamburgo Velho", "Novo Hamburgo", "RS", "93510-223", "anamaria@centroclinicofiap.com.br", "MD159753" },
                    { "a5e2ac24-5510-4bb7-b2f2-bc2b7653242b", "c78f9400-f27e-422d-abe1-6818925c24ba", "José Francisco", "357951", "Av. Dr. Maurício Cardoso, 833 - Hamburgo Velho", "Novo Hamburgo", "RS", "93510-223", "josefrancisco@centroclinicofiap.com.br", "MD357951" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medico",
                keyColumn: "Id",
                keyValues: new object[] { "ea65c818-2fae-464a-a6eb-ba7784a41ec0", "a5e2ac24-5510-4bb7-b2f2-bc2b7653242b" });

            migrationBuilder.DeleteData(
                table: "Especialidade",
                keyColumn: "Id",
                keyValues: new object[] { "cc307c44-ed03-4f01-9352-673fceb0dc7a", "c78f9400-f27e-422d-abe1-6818925c24ba", "8a00c1cc-92fb-4deb-8f39-39af6c43e2c3", "213810de-0266-49cb-b1fb-25ebb216bda0", "869bb6e4-257d-4e55-aabf-d700df1917d0", "b9cee573-fbe1-4558-9abd-9eb0d619fe9e" });
        }
    }
}
