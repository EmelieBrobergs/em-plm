using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Measurements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c033ef2-f085-40e8-825b-80465c9ae8ee", "AQAAAAEAACcQAAAAEDI6gCVQ6inRm9WU9MrvDSnUrMiUWMx/P911ai2mQ3TE9smPZjQ6ka9jQHVtZSkzFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36a45997-8153-4e1c-a4d8-6bbf14c97661", "AQAAAAEAACcQAAAAEE/3RF3SCDnrTnLkbVtlZ977tb51hgGq81HBBJsKOFH0+kmvBwFGO77HymOgasWgdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35ec8a2a-a44a-4ff6-a78c-545beaaa3214", "AQAAAAEAACcQAAAAEI5TCnQNOycfeT3WZ3abcJy+sXEj4fLt17mcNXb7KfJY1LzvSxV7tCh+NZpXtY42+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a43b52e6-d025-4e9a-b19a-b53cabc093c4", "AQAAAAEAACcQAAAAECE41o5s3SRuKUqIqDXkvDMZU3mi+4kl1vvvfq5ZtfDIf9QEaDPGHRcQevscK5bmHQ==" });

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 8, 9, 3, 36, 776, DateTimeKind.Local).AddTicks(5924));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Measurements");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bc6f3bb-447d-4e5e-b93c-9a1f8e625b45", "AQAAAAEAACcQAAAAELSyxmhcuw22ywBPlYjNtUsu1UdydA9ls5EJxXvNdPv+l36tjqTx+Y9DKFbnO83EkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a86854f-d9f4-43ad-b621-102c74a04829", "AQAAAAEAACcQAAAAEKHmANPEsqPLttMVo/DNFC4Q870J+5g1juPzhXg8KZA0u7ttafuDCk3Aus1xw4NCHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a645d57-c935-44ef-ac6e-a1a26e0e2a31", "AQAAAAEAACcQAAAAEMrq7ldGvaelTVPuAegir8IatP+yDAN6p4/WEkkfQHBCdjCRtilLZPBEWbRTGBLqjQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "008bf76a-b23c-4d5d-8e7b-b7e76cf6161a", "AQAAAAEAACcQAAAAECQW1KMTteqIfqpna/Kx1IY8MdFUMl8X2ORxAs6rbDJi797dYh63u0+GBut6VJMHtQ==" });
        }
    }
}
