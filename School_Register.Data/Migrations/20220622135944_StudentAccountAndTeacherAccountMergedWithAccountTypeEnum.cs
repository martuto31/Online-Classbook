using Microsoft.EntityFrameworkCore.Migrations;

namespace School_Register.Data.Migrations
{
    public partial class StudentAccountAndTeacherAccountMergedWithAccountTypeEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountType",
                table: "studentAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountType",
                table: "studentAccounts");
        }
    }
}
