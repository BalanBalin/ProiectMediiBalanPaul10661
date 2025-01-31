using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectMediiBalanPaul10661.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNasterii",
                table: "Pacienti",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNasterii",
                table: "Pacienti",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");
        }
    }
}
