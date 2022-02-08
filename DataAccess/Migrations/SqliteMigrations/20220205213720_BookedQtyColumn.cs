using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.SqliteMigrations
{
    public partial class BookedQtyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookedQuantity",
                table: "Bookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 26, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(3841), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(1859), 4 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4444), 6 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4575), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 23, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4585), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4583), 7 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4588), 1 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 21, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4602), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4600), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 21, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4607), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4604), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 17, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4612), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4609), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 23, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4617), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4615), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 17, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4624), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4621), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4629), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4627), 7 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4631), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4639), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4637), 1 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4642), 1 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 21, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4646), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 26, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4651), 3 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 20, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4656), 1 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4664), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4662), 4 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4667), 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookedQuantity",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8094), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(5991), 6 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 17, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8696), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8681), 4 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8706), 7 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 24, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8715), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8713), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8717), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8735), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8730), 1 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8738), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8745), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8743), 3 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 16, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8747), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8757), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8754), 3 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8761), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8759), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8766), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8764), 8 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 24, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8771), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8769), 3 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 20, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8774), 2 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 23, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8781), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8779), 8 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 21, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8786), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8784), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8791), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8789), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 16, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8797), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8795), 3 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8802), new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8800), 6 });
        }
    }
}
