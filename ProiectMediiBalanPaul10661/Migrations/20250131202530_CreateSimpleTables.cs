using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    /// <inheritdoc />
    public partial class CreateSimpleTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programari_Doctori_DoctoriId",
                table: "Programari");

            migrationBuilder.DropForeignKey(
                name: "FK_Programari_Pacienti_PacientId",
                table: "Programari");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Programari",
                newName: "DataProgramare");

            migrationBuilder.AlterColumn<int>(
                name: "PacientId",
                table: "Programari",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DoctoriId",
                table: "Programari",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "Programari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pacient",
                table: "Programari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Serviciu",
                table: "Programari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Programari_Doctori_DoctoriId",
                table: "Programari",
                column: "DoctoriId",
                principalTable: "Doctori",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programari_Pacienti_PacientId",
                table: "Programari",
                column: "PacientId",
                principalTable: "Pacienti",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programari_Doctori_DoctoriId",
                table: "Programari");

            migrationBuilder.DropForeignKey(
                name: "FK_Programari_Pacienti_PacientId",
                table: "Programari");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Programari");

            migrationBuilder.DropColumn(
                name: "Pacient",
                table: "Programari");

            migrationBuilder.DropColumn(
                name: "Serviciu",
                table: "Programari");

            migrationBuilder.RenameColumn(
                name: "DataProgramare",
                table: "Programari",
                newName: "Data");

            migrationBuilder.AlterColumn<int>(
                name: "PacientId",
                table: "Programari",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctoriId",
                table: "Programari",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Programari_Doctori_DoctoriId",
                table: "Programari",
                column: "DoctoriId",
                principalTable: "Doctori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programari_Pacienti_PacientId",
                table: "Programari",
                column: "PacientId",
                principalTable: "Pacienti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
