using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace production.Migrations
{
    /// <inheritdoc />
    public partial class editname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "ActualCustomers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActualCustomers",
                table: "ActualCustomers",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ActualCustomers",
                table: "ActualCustomers");

            migrationBuilder.RenameTable(
                name: "ActualCustomers",
                newName: "customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "CustomerId");
        }
    }
}
