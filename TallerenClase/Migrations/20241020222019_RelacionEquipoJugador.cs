using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerenClase.Migrations
{
    /// <inheritdoc />
    public partial class RelacionEquipoJugador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "Jugador");

            migrationBuilder.RenameColumn(
                name: "IdEquipoo",
                table: "Jugador",
                newName: "IdEquipo");

            migrationBuilder.AlterColumn<string>(
                name: "Posicion",
                table: "Jugador",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Jugador",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Estadio",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador",
                column: "IdEquipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador",
                column: "IdEquipo",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_IdEquipo",
                table: "Jugador");

            migrationBuilder.DropIndex(
                name: "IX_Jugador_IdEquipo",
                table: "Jugador");

            migrationBuilder.RenameColumn(
                name: "IdEquipo",
                table: "Jugador",
                newName: "IdEquipoo");

            migrationBuilder.AlterColumn<string>(
                name: "Posicion",
                table: "Jugador",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Jugador",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Equipo",
                table: "Jugador",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "Estadio",
                table: "Equipo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
