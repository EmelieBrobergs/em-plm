using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _4th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextMeasurementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responds_Measurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responds_Measurements_NextMeasurementId",
                        column: x => x.NextMeasurementId,
                        principalTable: "Measurements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RespondId = table.Column<int>(type: "int", nullable: false),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_Responds_RespondId",
                        column: x => x.RespondId,
                        principalTable: "Responds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cac84e19-fb19-4c03-b153-5cf06b0ed1ed", "AQAAAAEAACcQAAAAEIFT7fdNe6jJAj0ov1Tjl7VP9U17ceQeiIbV6ouh48gQBhpg3T1WOHOcROmF5sBIig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8077cc28-0474-4143-9f1a-5bcc64f822b6", "AQAAAAEAACcQAAAAEMDQUXJJEhpupCpZLHaU/4rfcbtCMy14TaiStnOVMCXKykK9QCTCKByJgl1gZeLhsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65a0508-d79d-4472-b875-cb453c422c1d", "AQAAAAEAACcQAAAAEBKCLLx0dLctwcb4iXB1puInwRqYUaRG+7IrlcbmStAagjIoASWfqNLg3jC1sEIwhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f595cad-890d-4c6f-ae93-5455851663a7", "AQAAAAEAACcQAAAAEAYr9s1B3nCD4vf//S6evx+xLnalye+VHbatEL14CZ4tfSlivucmq+LX3Xm3VnfrBA==" });

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 11, 35, 5, 975, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.CreateIndex(
                name: "IX_Responds_MeasurementId",
                table: "Responds",
                column: "MeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Responds_NextMeasurementId",
                table: "Responds",
                column: "NextMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_RespondId",
                table: "Samples",
                column: "RespondId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Responds");

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
        }
    }
}
