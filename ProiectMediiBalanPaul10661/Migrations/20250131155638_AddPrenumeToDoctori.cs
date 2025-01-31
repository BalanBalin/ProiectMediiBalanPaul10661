using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    /// <inheritdoc />
    public partial class AddPrenumeToDoctori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "Doctori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "Doctori");
        }
    }
}
