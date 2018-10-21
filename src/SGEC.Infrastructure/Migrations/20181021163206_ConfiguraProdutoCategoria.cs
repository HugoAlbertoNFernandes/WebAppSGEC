using Microsoft.EntityFrameworkCore.Migrations;

namespace SGEC.Infrastructure.Migrations
{
    public partial class ConfiguraProdutoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl5",
                table: "Produto",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl4",
                table: "Produto",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl3",
                table: "Produto",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl2",
                table: "Produto",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl1",
                table: "Produto",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Produto",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoLoga",
                table: "Produto",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoCurta",
                table: "Produto",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefone1",
                table: "Cliente",
                type: "varchar(21)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Cliente",
                type: "varchar(21)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlString",
                table: "Categoria",
                type: "varchar(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categoria",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl5",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl4",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl3",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl2",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl1",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoLoga",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DescricaoCurta",
                table: "Produto",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "telefone1",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(21)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefone",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(21)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "UrlString",
                table: "Categoria",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(400)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categoria",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
