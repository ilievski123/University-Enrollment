using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityEnrollment.Migrations
{
    public partial class Roles5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_teacherId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_teacherId1",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_teacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_teacherId1",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "teacherId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "teacherId1",
                table: "Course");

            migrationBuilder.CreateIndex(
                name: "IX_Course_firstTeacherId",
                table: "Course",
                column: "firstTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_secondTeacherId",
                table: "Course",
                column: "secondTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_firstTeacherId",
                table: "Course",
                column: "firstTeacherId",
                principalTable: "Teacher",
                principalColumn: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_secondTeacherId",
                table: "Course",
                column: "secondTeacherId",
                principalTable: "Teacher",
                principalColumn: "teacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_firstTeacherId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Teacher_secondTeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_firstTeacherId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_secondTeacherId",
                table: "Course");

            migrationBuilder.AddColumn<int>(
                name: "teacherId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "teacherId1",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_teacherId",
                table: "Course",
                column: "teacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_teacherId1",
                table: "Course",
                column: "teacherId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_teacherId",
                table: "Course",
                column: "teacherId",
                principalTable: "Teacher",
                principalColumn: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Teacher_teacherId1",
                table: "Course",
                column: "teacherId1",
                principalTable: "Teacher",
                principalColumn: "teacherId");
        }
    }
}
