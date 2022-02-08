using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wejobr.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    Id_candidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nascimento_candidato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_civil_candidato = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nacionalidade_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rne_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Idioma_candidato = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Senha_candidato = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cargo1_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cargo2_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cargo3_candidato = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.Id_candidato);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id_empresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_vaga = table.Column<int>(type: "int", nullable: false),
                    Nome_empresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cnpj_empresa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cep_empresa = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Ramo_empresa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Telefone_empresa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Linkedin_empresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id_empresa);
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id_idioma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_idioma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nivel_leitura_idioma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nivel_escrita_idioma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nivel_conversacao_idioma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.Id_idioma);
                });

            migrationBuilder.CreateTable(
                name: "Recrutador",
                columns: table => new
                {
                    Id_recrutador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_empresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Id_empresa = table.Column<int>(type: "int", nullable: false),
                    Nome_recrutador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cargo_recrutador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Departamento_recrutador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email_recrutador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tel_recrutador = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Contato2_recrutador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Senha_recrutador = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recrutador", x => x.Id_recrutador);
                });

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    Cod_vaga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_empresa = table.Column<int>(type: "int", nullable: false),
                    Cargo_vaga = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao_vaga = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Salario_vaga = table.Column<double>(type: "float", nullable: false),
                    Vaga_pcd = table.Column<bool>(type: "bit", nullable: false),
                    Nivel_instrucao_vaga = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Localidade_vaga = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Regime_contratacao_vaga = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.Cod_vaga);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "Recrutador");

            migrationBuilder.DropTable(
                name: "Vaga");
        }
    }
}
