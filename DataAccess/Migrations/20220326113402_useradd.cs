using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class useradd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CorporateCustomers_AplicationUsers_UserId",
                table: "CorporateCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_AplicationUsers_UserId",
                table: "IndividualCustomers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AplicationUsers",
                table: "AplicationUsers");

            migrationBuilder.RenameTable(
                name: "AplicationUsers",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CorporateCustomers_Users_UserId",
                table: "CorporateCustomers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_Users_UserId",
                table: "IndividualCustomers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CorporateCustomers_Users_UserId",
                table: "CorporateCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_IndividualCustomers_Users_UserId",
                table: "IndividualCustomers");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AplicationUsers");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "AplicationUsers",
                newName: "EMail");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AplicationUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AplicationUsers",
                newName: "Password");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AplicationUsers",
                table: "AplicationUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorporateCustomers_AplicationUsers_UserId",
                table: "CorporateCustomers",
                column: "UserId",
                principalTable: "AplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualCustomers_AplicationUsers_UserId",
                table: "IndividualCustomers",
                column: "UserId",
                principalTable: "AplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
