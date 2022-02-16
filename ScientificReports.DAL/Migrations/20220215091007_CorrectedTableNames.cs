using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScientificReports.DAL.Migrations
{
    public partial class CorrectedTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CathedraEntity_CathedraId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_FacultyEntity_FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CathedraEntity_FacultyEntity_FacultyId",
                table: "CathedraEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScientificDegreeEntity",
                table: "ScientificDegreeEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacultyEntity",
                table: "FacultyEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CathedraEntity",
                table: "CathedraEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicStatusEntity",
                table: "AcademicStatusEntity");

            migrationBuilder.RenameTable(
                name: "ScientificDegreeEntity",
                newName: "ScientificDegrees");

            migrationBuilder.RenameTable(
                name: "FacultyEntity",
                newName: "Faculties");

            migrationBuilder.RenameTable(
                name: "CathedraEntity",
                newName: "Cathedras");

            migrationBuilder.RenameTable(
                name: "AcademicStatusEntity",
                newName: "AcademicStatuses");

            migrationBuilder.RenameIndex(
                name: "IX_CathedraEntity_FacultyId",
                table: "Cathedras",
                newName: "IX_Cathedras_FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScientificDegrees",
                table: "ScientificDegrees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cathedras",
                table: "Cathedras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicStatuses",
                table: "AcademicStatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cathedras_CathedraId",
                table: "AspNetUsers",
                column: "CathedraId",
                principalTable: "Cathedras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Faculties_FacultyId",
                table: "AspNetUsers",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cathedras_Faculties_FacultyId",
                table: "Cathedras",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cathedras_CathedraId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Faculties_FacultyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cathedras_Faculties_FacultyId",
                table: "Cathedras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScientificDegrees",
                table: "ScientificDegrees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculties",
                table: "Faculties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cathedras",
                table: "Cathedras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicStatuses",
                table: "AcademicStatuses");

            migrationBuilder.RenameTable(
                name: "ScientificDegrees",
                newName: "ScientificDegreeEntity");

            migrationBuilder.RenameTable(
                name: "Faculties",
                newName: "FacultyEntity");

            migrationBuilder.RenameTable(
                name: "Cathedras",
                newName: "CathedraEntity");

            migrationBuilder.RenameTable(
                name: "AcademicStatuses",
                newName: "AcademicStatusEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Cathedras_FacultyId",
                table: "CathedraEntity",
                newName: "IX_CathedraEntity_FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScientificDegreeEntity",
                table: "ScientificDegreeEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacultyEntity",
                table: "FacultyEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CathedraEntity",
                table: "CathedraEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicStatusEntity",
                table: "AcademicStatusEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CathedraEntity_CathedraId",
                table: "AspNetUsers",
                column: "CathedraId",
                principalTable: "CathedraEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_FacultyEntity_FacultyId",
                table: "AspNetUsers",
                column: "FacultyId",
                principalTable: "FacultyEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CathedraEntity_FacultyEntity_FacultyId",
                table: "CathedraEntity",
                column: "FacultyId",
                principalTable: "FacultyEntity",
                principalColumn: "Id");
        }
    }
}
