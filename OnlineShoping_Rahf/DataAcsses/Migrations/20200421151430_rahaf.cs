using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcsses.Migrations
{
    public partial class rahaf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CardsPayments_cardPayment",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAdresses_Orders_Products",
                table: "UserAdresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAdresses_Products",
                table: "UserAdresses");

            migrationBuilder.DropColumn(
                name: "Products",
                table: "UserAdresses");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "cardPayment",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "NetTotalPrice",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "OrderStatesId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "USerAddressId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    productcolorsizeId = table.Column<int>(nullable: false),
                    orderid = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_orderid",
                        column: x => x.orderid,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderProducts_ProductColorSizes_productcolorsizeId",
                        column: x => x.productcolorsizeId,
                        principalTable: "ProductColorSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "23bb18ef-26f0-49a5-b87b-4466a4fc758a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "30043a73-7d9e-4392-ac30-4ff6b6e6ab47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "875e1456-ea73-4d84-b6d9-ed2d3385c422");

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Drafet" },
                    { 2, "OnWork" },
                    { 3, "Completed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatesId",
                table: "Orders",
                column: "OrderStatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_USerAddressId",
                table: "Orders",
                column: "USerAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_orderid",
                table: "OrderProducts",
                column: "orderid");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_productcolorsizeId",
                table: "OrderProducts",
                column: "productcolorsizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatesId",
                table: "Orders",
                column: "OrderStatesId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserAdresses_USerAddressId",
                table: "Orders",
                column: "USerAddressId",
                principalTable: "UserAdresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CardsPayments_cardPayment",
                table: "Orders",
                column: "cardPayment",
                principalTable: "CardsPayments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserAdresses_USerAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_CardsPayments_cardPayment",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderStatesId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_USerAddressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderStatesId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "USerAddressId",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "Products",
                table: "UserAdresses",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cardPayment",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "NetTotalPrice",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b2837809-46b1-4b38-9d62-eb0c328add21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "04148f1e-31a3-4c0b-a441-8bdeb5ac0d61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "82d5edf4-5be7-4426-9d4a-0d32e2a237e0");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdresses_Products",
                table: "UserAdresses",
                column: "Products");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_CardsPayments_cardPayment",
                table: "Orders",
                column: "cardPayment",
                principalTable: "CardsPayments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAdresses_Orders_Products",
                table: "UserAdresses",
                column: "Products",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
