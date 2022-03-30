using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripLog1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: false),
                    Accommodations = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Things = table.Column<string>(nullable: true),
                    Things1 = table.Column<string>(nullable: true),
                    Things2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripID", "Accommodations", "Destination", "Email", "EndDate", "Phone", "StartDate", "Things", "Things1", "Things2" },
                values: new object[] { 1, "", "Boise", null, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), " Visit Tammy", "", "" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripID", "Accommodations", "Destination", "Email", "EndDate", "Phone", "StartDate", "Things", "Things1", "Things2" },
                values: new object[] { 2, "The Benson", "Portland", "staff@bensonhotel.com", new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "503-555-1234", new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go to Vodoo Doughnuts", "Walk in the rain", "Go to Powell's" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
