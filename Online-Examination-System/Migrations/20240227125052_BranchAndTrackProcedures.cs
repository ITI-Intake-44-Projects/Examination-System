using Microsoft.EntityFrameworkCore.Migrations;


namespace Online_Examination_System.Migrations
{
    public partial class BranchAndTrackProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Stored procedures for branches

            migrationBuilder.Sql(@"
                CREATE PROCEDURE SelectAllBranches
                AS
                BEGIN
                    SELECT * FROM Branches;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE SelectBranchById
                    @B_ID INT
                AS
                BEGIN
                    SELECT * FROM Branches WHERE B_ID = @B_ID;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE InsertBranch
                    @Name NVARCHAR(50),
                    @Location NVARCHAR(50)
                AS
                BEGIN
                    INSERT INTO Branches (Name, Location) 
                    VALUES (@Name, @Location);
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE UpdateBranch
                    @B_ID INT,
                    @Name NVARCHAR(50),
                    @Location NVARCHAR(50)
                AS
                BEGIN
                    UPDATE Branches 
                    SET Name = @Name, Location = @Location
                    WHERE B_ID = @B_ID;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE DeleteBranch
                    @B_ID INT
                AS
                BEGIN
                    DELETE FROM Branches WHERE B_ID = @B_ID;
                END
            ");

            // Stored procedures for tracks

            migrationBuilder.Sql(@"
                CREATE PROCEDURE SelectAllTracks
                AS
                BEGIN
                    SELECT * FROM Tracks;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE SelectTrackById
                    @Trk_ID INT
                AS
                BEGIN
                    SELECT * FROM Tracks WHERE Trk_ID = @Trk_ID;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE InsertTrack
                    @Name NVARCHAR(50),
                    @Capacity INT,
                    @Duration INT,
                    @Username NVARCHAR(20),
                    @Password NVARCHAR(20),
                    @SuperID INT
                AS
                BEGIN
                    INSERT INTO Tracks (Name, Capacity, Duration, Username, Password, SuperID) 
                    VALUES (@Name, @Capacity, @Duration, @Username, @Password, @SuperID);
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE UpdateTrack
                    @Trk_ID INT,
                    @Name NVARCHAR(50),
                    @Capacity INT,
                    @Duration INT,
                    @Username NVARCHAR(20),
                    @Password NVARCHAR(20),
                    @SuperID INT
                AS
                BEGIN
                    UPDATE Tracks 
                    SET Name = @Name, Capacity = @Capacity, Duration = @Duration, 
                        Username = @Username, Password = @Password, SuperID = @SuperID 
                    WHERE Trk_ID = @Trk_ID;
                END
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE DeleteTrack
                    @Trk_ID INT
                AS
                BEGIN
                    DELETE FROM Tracks WHERE Trk_ID = @Trk_ID;
                END
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop stored procedures during rollback

            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectAllBranches");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectBranchById");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS InsertBranch");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS UpdateBranch");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteBranch");

            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectAllTracks");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS SelectTrackById");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS InsertTrack");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS UpdateTrack");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS DeleteTrack");
        }
    }
}