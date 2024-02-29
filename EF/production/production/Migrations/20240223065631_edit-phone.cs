using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace production.Migrations
{
    /// <inheritdoc />
    public partial class editphone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "ActualCustomers",
                newName: "PhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ActualCustomers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "ActualCustomers",
                newName: "Phone");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ActualCustomers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
