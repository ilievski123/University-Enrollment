using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnrollment.Migrations
{
    public partial class Pom4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profilePicture",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profilePicture",
                table: "Teacher");
        }
    }
}
