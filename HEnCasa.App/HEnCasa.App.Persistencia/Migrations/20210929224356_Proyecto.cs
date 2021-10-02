using Microsoft.EntityFrameworkCore.Migrations;

namespace HEnCasa.App.Persistencia.Migrations
{
    public partial class Proyecto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Enfermera_IdEnfermera",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidad",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaNacimiento",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorasLaborales",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEnfermera",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFamiliarDesigando",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFamiliarDesignado",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdHistoria",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMedico",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitud",
                table: "Personas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitud",
                table: "Personas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Medico_IdMedico",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parentesco",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TarjetaProfesional",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dolor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saturacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RitmoCardiaco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresionArterial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciasCuidado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasCuidado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignoVitalId = table.Column<int>(type: "int", nullable: true),
                    SugerenciaCuidadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_SignosVitales_SignoVitalId",
                        column: x => x.SignoVitalId,
                        principalTable: "SignosVitales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_SugerenciasCuidado_SugerenciaCuidadoId",
                        column: x => x.SugerenciaCuidadoId,
                        principalTable: "SugerenciasCuidado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_SignoVitalId",
                table: "HistoriasClinicas",
                column: "SignoVitalId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_SugerenciaCuidadoId",
                table: "HistoriasClinicas",
                column: "SugerenciaCuidadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "SugerenciasCuidado");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Enfermera_IdEnfermera",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Especialidad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "HorasLaborales",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdEnfermera",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdFamiliarDesigando",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdFamiliarDesignado",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdHistoria",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdMedico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Medico_IdMedico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Parentesco",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TarjetaProfesional",
                table: "Personas");
        }
    }
}
