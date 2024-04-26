using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaNike.Data.Migrations
{
    /// <inheritdoc />
    public partial class TiendaNike3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "AspNetUsers",
                newName: "NombreUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreUsuario",
                table: "AspNetUsers",
                newName: "Nombre");
        }
    }
}
