using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class Campground : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campgrounds",
                columns: table => new
                {
                    CampgroundId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ParkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campgrounds", x => x.CampgroundId);
                    table.ForeignKey(
                        name: "FK_Campgrounds_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campgrounds",
                columns: new[] { "CampgroundId", "Name", "ParkId", "State" },
                values: new object[] { 1, "Cougar Rock Campground", 2, "Washington" });

            migrationBuilder.InsertData(
                table: "Campgrounds",
                columns: new[] { "CampgroundId", "Name", "ParkId", "State" },
                values: new object[] { 2, "Mowich Lake", 2, "Washington" });

            migrationBuilder.InsertData(
                table: "Campgrounds",
                columns: new[] { "CampgroundId", "Name", "ParkId", "State" },
                values: new object[] { 3, "La Wis Wis", 2, "Washington" });

            migrationBuilder.CreateIndex(
                name: "IX_Campgrounds_ParkId",
                table: "Campgrounds",
                column: "ParkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campgrounds");
        }
    }
}
