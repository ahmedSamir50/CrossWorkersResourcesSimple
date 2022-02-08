using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.SqliteMigrations
{
    public partial class DefualtValueIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 22, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(1490), new DateTime(2022, 2, 6, 18, 27, 20, 208, DateTimeKind.Local).AddTicks(9605), 8 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 26, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2112), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2095), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2124), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2129), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2131), 7 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2152), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2149), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 27, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2157), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2155), 8 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 24, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2163), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2160), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 23, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2168), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2165), 8 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2175), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2172), 9 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 27, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2177), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 25, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2185), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2182), 3 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 18, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2189), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2187), 7 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 20, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2194), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2192), 7 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 21, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2199), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2197), 4 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 1, 23, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 24, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2206), 8 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 20, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2215), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2212), 5 });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastModifiedAt", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 27, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 2, 6, 18, 27, 20, 209, DateTimeKind.Local).AddTicks(2218), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 1, 22, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 1, 23, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4585), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4583) });

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
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2022, 1, 26, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 2, 5, 23, 37, 20, 386, DateTimeKind.Local).AddTicks(4651) });

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
    }
}
