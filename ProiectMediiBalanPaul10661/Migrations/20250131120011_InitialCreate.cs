using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specializare = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacienti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataNasterii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacienti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DoctoriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicii_Doctori_DoctoriId",
                        column: x => x.DoctoriId,
                        principalTable: "Doctori",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Programari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacientId = table.Column<int>(type: "int", nullable: false),
                    DoctoriId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programari_Doctori_DoctoriId",
                        column: x => x.DoctoriId,
                        principalTable: "Doctori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programari_Pacienti_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programari_DoctoriId",
                table: "Programari",
                column: "DoctoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Programari_PacientId",
                table: "Programari",
                column: "PacientId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicii_DoctoriId",
                table: "Servicii",
                column: "DoctoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programari");

            migrationBuilder.DropTable(
                name: "Servicii");

            migrationBuilder.DropTable(
                name: "Pacienti");

            migrationBuilder.DropTable(
                name: "Doctori");
        }
    }
}
