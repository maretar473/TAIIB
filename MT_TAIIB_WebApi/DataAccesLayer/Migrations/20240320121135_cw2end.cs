using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class cw2end : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPosition_Product_ProductId",
                table: "BasketPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPosition_Users_UserId",
                table: "BasketPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Order_OrderId",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_OrderPosition_OrderId",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_BasketPosition_ProductId",
                table: "BasketPosition");

            migrationBuilder.DropIndex(
                name: "IX_BasketPosition_UserId",
                table: "BasketPosition");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderPosition");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "BasketPosition");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BasketPosition");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPosition_Order_Id",
                table: "OrderPosition",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_User_Id",
                table: "Order",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BasketPosition_User_Id",
                table: "BasketPosition",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPosition_Product_User_Id",
                table: "BasketPosition",
                column: "User_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPosition_Users_User_Id",
                table: "BasketPosition",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_User_Id",
                table: "Order",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Order_Order_Id",
                table: "OrderPosition",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPosition_Product_User_Id",
                table: "BasketPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPosition_Users_User_Id",
                table: "BasketPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_User_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Order_Order_Id",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_OrderPosition_Order_Id",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_Order_User_Id",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_BasketPosition_User_Id",
                table: "BasketPosition");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "BasketPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BasketPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPosition_OrderId",
                table: "OrderPosition",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketPosition_ProductId",
                table: "BasketPosition",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketPosition_UserId",
                table: "BasketPosition",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPosition_Product_ProductId",
                table: "BasketPosition",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPosition_Users_UserId",
                table: "BasketPosition",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Order_OrderId",
                table: "OrderPosition",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
