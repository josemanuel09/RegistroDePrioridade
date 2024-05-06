using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroDePrioridades.Migrations
{
    /// <inheritdoc />
    public partial class Agregando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiasCompromiso",
                table: "Prioridades",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasCompromiso",
                table: "Prioridades");
        }
    }
}
