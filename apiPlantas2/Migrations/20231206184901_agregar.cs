using Microsoft.EntityFrameworkCore.Migrations;

namespace apiPlantas2.Migrations
{
    public partial class agregar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HumedadD",
                table: "Planta_Reportes");

            migrationBuilder.DropColumn(
                name: "TamañoD",
                table: "Planta_Reportes");

            migrationBuilder.DropColumn(
                name: "TemperaturaD",
                table: "Planta_Reportes");

            migrationBuilder.AddColumn<int>(
                name: "HumedadId",
                table: "Planta_Reportes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TamañoId",
                table: "Planta_Reportes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemperaturaId",
                table: "Planta_Reportes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Humedad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HumedadDetectada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humedad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tamaño",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TamañoDetectada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamaño", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temperatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemperaturaDetectada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperatura", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planta_Reportes_HumedadId",
                table: "Planta_Reportes",
                column: "HumedadId");

            migrationBuilder.CreateIndex(
                name: "IX_Planta_Reportes_TamañoId",
                table: "Planta_Reportes",
                column: "TamañoId");

            migrationBuilder.CreateIndex(
                name: "IX_Planta_Reportes_TemperaturaId",
                table: "Planta_Reportes",
                column: "TemperaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_Reportes_Humedad_HumedadId",
                table: "Planta_Reportes",
                column: "HumedadId",
                principalTable: "Humedad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_Reportes_Tamaño_TamañoId",
                table: "Planta_Reportes",
                column: "TamañoId",
                principalTable: "Tamaño",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_Reportes_Temperatura_TemperaturaId",
                table: "Planta_Reportes",
                column: "TemperaturaId",
                principalTable: "Temperatura",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_Reportes_Humedad_HumedadId",
                table: "Planta_Reportes");

            migrationBuilder.DropForeignKey(
                name: "FK_Planta_Reportes_Tamaño_TamañoId",
                table: "Planta_Reportes");

            migrationBuilder.DropForeignKey(
                name: "FK_Planta_Reportes_Temperatura_TemperaturaId",
                table: "Planta_Reportes");

            migrationBuilder.DropTable(
                name: "Humedad");

            migrationBuilder.DropTable(
                name: "Tamaño");

            migrationBuilder.DropTable(
                name: "Temperatura");

            migrationBuilder.DropIndex(
                name: "IX_Planta_Reportes_HumedadId",
                table: "Planta_Reportes");

            migrationBuilder.DropIndex(
                name: "IX_Planta_Reportes_TamañoId",
                table: "Planta_Reportes");

            migrationBuilder.DropIndex(
                name: "IX_Planta_Reportes_TemperaturaId",
                table: "Planta_Reportes");

            migrationBuilder.DropColumn(
                name: "HumedadId",
                table: "Planta_Reportes");

            migrationBuilder.DropColumn(
                name: "TamañoId",
                table: "Planta_Reportes");

            migrationBuilder.DropColumn(
                name: "TemperaturaId",
                table: "Planta_Reportes");

            migrationBuilder.AddColumn<string>(
                name: "HumedadD",
                table: "Planta_Reportes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TamañoD",
                table: "Planta_Reportes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemperaturaD",
                table: "Planta_Reportes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
