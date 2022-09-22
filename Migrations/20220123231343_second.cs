using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCore1.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student_Table");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourse_Table");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Course_Table");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse_Table",
                newName: "IX_StudentCourse_Table_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse_Table",
                newName: "IX_StudentCourse_Table_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_Table",
                table: "Student_Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse_Table",
                table: "StudentCourse_Table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Table",
                table: "Course_Table",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table",
                column: "CourseId",
                principalTable: "Course_Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Table_Student_Table_StudentId",
                table: "StudentCourse_Table",
                column: "StudentId",
                principalTable: "Student_Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Table_Student_Table_StudentId",
                table: "StudentCourse_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse_Table",
                table: "StudentCourse_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_Table",
                table: "Student_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Table",
                table: "Course_Table");

            migrationBuilder.RenameTable(
                name: "StudentCourse_Table",
                newName: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "Student_Table",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Course_Table",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_Table_StudentId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_Table_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
