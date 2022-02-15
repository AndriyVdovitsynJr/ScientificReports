using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScientificReports.DAL.Migrations
{
    public partial class UserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "AspNetUsers",
                newName: "TrainingBookCounterBeforeRegistration");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "PublicationCounterBeforeRegistration");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedById",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AspirantFinishYear",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AspirantStartYear",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AwardingDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "BookCounterBeforeRegistration",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConferenceCounterBeforeRegistration",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DefenseYear",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoctorFinishYear",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoctorStartYear",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GraduationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MonographCounterBeforeRegistration",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OtherWritingCounterBeforeRegistration",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatentCounterBeforeRegistration",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApprovedById",
                table: "AspNetUsers",
                column: "ApprovedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApprovedById",
                table: "AspNetUsers",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApprovedById",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApprovedById",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApprovedById",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AspirantFinishYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AspirantStartYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AwardingDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BookCounterBeforeRegistration",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ConferenceCounterBeforeRegistration",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DefenseYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorFinishYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DoctorStartYear",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GraduationDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MonographCounterBeforeRegistration",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OtherWritingCounterBeforeRegistration",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PatentCounterBeforeRegistration",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TrainingBookCounterBeforeRegistration",
                table: "AspNetUsers",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "PublicationCounterBeforeRegistration",
                table: "AspNetUsers",
                newName: "Name");
        }
    }
}
