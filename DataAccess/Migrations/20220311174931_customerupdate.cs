using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class customerupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerLastName",
                table: "IndividualCustomers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "CustomerFirstName",
                table: "IndividualCustomers",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "IndividualCustomers",
                newName: "CustomerLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "IndividualCustomers",
                newName: "CustomerFirstName");
        }
    }
}
