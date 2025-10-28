using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Etapa4_API.Migrations
{
    /// <inheritdoc />
    public partial class CriarDispositivoComPatrimonio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dispositivos",
                table: "Dispositivos");

            migrationBuilder.RenameTable(
                name: "Dispositivos",
                newName: "Dispositivo");

            migrationBuilder.AddColumn<int>(
                name: "Patrimonio",
                table: "Dispositivo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dispositivo",
                table: "Dispositivo",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dispositivo",
                table: "Dispositivo");

            migrationBuilder.DropColumn(
                name: "Patrimonio",
                table: "Dispositivo");

            migrationBuilder.RenameTable(
                name: "Dispositivo",
                newName: "Dispositivos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dispositivos",
                table: "Dispositivos",
                column: "Id");
        }
    }
}
