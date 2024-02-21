using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Crs_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Working_Hours = table.Column<int>(type: "int", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_ID);
                });

            migrationBuilder.CreateTable(
                name: "Course_Topics",
                columns: table => new
                {
                    Crs_ID = table.Column<int>(type: "int", nullable: false),
                    Topic_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Topics", x => new { x.Crs_ID, x.Topic_Name });
                    table.ForeignKey(
                        name: "FK_Course_Topics_Courses_Crs_ID",
                        column: x => x.Crs_ID,
                        principalTable: "Courses",
                        principalColumn: "Crs_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructor_Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Course", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_Instructor_Course_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Crs_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Ins_ID");
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Trk_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    SuperID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Trk_ID);
                    table.ForeignKey(
                        name: "FK_Tracks_Instructors_SuperID",
                        column: x => x.SuperID,
                        principalTable: "Instructors",
                        principalColumn: "Ins_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructor_Track",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Track", x => new { x.InstructorId, x.TrackId });
                    table.ForeignKey(
                        name: "FK_Instructor_Track_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Ins_ID");
                    table.ForeignKey(
                        name: "FK_Instructor_Track_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Trk_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Track_Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false),
                    Track_CourseCourseId = table.Column<int>(type: "int", nullable: true),
                    Track_CourseTrackId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track_Course", x => new { x.CourseId, x.TrackId });
                    table.ForeignKey(
                        name: "FK_Track_Course_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Crs_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Track_Course_Track_Course_Track_CourseCourseId_Track_CourseTrackId",
                        columns: x => new { x.Track_CourseCourseId, x.Track_CourseTrackId },
                        principalTable: "Track_Course",
                        principalColumns: new[] { "CourseId", "TrackId" });
                    table.ForeignKey(
                        name: "FK_Track_Course_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Trk_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Course_InstructorId",
                table: "Instructor_Course",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Track_TrackId",
                table: "Instructor_Track",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_Course_Track_CourseCourseId_Track_CourseTrackId",
                table: "Track_Course",
                columns: new[] { "Track_CourseCourseId", "Track_CourseTrackId" });

            migrationBuilder.CreateIndex(
                name: "IX_Track_Course_TrackId",
                table: "Track_Course",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_SuperID",
                table: "Tracks",
                column: "SuperID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Topics");

            migrationBuilder.DropTable(
                name: "Instructor_Course");

            migrationBuilder.DropTable(
                name: "Instructor_Track");

            migrationBuilder.DropTable(
                name: "Track_Course");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
