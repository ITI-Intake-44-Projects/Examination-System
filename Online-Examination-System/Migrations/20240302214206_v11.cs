using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Tracks");

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "StudentCourseExam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Passed",
                table: "StudentCourseExam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Instructors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Instructors",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "StudentCourseExam");

            migrationBuilder.DropColumn(
                name: "Passed",
                table: "StudentCourseExam");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Instructors");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Tracks",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Tracks",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

        }
    }
}
