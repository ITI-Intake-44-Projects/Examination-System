using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class coursestudentsp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Stored procedure for selecting all students
            migrationBuilder.Sql(@"
            CREATE PROCEDURE SelectAllStudents
            AS
            BEGIN
                SELECT * FROM Students;
            END
        ");

            // Stored procedure for selecting a student by ID
            migrationBuilder.Sql(@"
            CREATE PROCEDURE SelectStudentById
                @St_Id INT
            AS
            BEGIN
                SELECT * FROM Students WHERE St_Id = @St_Id;
            END
        ");

            // Stored procedure for inserting a new student
            migrationBuilder.Sql(@"
            CREATE PROCEDURE InsertStudent
                @Fname NVARCHAR(50),
                @Lname NVARCHAR(50),
                @BirthDate DATE,
                @Address NVARCHAR(50),
                @Mobile NVARCHAR(50),
                @Faculty NVARCHAR(50),
                @Gender NVARCHAR(20),
                @UserName NVARCHAR(50),
                @Passowrd NVARCHAR(20),
                @TrackId INT
            AS
            BEGIN
                INSERT INTO Students (Fname, Lname, BirthDate, Address, Mobile, Faculty, Gender, UserName, Passowrd, TrackId)
                VALUES (@Fname, @Lname, @BirthDate, @Address, @Mobile, @Faculty, @Gender, @UserName, @Passowrd, @TrackId);
            END
        ");

            // Stored procedure for updating a student
            migrationBuilder.Sql(@"
            CREATE PROCEDURE UpdateStudent
                @St_Id INT,
                @Fname NVARCHAR(50),
                @Lname NVARCHAR(50),
                @BirthDate DATE,
                @Address NVARCHAR(50),
                @Mobile NVARCHAR(50),
                @Faculty NVARCHAR(50),
                @Gender NVARCHAR(20),
                @UserName NVARCHAR(50),
                @Passowrd NVARCHAR(20),
                @TrackId INT
            AS
            BEGIN
                UPDATE Students SET 
                    Fname = @Fname,
                    Lname = @Lname,
                    BirthDate = @BirthDate,
                    Address = @Address,
                    Mobile = @Mobile,
                    Faculty = @Faculty,
                    Gender = @Gender,
                    UserName = @UserName,
                    Passowrd = @Passowrd,
                    TrackId = @TrackId
                WHERE St_Id = @St_Id;
            END
        ");

            // Stored procedure for deleting a student by ID
            migrationBuilder.Sql(@"
            CREATE PROCEDURE DeleteStudent
                @St_Id INT
            AS
            BEGIN
                DELETE FROM Students WHERE St_Id = @St_Id;
            END
        ");


            //sp for course 


            // Create stored procedure for selecting a course by ID
            migrationBuilder.Sql(@"
            CREATE PROCEDURE SelectAllCourses
            AS
            BEGIN
                SELECT * FROM Courses;
            END
        ");

            migrationBuilder.Sql(@"
            CREATE PROCEDURE SelectCourse
                @Crs_ID INT
            AS
            BEGIN
                SELECT * FROM Courses WHERE Crs_ID = @Crs_ID;
            END
        ");

            // Create stored procedure for inserting a new course
            migrationBuilder.Sql(@"
            CREATE PROCEDURE InsertCourse
                @Name NVARCHAR(50),
                @Duration INT,
                @Grade INT
            AS
            BEGIN
                INSERT INTO Courses (Name, Duration, Grade) VALUES (@Name, @Duration, @Grade);
            END
        ");

            // Create stored procedure for deleting a course by ID
            migrationBuilder.Sql(@"
            CREATE PROCEDURE DeleteCourse
                @Crs_ID INT
            AS
            BEGIN
                DELETE FROM Courses WHERE Crs_ID = @Crs_ID;
            END
        ");

            // Create stored procedure for updating a course
            migrationBuilder.Sql(@"
            CREATE PROCEDURE UpdateCourse
                @Crs_ID INT,
                @Name NVARCHAR(50),
                @Duration INT,
                @Grade INT
            AS
            BEGIN
                UPDATE Courses SET Name = @Name, Duration = @Duration, Grade = @Grade WHERE Crs_ID = @Crs_ID;
            END
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop stored procedures during rollback
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectAllStudents");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectStudentById");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS InsertStudent");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS UpdateStudent");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteStudent");
            // drop for course
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectCourse");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS InsertCourse");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteCourse");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS UpdateCourse");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectAllCourses");
        }
    }
}
