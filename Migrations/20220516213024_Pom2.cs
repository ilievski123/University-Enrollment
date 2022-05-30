using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnrollment.Migrations
{
    public partial class Pom2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profilePicture",
                table: "Teacher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profilePicture",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
