using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicShopWebAPI.Data.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 4, 4, 16, 19, 435, DateTimeKind.Local).AddTicks(7526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 10, 4, 3, 33, 13, 552, DateTimeKind.Local).AddTicks(4050));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 4, 3, 33, 13, 552, DateTimeKind.Local).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 4, 4, 16, 19, 435, DateTimeKind.Local).AddTicks(7526));
        }
    }
}
