using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnrollment.Migrations
{
    public partial class University4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profilePicture",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "profilePicture",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profilePicture",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "profilePicture",
                table: "Student");
        }
    }
}
