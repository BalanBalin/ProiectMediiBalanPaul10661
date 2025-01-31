using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecializareToServicii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Specializare",
                table: "Servicii",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specializare",
                table: "Servicii");
        }
    }
}
