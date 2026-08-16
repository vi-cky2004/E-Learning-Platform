using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Learning_Platform.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminStudent2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "student",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "roll_no",
                table: "student",
                newName: "RollNo");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "student",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "student",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "admin",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "admin_id",
                table: "admin",
                newName: "AdminId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "Dob",
                table: "student",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "student",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "admin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "admin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "OfficePhone",
                table: "admin",
                type: "bigint",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "student");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "student");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "student");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "student");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "admin");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "admin");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "admin");

            migrationBuilder.DropColumn(
                name: "OfficePhone",
                table: "admin");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "student",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "RollNo",
                table: "student",
                newName: "roll_no");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "student",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "student",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "admin",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "admin",
                newName: "admin_id");
        }
    }
}
