using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Ex_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TotalGrade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Ex_Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Q_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Marks = table.Column<int>(type: "int", nullable: true),
                    ModelAns = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Q_Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "Date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Faculty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Passowrd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.St_Id);
                    table.ForeignKey(
                        name: "FK_Students_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Trk_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ques_Choices",
                columns: table => new
                {
                    Ques_id = table.Column<int>(type: "int", nullable: false),
                    Choice = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ques_Choices", x => new { x.Ques_id, x.Choice });
                    table.ForeignKey(
                        name: "FK_Ques_Choices_Questions_Ques_id",
                        column: x => x.Ques_id,
                        principalTable: "Questions",
                        principalColumn: "Q_Id");
                });

            migrationBuilder.CreateTable(
                name: "Exam_Ques_St",
                columns: table => new
                {
                    Ex_id = table.Column<int>(type: "int", nullable: false),
                    Ques_id = table.Column<int>(type: "int", nullable: false),
                    St_id = table.Column<int>(type: "int", nullable: false),
                    St_Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_Ques_St", x => new { x.Ex_id, x.Ques_id, x.St_id });
                    table.ForeignKey(
                        name: "FK_Exam_Ques_St_Exams_Ex_id",
                        column: x => x.Ex_id,
                        principalTable: "Exams",
                        principalColumn: "Ex_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Ques_St_Questions_Ques_id",
                        column: x => x.Ques_id,
                        principalTable: "Questions",
                        principalColumn: "Q_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_Ques_St_Students_St_id",
                        column: x => x.St_id,
                        principalTable: "Students",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseExam",
                columns: table => new
                {
                    St_Id = table.Column<int>(type: "int", nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false),
                    Exam_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseExam", x => new { x.St_Id, x.Crs_Id, x.Exam_Id });
                    table.ForeignKey(
                        name: "FK_StudentCourseExam_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseExam_Exams_Exam_Id",
                        column: x => x.Exam_Id,
                        principalTable: "Exams",
                        principalColumn: "Ex_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseExam_Students_St_Id",
                        column: x => x.St_Id,
                        principalTable: "Students",
                        principalColumn: "St_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Ques_St_Ques_id",
                table: "Exam_Ques_St",
                column: "Ques_id");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Ques_St_St_id",
                table: "Exam_Ques_St",
                column: "St_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseExam_Crs_Id",
                table: "StudentCourseExam",
                column: "Crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseExam_Exam_Id",
                table: "StudentCourseExam",
                column: "Exam_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TrackId",
                table: "Students",
                column: "TrackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exam_Ques_St");

            migrationBuilder.DropTable(
                name: "Ques_Choices");

            migrationBuilder.DropTable(
                name: "StudentCourseExam");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
