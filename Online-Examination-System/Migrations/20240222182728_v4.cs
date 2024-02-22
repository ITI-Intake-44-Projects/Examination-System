using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Course_Instructors_InstructorId",
                table: "Instructor_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_Course_Track_Course_Track_CourseCourseId_Track_CourseTrackId",
                table: "Track_Course");

            migrationBuilder.DropIndex(
                name: "IX_Track_Course_Track_CourseCourseId_Track_CourseTrackId",
                table: "Track_Course");

            migrationBuilder.DropColumn(
                name: "Track_CourseCourseId",
                table: "Track_Course");

            migrationBuilder.DropColumn(
                name: "Track_CourseTrackId",
                table: "Track_Course");

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

            migrationBuilder.AlterColumn<int>(
                name: "TrackId",
                table: "Track_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Track_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Instructor_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Instructor_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Course_Instructors_InstructorId",
                table: "Instructor_Course",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Ins_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Course_Instructors_InstructorId",
                table: "Instructor_Course");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "TrackId",
                table: "Track_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Track_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "Track_CourseCourseId",
                table: "Track_Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Track_CourseTrackId",
                table: "Track_Course",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Instructor_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Instructor_Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.CreateIndex(
                name: "IX_Track_Course_Track_CourseCourseId_Track_CourseTrackId",
                table: "Track_Course",
                columns: new[] { "Track_CourseCourseId", "Track_CourseTrackId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Course_Instructors_InstructorId",
                table: "Instructor_Course",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Ins_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Course_Track_Course_Track_CourseCourseId_Track_CourseTrackId",
                table: "Track_Course",
                columns: new[] { "Track_CourseCourseId", "Track_CourseTrackId" },
                principalTable: "Track_Course",
                principalColumns: new[] { "CourseId", "TrackId" });
        }
    }
}
