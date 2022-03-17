using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class _3nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BasedOn",
                table: "MmntList",
                newName: "MmntList");

            migrationBuilder.AddColumn<int>(
                name: "BasedOnMmntListId",
                table: "MmntList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MmntList_MmntList",
                table: "MmntList",
                column: "MmntList");

            migrationBuilder.AddForeignKey(
                name: "FK_MmntList_MmntList_MmntList",
                table: "MmntList",
                column: "MmntList",
                principalTable: "MmntList",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MmntList_MmntList_MmntList",
                table: "MmntList");

            migrationBuilder.DropIndex(
                name: "IX_MmntList_MmntList",
                table: "MmntList");

            migrationBuilder.DropColumn(
                name: "BasedOnMmntListId",
                table: "MmntList");

            migrationBuilder.RenameColumn(
                name: "MmntList",
                table: "MmntList",
                newName: "BasedOn");
        }
    }
}
