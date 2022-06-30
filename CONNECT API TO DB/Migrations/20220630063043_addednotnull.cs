using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CONNECT_API_TO_DB.Migrations
{
    public partial class addednotnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClassRooms",
                type: "Varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(20)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClassRooms",
                type: "Varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");
        }
    }
}
