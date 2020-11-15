using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyExchange.Data.Migrations
{
    public partial class AddPropertiesToSomeModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Offices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Offices");
        }
    }
}
