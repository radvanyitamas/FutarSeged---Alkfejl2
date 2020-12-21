using Microsoft.EntityFrameworkCore.Migrations;

namespace FutarSeged.Data.Migrations
{
    public partial class OrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressPostCode = table.Column<string>(nullable: false),
                    AddressCity = table.Column<string>(nullable: false),
                    AddressStreetName = table.Column<string>(nullable: false),
                    AddressHouseNumber = table.Column<int>(nullable: false),
                    AddressDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
