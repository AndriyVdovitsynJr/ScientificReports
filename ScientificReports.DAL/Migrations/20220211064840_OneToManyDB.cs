using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScientificReports.DAL.Migrations
{
    public partial class OneToManyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "CathedraEntity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CathedraEntity_FacultyId",
                table: "CathedraEntity",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CathedraEntity_FacultyEntity_FacultyId",
                table: "CathedraEntity",
                column: "FacultyId",
                principalTable: "FacultyEntity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CathedraEntity_FacultyEntity_FacultyId",
                table: "CathedraEntity");

            migrationBuilder.DropIndex(
                name: "IX_CathedraEntity_FacultyId",
                table: "CathedraEntity");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "CathedraEntity");
        }
    }
}
