using Microsoft.EntityFrameworkCore.Migrations;

namespace SGEC.Infrastructure.Migrations
{
    public partial class inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefone",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefone1",
                table: "Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "telefone",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "telefone1",
                table: "Cliente");
        }
    }
}
