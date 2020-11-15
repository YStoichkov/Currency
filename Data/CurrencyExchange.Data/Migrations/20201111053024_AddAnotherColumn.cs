namespace CurrencyExchange.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddAnotherColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyImage",
                table: "Currencies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyImage",
                table: "Currencies");
        }
    }
}
