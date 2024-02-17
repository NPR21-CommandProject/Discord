using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_tblFriends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblFriends",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Friend1ID = table.Column<int>(type: "int", nullable: false),
                    Friend2ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFriends", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tblFriends_tblUsers_Friend1ID",
                        column: x => x.Friend1ID,
                        principalTable: "tblUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblFriends_tblUsers_Friend2ID",
                        column: x => x.Friend2ID,
                        principalTable: "tblUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblFriends_Friend1ID",
                table: "tblFriends",
                column: "Friend1ID");

            migrationBuilder.CreateIndex(
                name: "IX_tblFriends_Friend2ID",
                table: "tblFriends",
                column: "Friend2ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFriends");
        }
    }
}
