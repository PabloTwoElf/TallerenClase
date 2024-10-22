using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerenClase.Migrations
{
    /// <inheritdoc />
    public partial class EstadioEquipo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreEstadio",
                table: "Estadio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreEstadio",
                table: "Estadio");
        }
    }
}
