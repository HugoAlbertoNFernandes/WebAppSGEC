using Microsoft.EntityFrameworkCore.Migrations;

namespace SGEC.Infrastructure.Migrations
{
    public partial class AlteraUsuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Perfil_PerfilId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "idUser",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "PerfilId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Perfil_PerfilId",
                table: "User",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "PerfilId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Perfil_PerfilId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "PerfilId",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "idUser",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Perfil_PerfilId",
                table: "User",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "PerfilId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
