using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerenClase.Migrations
{
    /// <inheritdoc />
    public partial class MigracionKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estadio",
                table: "Equipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estadio",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
