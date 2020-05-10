using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace expense_tracker_back_end.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Personas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Personas",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Personas",
                newName: "Apellido");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreUsuario = table.Column<string>(nullable: true),
                    Contra = table.Column<string>(nullable: true),
                    PersonaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Personas_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PersonaID",
                table: "Usuarios",
                column: "PersonaID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Personas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Personas",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Personas",
                newName: "apellido");
        }
    }
}
