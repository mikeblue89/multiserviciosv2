using Microsoft.EntityFrameworkCore.Migrations;

namespace Multiservicios.Data.Migrations
{
    public partial class AddPuestoToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    DepartamentoId = table.Column<int>(nullable: false),
                    AreaTrabajoId = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puesto_AreaTrabajo_AreaId",
                        column: x => x.AreaId,
                        principalTable: "AreaTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Puesto_Departamento_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_AreaId",
                table: "Puesto",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_DepartamentoId",
                table: "Puesto",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Puesto");
        }
    }
}
