using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class cw3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "OrderPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPosition_Product_Id",
                table: "OrderPosition",
                column: "Product_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Product_Product_Id",
                table: "OrderPosition",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Product_Product_Id",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_OrderPosition_Product_Id",
                table: "OrderPosition");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "OrderPosition");
        }
    }
}
