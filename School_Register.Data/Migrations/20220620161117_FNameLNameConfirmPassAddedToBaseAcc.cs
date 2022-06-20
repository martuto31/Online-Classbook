using Microsoft.EntityFrameworkCore.Migrations;

namespace School_Register.Data.Migrations
{
    public partial class FNameLNameConfirmPassAddedToBaseAcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "studentAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "studentAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "studentAccounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "studentAccounts");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "studentAccounts");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "studentAccounts");
        }
    }
}
