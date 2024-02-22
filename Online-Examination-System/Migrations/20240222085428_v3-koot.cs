using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online_Examination_System.Migrations
{
    /// <inheritdoc />
    public partial class v3koot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch_Track",
                columns: table => new
                {
                    B_Id = table.Column<int>(type: "int", nullable: false),
                    Trk_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch_Track", x => new { x.B_Id, x.Trk_Id });
                    table.ForeignKey(
                        name: "FK_Branch_Track_Branches_B_Id",
                        column: x => x.B_Id,
                        principalTable: "Branches",
                        principalColumn: "B_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branch_Track_Tracks_Trk_Id",
                        column: x => x.Trk_Id,
                        principalTable: "Tracks",
                        principalColumn: "Trk_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_Track_Trk_Id",
                table: "Branch_Track",
                column: "Trk_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch_Track");
        }
    }
}
