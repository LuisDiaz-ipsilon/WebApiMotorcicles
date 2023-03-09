using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMotorcicles.Migrations
{
    public partial class Motor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motocicletas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Piel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motocicletas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tamaño = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Turbo = table.Column<bool>(type: "bit", nullable: false),
                    MotorcicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motores_Motocicletas_MotorcicleId",
                        column: x => x.MotorcicleId,
                        principalTable: "Motocicletas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motores_MotorcicleId",
                table: "Motores",
                column: "MotorcicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motores");

            migrationBuilder.DropTable(
                name: "Motocicletas");
        }
    }
}
