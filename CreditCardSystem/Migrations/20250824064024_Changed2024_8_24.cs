using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CreditCardSystem.Migrations
{
    /// <inheritdoc />
    public partial class Changed2024_8_24 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Parties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Parties",
                type: "TEXT",
                nullable: true);
        }
    }
}
