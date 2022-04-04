using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserOperations_OperationId",
                table: "UserOperations",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperations_UserId",
                table: "UserOperations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperations_Operations_OperationId",
                table: "UserOperations",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperations_Users_UserId",
                table: "UserOperations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOperations_Operations_OperationId",
                table: "UserOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserOperations_Users_UserId",
                table: "UserOperations");

            migrationBuilder.DropIndex(
                name: "IX_UserOperations_OperationId",
                table: "UserOperations");

            migrationBuilder.DropIndex(
                name: "IX_UserOperations_UserId",
                table: "UserOperations");
        }
    }
}
