using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Global_Solution.Migrations
{
    /// <inheritdoc />
    public partial class Initial01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cy_consulta_medica",
                columns: table => new
                {
                    IdConsulta = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dataConsulta = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    sintomas = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    diagnostico = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    prescricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_consulta_medica", x => x.IdConsulta);
                });

            migrationBuilder.CreateTable(
                name: "cy_especialidade_medica",
                columns: table => new
                {
                    IdEspecialidade = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nomeEspecialidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_especialidade_medica", x => x.IdEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "cy_feedbacks",
                columns: table => new
                {
                    IdFeedback = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    comentario = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    classificacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_feedbacks", x => x.IdFeedback);
                });

            migrationBuilder.CreateTable(
                name: "cy_historico_medico",
                columns: table => new
                {
                    IdHistorico = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    dataEvento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Notas = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_historico_medico", x => x.IdHistorico);
                });

            migrationBuilder.CreateTable(
                name: "cy_Hospitais",
                columns: table => new
                {
                    IdHospital = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nomeHospital = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    cidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    cep = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Hospitais", x => x.IdHospital);
                });

            migrationBuilder.CreateTable(
                name: "cy_Mensagens",
                columns: table => new
                {
                    idMensagem = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Remetente = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Destinatario = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Mensagem = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dataEnvio = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    lida = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Mensagens", x => x.idMensagem);
                });

            migrationBuilder.CreateTable(
                name: "cy_Notificacoes",
                columns: table => new
                {
                    IdNotificacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    mensagem = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dataEnvio = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    lida = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Notificacoes", x => x.IdNotificacao);
                });

            migrationBuilder.CreateTable(
                name: "cy_Pagamentos",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    valor = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    dataPagamento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    informacoesCartao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Pagamentos", x => x.IdPagamento);
                });

            migrationBuilder.CreateTable(
                name: "cy_Prescricao_Medicas",
                columns: table => new
                {
                    IdPrescricao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Medicamento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dosagem = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    instrucoes = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dataPrescricao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Prescricao_Medicas", x => x.IdPrescricao);
                });

            migrationBuilder.CreateTable(
                name: "cy_Profissionais_Saudes",
                columns: table => new
                {
                    IdProfissional = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    especialidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RegistroMedico = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Profissionais_Saudes", x => x.IdProfissional);
                });

            migrationBuilder.CreateTable(
                name: "cy_Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    sexo = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    cy_profissionais_saudeIdProfissional = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cy_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_cy_Usuarios_cy_Profissionais_Saudes_cy_profissionais_saudeIdProfissional",
                        column: x => x.cy_profissionais_saudeIdProfissional,
                        principalTable: "cy_Profissionais_Saudes",
                        principalColumn: "IdProfissional");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cy_Usuarios_cy_profissionais_saudeIdProfissional",
                table: "cy_Usuarios",
                column: "cy_profissionais_saudeIdProfissional");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cy_consulta_medica");

            migrationBuilder.DropTable(
                name: "cy_especialidade_medica");

            migrationBuilder.DropTable(
                name: "cy_feedbacks");

            migrationBuilder.DropTable(
                name: "cy_historico_medico");

            migrationBuilder.DropTable(
                name: "cy_Hospitais");

            migrationBuilder.DropTable(
                name: "cy_Mensagens");

            migrationBuilder.DropTable(
                name: "cy_Notificacoes");

            migrationBuilder.DropTable(
                name: "cy_Pagamentos");

            migrationBuilder.DropTable(
                name: "cy_Prescricao_Medicas");

            migrationBuilder.DropTable(
                name: "cy_Usuarios");

            migrationBuilder.DropTable(
                name: "cy_Profissionais_Saudes");
        }
    }
}
