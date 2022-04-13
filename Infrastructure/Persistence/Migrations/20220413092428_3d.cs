using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _3d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f33708af-51bb-45cd-a25a-c1ccf1d6ae43", "AQAAAAEAACcQAAAAEF2xkUeRkbvh+vP608VTMfMw7syoeGDylHiQxdmzJTxVCjZFge6lkmY8JJ2ov3rdTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18be07db-ae49-44b1-9659-7f16b904bc44", "AQAAAAEAACcQAAAAEBGm1hMvTmBpC93ttnr0bi3LPsWUARrPdYKi0WSQgD5RJWDMgDj9Si9ARtGawT3MLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3ecd191e-3b2f-4a17-bc04-7685bed0a05f", "AQAAAAEAACcQAAAAEL7PK+jvCc6sIdHURs4ei+Uae7wH6jDe7wrBia0PQnd0pMIuz1rbPY8XkC42+mTqgg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d287deea-75f5-4a44-a81a-6586731a2df0", "AQAAAAEAACcQAAAAEBhWrcrwnptz8P57EAkxyGNWi2IuTazQ3CgMBKrO8xb0L+YWup+cZcNuLssAZFFT8w==" });

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 13, 11, 24, 27, 466, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "SizeRangeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "SizeRangeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "SizeRangeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "SizeRangeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 20,
                column: "SizeRangeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 21,
                column: "SizeRangeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 22,
                column: "SizeRangeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 23,
                column: "SizeRangeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 24,
                column: "SizeRangeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 25,
                column: "SizeRangeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 26,
                column: "SizeRangeId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 27,
                column: "SizeRangeId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 28,
                column: "SizeRangeId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 29,
                column: "SizeRangeId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 30,
                column: "SizeRangeId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 31,
                column: "SizeRangeId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 32,
                column: "SizeRangeId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 33,
                column: "SizeRangeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 34,
                column: "SizeRangeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 35,
                column: "SizeRangeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 36,
                column: "SizeRangeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 37,
                column: "SizeRangeId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 38,
                column: "SizeRangeId",
                value: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 19,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 20,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 21,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 22,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 23,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 24,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 25,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 26,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 27,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 28,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 29,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 30,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 31,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 32,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 33,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 34,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 35,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 36,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 37,
                column: "SizeRangeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 38,
                column: "SizeRangeId",
                value: 3);
        }
    }
}
