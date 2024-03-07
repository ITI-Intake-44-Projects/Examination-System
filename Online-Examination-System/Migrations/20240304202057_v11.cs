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
            //migrationBuilder.DropColumn(
            //    name: "Password",
            //    table: "Tracks");

            //migrationBuilder.DropColumn(
            //    name: "Username",
            //    table: "Tracks");

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserName",
            //    table: "Students",
            //    type: "nvarchar(50)",
            //    maxLength: 50,
            //    nullable: false,
            //    defaultValue: "",
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(50)",
            //    oldMaxLength: 50,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Passowrd",
            //    table: "Students",
            //    type: "nvarchar(20)",
            //    maxLength: 20,
            //    nullable: false,
            //    defaultValue: "",
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(20)",
            //    oldMaxLength: 20,
            //    oldNullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Password",
            //    table: "Instructors",
            //    type: "nvarchar(20)",
            //    maxLength: 20,
            //    nullable: false,
            //    defaultValue: "");

            //migrationBuilder.AddColumn<string>(
            //    name: "Username",
            //    table: "Instructors",
            //    type: "nvarchar(20)",
            //    maxLength: 20,
            //    nullable: false,
            //    defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserName",
                table: "Students",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Username",
                table: "Instructors",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_UserName",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Username",
                table: "Instructors");

            //migrationBuilder.DropColumn(
            //    name: "Password",
            //    table: "Instructors");

            //migrationBuilder.DropColumn(
            //    name: "Username",
            //    table: "Instructors");

            //migrationBuilder.AddColumn<string>(
            //    name: "Password",
            //    table: "Tracks",
            //    type: "nvarchar(20)",
            //    maxLength: 20,
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "Username",
            //    table: "Tracks",
            //    type: "nvarchar(20)",
            //    maxLength: 20,
            //    nullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "UserName",
            //    table: "Students",
            //    type: "nvarchar(50)",
            //    maxLength: 50,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(50)",
            //    oldMaxLength: 50);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Passowrd",
            //    table: "Students",
            //    type: "nvarchar(20)",
            //    maxLength: 20,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(20)",
            //    oldMaxLength: 20);
        }
    }
}
