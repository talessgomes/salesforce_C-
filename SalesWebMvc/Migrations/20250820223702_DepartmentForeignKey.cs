using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DeparmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DeparmentId",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DeparmentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "DeparmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DeparmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DeparmentId",
                table: "Seller",
                column: "DeparmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
