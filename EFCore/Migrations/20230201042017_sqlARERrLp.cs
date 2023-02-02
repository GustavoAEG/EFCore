using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class sqlARERrLp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TipoSocioL",
                newName: "TipoSocioId");

            migrationBuilder.AddColumn<int>(
                name: "TipoSociosTipoSocioId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoSociosTipoSocioId",
                table: "Alunos",
                column: "TipoSociosTipoSocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoSocioL_TipoSociosTipoSocioId",
                table: "Alunos",
                column: "TipoSociosTipoSocioId",
                principalTable: "TipoSocioL",
                principalColumn: "TipoSocioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoSocioL_TipoSociosTipoSocioId",
                table: "Alunos");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoSociosTipoSocioId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TipoSociosTipoSocioId",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "TipoSocioId",
                table: "TipoSocioL",
                newName: "Id");
        }
    }
}
