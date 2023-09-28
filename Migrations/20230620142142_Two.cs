using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShop_WebApp4.Migrations
{
    /// <inheritdoc />
    public partial class Two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Cats" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 21, 42, 180, DateTimeKind.Local).AddTicks(4633));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25,
                column: "CommentDate",
                value: new DateTime(2023, 6, 20, 17, 9, 9, 100, DateTimeKind.Local).AddTicks(1880));
        }
    }
}
