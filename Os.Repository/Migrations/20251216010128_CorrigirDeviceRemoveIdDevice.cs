using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Os.Repository.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirDeviceRemoveIdDevice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDevice",
                table: "Device");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDevice",
                table: "Device",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
