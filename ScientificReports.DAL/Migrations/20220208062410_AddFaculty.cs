using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScientificReports.DAL.Migrations
{
    public partial class AddFaculty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FacultyEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FacultyId",
                table: "AspNetUsers",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_FacultyEntity_FacultyId",
                table: "AspNetUsers",
                column: "FacultyId",
                principalTable: "FacultyEntity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_FacultyEntity_FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FacultyEntity");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "AspNetUsers");
        }
    }
}
