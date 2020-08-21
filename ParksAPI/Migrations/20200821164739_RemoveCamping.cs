using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class RemoveCamping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Camping",
                table: "Parks");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "Type", "Website" },
                values: new object[,]
                {
                    { 1, "Crater Lake National Park", "Oregon", "national", "https://www.nps.gov/crla/index.htm" },
                    { 21, "Zion National Park", "Nevada", "national", "https://www.nps.gov/zion/index.htm" },
                    { 20, "Capiton Reef National Park", "Nevada", "national", "https://www.nps.gov/care/index.htm" },
                    { 19, "Canyonlands National Park", "Utah", "national", "https://www.nps.gov/cany/index.htm" },
                    { 18, "Bryce Canyon National Park", "Utah", "national", "https://www.nps.gov/brca/index.htm" },
                    { 17, "Arches National Park", "Utah", "national", "https://www.nps.gov/arch/index.htm" },
                    { 16, "Great Basin National Park", "Nevada", "national", "https://www.nps.gov/grba/index.htm" },
                    { 15, "Yosemite National Park", "California", "national", "https://www.nps.gov/yose/index.htm" },
                    { 14, "Sequoia and King's Canyon National Park", "California", "national", "https://www.nps.gov/seki/index.htm" },
                    { 13, "Redwood National Park", "California", "national", "https://www.nps.gov/redw/index.htm" },
                    { 22, "Great Basin National Park", "Nevada", "national", "https://www.nps.gov/grba/index.htm" },
                    { 12, "Pinnacles National Park", "California", "national", "https://www.nps.gov/pinn/index.htm" },
                    { 10, "Joshua Tree National Park", "California", "national", "https://www.nps.gov/jotr/index.htm" },
                    { 9, "Death Valley National Park", "California", "national", "https://www.nps.gov/deva/index.htm" },
                    { 8, "Channel Islands National Park", "California", "national", "https://www.nps.gov/glac/index.htm" },
                    { 7, "Glacier National Park", "Montana", "national", "https://www.nps.gov/glac/index.htm" },
                    { 6, "Grand Teton National Park", "Wyoming", "national", "https://www.nps.gov/grte/index.htm" },
                    { 5, "Yellowstone National Park", "Wyoming", "national", "https://www.nps.gov/yell/index.htm" },
                    { 4, "Olymic National Park", "Washington", "national", "https://www.nps.gov/olym/index.htm" },
                    { 3, "North Cascades National Park", "Washington", "national", "https://www.nps.gov/noca/index.htm" },
                    { 2, "Mount Rainier National Park", "Washington", "national", "https://www.nps.gov/mora/index.htm" },
                    { 11, "Lassen Volcanic National Park", "California", "national", "https://www.nps.gov/lavo/index.htm" },
                    { 23, "Great Basin National Park", "Nevada", "national", "https://www.nps.gov/grba/index.htm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.AddColumn<bool>(
                name: "Camping",
                table: "Parks",
                nullable: false,
                defaultValue: false);
        }
    }
}
