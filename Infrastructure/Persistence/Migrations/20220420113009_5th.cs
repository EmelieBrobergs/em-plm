using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _5th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeName",
                table: "Samples");

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Samples",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SampleMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementPointId = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<float>(type: "real", nullable: false),
                    SampleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleMeasurements_MeasurementPoints_MeasurementPointId",
                        column: x => x.MeasurementPointId,
                        principalTable: "MeasurementPoints",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SampleMeasurements_Samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58b819db-3440-4677-90c8-c4969d980417", "AQAAAAEAACcQAAAAECcdsWwX7ddtD31jKkpcKng3ssnbj8En/DoAHjZog+Cn+ZLdFVG6d3iPb+lEQBavTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a0c7440-af29-44d1-8e5b-07ecb97267ea", "AQAAAAEAACcQAAAAEBSMhbKeQvBDpv8F+WJflIhocUQzDoiTrAJydENmKjz6yLMp1x2xIjQaWoZHDYNM7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "149b886f-b192-4ace-bcef-5af04a2ff212", "AQAAAAEAACcQAAAAEKNqYJzKNfhElepmyj42nPYDep48C59RDhZDXW4l3OAMHcEQd+n5EwH86KmTDwO/Kw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eebaa753-3922-48fb-a781-fa5476e5cc48", "AQAAAAEAACcQAAAAEAc1eRHrgH5LY9VMdfb7MiXnTZ20yjWHe5fXZmVSZIqrpL1ITmchY6CzqO2LLP5yaQ==" });

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Measurements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 4, 20, 13, 30, 8, 287, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.CreateIndex(
                name: "IX_Samples_SizeId",
                table: "Samples",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleMeasurements_MeasurementPointId",
                table: "SampleMeasurements",
                column: "MeasurementPointId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleMeasurements_SampleId",
                table: "SampleMeasurements",
                column: "SampleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samples_Sizes_SizeId",
                table: "Samples",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samples_Sizes_SizeId",
                table: "Samples");

            migrationBuilder.DropTable(
                name: "SampleMeasurements");

            migrationBuilder.DropIndex(
                name: "IX_Samples_SizeId",
                table: "Samples");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Samples");

            migrationBuilder.AddColumn<string>(
                name: "SizeName",
                table: "Samples",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
        }
    }
}
