using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_List.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lista",
                columns: table => new
                {
                    ListaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lista", x => x.ListaId);
                });

            migrationBuilder.CreateTable(
                name: "ElementoLista",
                columns: table => new
                {
                    ElementoListaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListaId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Concluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementoLista", x => x.ElementoListaId);
                    table.ForeignKey(
                        name: "FK_ElementoLista_Lista_ListaId",
                        column: x => x.ListaId,
                        principalTable: "Lista",
                        principalColumn: "ListaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementoLista_ListaId",
                table: "ElementoLista",
                column: "ListaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementoLista");

            migrationBuilder.DropTable(
                name: "Lista");
        }
    }
}
