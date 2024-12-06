using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentLoginPortal.Migrations
{
    /// <inheritdoc />
    public partial class StudenttoHobby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
            name: "HId",
            table: "StudentDetail",
            nullable: false,
            defaultValue: 0);

            migrationBuilder.AddForeignKey(
                          name: "FK_StudentDetail_StudentHobby_HId",
                          table: "StudentDetail",
                          column: "HId",
                          principalTable: "StudentHobby",
                          principalColumn: "Hid",
                          onDelete: ReferentialAction.Cascade);

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetail_Hid",
                table: "StudentDetail",
                column: "Hid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetail");

            migrationBuilder.DropTable(
                name: "StudentHobby");
        }
    }
}
