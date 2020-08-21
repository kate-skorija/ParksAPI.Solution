using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22,
                columns: new[] { "Name", "State", "Website" },
                values: new object[] { "Grand Canton National Park", "Arizona", "https://www.nps.gov/grca/index.htm" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23,
                columns: new[] { "Name", "State", "Website" },
                values: new object[] { "Saguaro National Park", "Arizona", "https://www.nps.gov/sagu/index.htm" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "Type", "Website" },
                values: new object[,]
                {
                    { 48, "Kodachrome Basin State Park", "Utah", "state", "https://stateparks.utah.gov/parks/kodachrome-basin/" },
                    { 47, "Snow Canyon State Park", "Utah", "state", "https://stateparks.utah.gov/parks/snow-canyon/" },
                    { 46, "Arkansas Headwaters State Park", "Colorado", "state", "https://cpw.state.co.us/placestogo/parks/ArkansasHeadwatersRecreationArea" },
                    { 45, "Eldorado Canyon State Park", "Colorado", "state", "https://cpw.state.co.us/placestogo/parks/EldoradoCanyon" },
                    { 44, "Eleven Mile State Park", "Colorado", "state", "https://cpw.state.co.us/placestogo/parks/ElevenMile" },
                    { 43, "Thompson Falls State Park", "Montana", "state", "http://stateparks.mt.gov/thompson-falls/" },
                    { 42, "Painted Rocks State Park", "Montana", "state", "http://stateparks.mt.gov/painted-rocks/" },
                    { 41, "Harriman State Park", "Idaho", "state", "https://parksandrecreation.idaho.gov/parks/harriman" },
                    { 40, "Priest Lake State Park", "Idaho", "state", "https://parksandrecreation.idaho.gov/parks/priest-lake" },
                    { 39, "Julia Pfeiffer Burns State Park", "California", "state", "https://www.parks.ca.gov/?page_id=578" },
                    { 38, "Crystal Cove State Park", "California", "state", "http://www.parks.ca.gov/?page_id=644" },
                    { 37, "Sun Lakes Dry Falls State Park", "Washington", "state", "https://www.parks.wa.gov/298/Sun-Lakes-Dry-Falls" },
                    { 36, "Flaming Geyser State Park", "Washington", "state", "https://www.parks.wa.gov/504/Flaming-Geyser" },
                    { 35, "Cape Disappointment River State Park", "Washington", "state", "https://www.parks.wa.gov/486/Cape-Disappointment" },
                    { 34, "Smith Rock State Park", "Oregon", "state", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=36" },
                    { 33, "Ecola State Park", "Oregon", "state", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=136" },
                    { 32, "Valley of the Rogue River State Park", "Oregon", "state", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=76" },
                    { 31, "Wind Cave National Park", "South Dakota", "national", "https://www.nps.gov/wica/index.htm" },
                    { 30, "Badlands National Park", "South Dakota", "national", "https://www.nps.gov/badl/index.htm" },
                    { 29, "Theodore Roosevelt National Park", "North Dakota", "national", "https://www.nps.gov/thro/index.htm" },
                    { 28, "Carlsbad Caverns National Park", "New Mexico", "national", "https://www.nps.gov/cave/index.htm" },
                    { 27, "Rocky Mountain National Park", "Colorado", "national", "https://www.nps.gov/romo/index.htm" },
                    { 26, "Mesa Verde National Park", "Colorado", "national", "https://www.nps.gov/meve/index.htm" },
                    { 25, "Great Sand Dunes National Park", "Colorado", "national", "https://www.nps.gov/grsa/index.htm" },
                    { 24, "Black Canyon of the Gunnison National Park", "Colorado", "national", "https://www.nps.gov/blca/index.htm" },
                    { 49, "Coral Pink Sand Dunes State Park", "Utah", "state", "https://stateparks.utah.gov/parks/coral-pink/" },
                    { 50, "Dead Horse Point State Park", "Utah", "state", "https://stateparks.utah.gov/parks/dead-horse/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22,
                columns: new[] { "Name", "State", "Website" },
                values: new object[] { "Great Basin National Park", "Nevada", "https://www.nps.gov/grba/index.htm" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23,
                columns: new[] { "Name", "State", "Website" },
                values: new object[] { "Great Basin National Park", "Nevada", "https://www.nps.gov/grba/index.htm" });
        }
    }
}
