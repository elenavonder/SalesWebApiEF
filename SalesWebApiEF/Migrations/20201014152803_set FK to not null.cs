using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebApiEF.Migrations
{
    public partial class setFKtonotnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Order_OrderId",
                table: "OrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Product_ProductId",
                table: "OrderLine");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderLine",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderLine",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Order_OrderId",
                table: "OrderLine",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Product_ProductId",
                table: "OrderLine",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Order_OrderId",
                table: "OrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Product_ProductId",
                table: "OrderLine");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderLine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderLine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Order_OrderId",
                table: "OrderLine",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Product_ProductId",
                table: "OrderLine",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
