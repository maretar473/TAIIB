using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class lab04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Product_Product_Id",
                table: "OrderPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPosition",
                table: "OrderPosition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketPosition",
                table: "BasketPosition");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "OrderPosition",
                newName: "OrderPositions");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "BasketPosition",
                newName: "BasketPositions");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPosition_Product_Id",
                table: "OrderPositions",
                newName: "IX_OrderPositions_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPosition_Order_Id",
                table: "OrderPositions",
                newName: "IX_OrderPositions_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_User_Id",
                table: "Orders",
                newName: "IX_Orders_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BasketPosition_User_Id",
                table: "BasketPositions",
                newName: "IX_BasketPositions_User_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPositions",
                table: "OrderPositions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketPositions",
                table: "BasketPositions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Products_User_Id",
                table: "BasketPositions",
                column: "User_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketPositions_Users_User_Id",
                table: "BasketPositions",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Orders_Order_Id",
                table: "OrderPositions",
                column: "Order_Id",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPositions_Products_Product_Id",
                table: "OrderPositions",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_User_Id",
                table: "Orders",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Products_User_Id",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketPositions_Users_User_Id",
                table: "BasketPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Orders_Order_Id",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPositions_Products_Product_Id",
                table: "OrderPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_User_Id",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPositions",
                table: "OrderPositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketPositions",
                table: "BasketPositions");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderPositions",
                newName: "OrderPosition");

            migrationBuilder.RenameTable(
                name: "BasketPositions",
                newName: "BasketPosition");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_User_Id",
                table: "Order",
                newName: "IX_Order_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPositions_Product_Id",
                table: "OrderPosition",
                newName: "IX_OrderPosition_Product_Id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPositions_Order_Id",
                table: "OrderPosition",
                newName: "IX_OrderPosition_Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_BasketPositions_User_Id",
                table: "BasketPosition",
                newName: "IX_BasketPosition_User_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPosition",
                table: "OrderPosition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketPosition",
                table: "BasketPosition",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Product_Product_Id",
                table: "OrderPosition",
                column: "Product_Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
