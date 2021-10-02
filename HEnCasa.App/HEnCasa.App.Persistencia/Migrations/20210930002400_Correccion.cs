using Microsoft.EntityFrameworkCore.Migrations;

namespace HEnCasa.App.Persistencia.Migrations
{
    public partial class Correccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Medico_IdMedico",
                table: "Personas",
                newName: "MedicoId");

            migrationBuilder.RenameColumn(
                name: "IdHistoria",
                table: "Personas",
                newName: "HistoriaId");

            migrationBuilder.RenameColumn(
                name: "IdFamiliarDesignado",
                table: "Personas",
                newName: "FamiliarDesignadoId");

            migrationBuilder.RenameColumn(
                name: "Enfermera_IdEnfermera",
                table: "Personas",
                newName: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_HistoriaId",
                table: "Personas",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_HistoriasClinicas_HistoriaId",
                table: "Personas",
                column: "HistoriaId",
                principalTable: "HistoriasClinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas",
                column: "EnfermeraId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_FamiliarDesignadoId",
                table: "Personas",
                column: "FamiliarDesignadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas",
                column: "MedicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_HistoriasClinicas_HistoriaId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EnfermeraId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_FamiliarDesignadoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_HistoriaId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_MedicoId",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "MedicoId",
                table: "Personas",
                newName: "Medico_IdMedico");

            migrationBuilder.RenameColumn(
                name: "HistoriaId",
                table: "Personas",
                newName: "IdHistoria");

            migrationBuilder.RenameColumn(
                name: "FamiliarDesignadoId",
                table: "Personas",
                newName: "IdFamiliarDesignado");

            migrationBuilder.RenameColumn(
                name: "EnfermeraId",
                table: "Personas",
                newName: "Enfermera_IdEnfermera");
        }
    }
}
