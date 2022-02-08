using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations.SqliteMigrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 1, new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8094), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(5991), "Resource {1}", 6 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 17, new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8791), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8789), "Resource {17}", 9 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 16, new DateTime(2022, 1, 21, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8786), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8784), "Resource {16}", 5 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 15, new DateTime(2022, 1, 23, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8781), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8779), "Resource {15}", 8 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 14, new DateTime(2022, 1, 20, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8776), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8774), "Resource {14}", 2 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 13, new DateTime(2022, 1, 24, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8771), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8769), "Resource {13}", 3 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 12, new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8766), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8764), "Resource {12}", 8 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 11, new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8761), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8759), "Resource {11}", 5 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 18, new DateTime(2022, 1, 16, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8797), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8795), "Resource {18}", 3 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 10, new DateTime(2022, 1, 19, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8757), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8754), "Resource {10}", 3 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 8, new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8745), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8743), "Resource {8}", 3 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 7, new DateTime(2022, 1, 19, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8740), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8738), "Resource {7}", 9 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 6, new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8735), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8730), "Resource {6}", 1 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 5, new DateTime(2022, 1, 18, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8720), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8717), "Resource {5}", 2 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 4, new DateTime(2022, 1, 24, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8715), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8713), "Resource {4}", 2 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 3, new DateTime(2022, 1, 22, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8710), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8706), "Resource {3}", 7 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 2, new DateTime(2022, 1, 17, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8696), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8681), "Resource {2}", 4 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 9, new DateTime(2022, 1, 16, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8750), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8747), "Resource {9}", 2 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CreatedAt", "IsActive", "LastModifiedAt", "Name", "Quantity" },
                values: new object[] { 19, new DateTime(2022, 1, 25, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8802), true, new DateTime(2022, 2, 4, 18, 5, 28, 103, DateTimeKind.Local).AddTicks(8800), "Resource {19}", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 19);
        }
    }
}
