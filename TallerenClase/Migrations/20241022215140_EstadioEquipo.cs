using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerenClase.Migrations
{
    /// <inheritdoc />
    public partial class EstadioEquipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEstadio",
                table: "Equipo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_IdEstadio",
                table: "Equipo",
                column: "IdEstadio");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Estadio_IdEstadio",
                table: "Equipo",
                column: "IdEstadio",
                principalTable: "Estadio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Estadio_IdEstadio",
                table: "Equipo");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_IdEstadio",
                table: "Equipo");

            migrationBuilder.DropColumn(
                name: "IdEstadio",
                table: "Equipo");
        }
    }
}
