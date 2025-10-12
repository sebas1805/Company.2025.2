using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Backend.Migrations
{
    /// <inheritdoc />
    public partial class GenericEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_FirstName",
                table: "Employees",
                newName: "IX_Employees_Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_Name",
                table: "Employees",
                newName: "IX_Employees_FirstName");
        }
    }
}
