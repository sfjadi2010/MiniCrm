using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniCrm.Migrations
{
    /// <inheritdoc />
    public partial class renamezipcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Addresses",
                newName: "ZipCode");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Addresses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Addresses",
                newName: "Zip");
        }
    }
}
