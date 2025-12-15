using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Os.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDatasOS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "ServiceOrder",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExitDate",
                table: "ServiceOrder",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExitDate",
                table: "ServiceOrder");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "ServiceOrder",
                newName: "Date");
        }
    }
}
