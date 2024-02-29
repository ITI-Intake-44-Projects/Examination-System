using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Crs_Id",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Crs_Id",
                table: "Questions",
                column: "Crs_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Courses_Crs_Id",
                table: "Questions",
                column: "Crs_Id",
                principalTable: "Courses",
                principalColumn: "Crs_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Courses_Crs_Id",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_Crs_Id",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Crs_Id",
                table: "Questions");
        }
    }
}
