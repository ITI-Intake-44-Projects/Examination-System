using Microsoft.EntityFrameworkCore.Migrations;


namespace Online_Examination_System.Migrations
{
    public partial class Reportv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Stored procedures for branches

            migrationBuilder.Sql(@"
CREATE PROCEDURE GetCourseTopics --done
    @Crs_ID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Topic_Name
    FROM Course_Topics
    WHERE Crs_ID = @Crs_ID;
END;
            ");

            migrationBuilder.Sql(@"
CREATE PROCEDURE GetStudentsByTrack --done 
    @TrackId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM Students
    WHERE TrackId = @TrackId;
END;
            ");

            migrationBuilder.Sql(@"
create PROCEDURE GetStudentGrades
    @StudentId INT
AS
BEGIN
    SELECT s.St_Id, 
           s.Fname + ' ' + s.Lname AS StudentName,
           c.Crs_ID, 
           c.Name AS CourseName,
           sce.Grade * 100.0 / e.TotalGrade AS GradePercentage
    FROM Students s
    INNER JOIN StudentCourseExam sce ON s.St_Id = sce.St_Id
    INNER JOIN Courses c ON sce.Crs_Id = c.Crs_ID
    INNER JOIN Exams e ON sce.Exam_Id = e.Ex_Id
    WHERE s.St_Id = @StudentId;
END;
            ");

            migrationBuilder.Sql(@"
Create PROCEDURE GetCoursesAndStudentCountByInstructorID --done
    @InstructorID INT
AS
BEGIN
    SELECT 
        C.Name AS CourseName,
		C.Duration,
		C.Grade,
        COUNT(DISTINCT SCE.St_Id) AS StudentCount
    FROM 
        Instructor_Course IC
    INNER JOIN 
        Courses C ON IC.CourseId = C.Crs_ID
    LEFT JOIN 
        StudentCourseExam SCE ON IC.CourseId = SCE.Crs_Id
    WHERE 
        IC.InstructorId = @InstructorID
    GROUP BY 
        C.Name,C.Duration,C.Grade;
END;
            ");

            migrationBuilder.Sql(@"
CREATE PROCEDURE GetExamQuestionsWithStudentAnswers --done
    @ExamId INT,
    @StudentId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Q.Q_Id,
        Q.Name AS Question,
        Q.[type] AS QuestionType,
        Q.Marks AS Marks,
        Q.ModelAns AS ModelAnswer,
        EQS.St_Answer AS StudentAnswer
    FROM 
        Exam_Ques_St EQS
    INNER JOIN 
        Questions Q ON EQS.Ques_id = Q.Q_Id
    WHERE 
        EQS.Ex_id = @ExamId
        AND EQS.St_id = @StudentId;
END;
            ");

            migrationBuilder.Sql(@"
Create PROCEDURE GetExamQuestionsAndChoices --done
    @ExamNumber INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Q.Q_Id AS QuestionID,
        Q.Name AS Question,
        Q.[type] AS QuestionType,
        Q.Marks AS Marks,
        Q.ModelAns AS ModelAnswer,
        STRING_AGG(QC.Choice, ', ') AS Choices
    FROM
        Exams E
    INNER JOIN
        Exam_Ques_St EQS ON E.Ex_Id = EQS.Ex_id
    INNER JOIN
        Questions Q ON EQS.Ques_id = Q.Q_Id
    LEFT JOIN
        Ques_Choices QC ON Q.Q_Id = QC.Ques_id
    WHERE
        E.Ex_Id = @ExamNumber
    GROUP BY
        Q.Q_Id, Q.Name, Q.[type], Q.Marks, Q.ModelAns;
END;
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop stored procedures during rollback

            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetCourseTopics");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetStudentsByTrack");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetStudentGrades");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetCoursesAndStudentCountByInstructorID");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetExamQuestionsWithStudentAnswers");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetExamQuestionsAndChoices");

        }
    }
}