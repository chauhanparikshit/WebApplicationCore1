using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCore1.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table");

            migrationBuilder.DropColumn(
                name: "CoursetId",
                table: "StudentCourse_Table");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "StudentCourse_Table",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table",
                column: "CourseId",
                principalTable: "Course_Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "StudentCourse_Table",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CoursetId",
                table: "StudentCourse_Table",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Table_Course_Table_CourseId",
                table: "StudentCourse_Table",
                column: "CourseId",
                principalTable: "Course_Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
