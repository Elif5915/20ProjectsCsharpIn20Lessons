using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiWeather_6.Migrations
{
	public partial class mig1 : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Cities",
				columns: table => new
				{
					CityId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					CityName = table.Column<string>(type: "nvarchar(70)", nullable: false),
					Country = table.Column<string>(type: "nvarchar(70)", nullable: false),
					Temp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					Detail = table.Column<string>(type: "nvarchar(150)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Cities", x => x.CityId);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Cities");
		}
	}
}
