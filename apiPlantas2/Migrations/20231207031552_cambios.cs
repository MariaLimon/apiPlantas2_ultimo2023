using Microsoft.EntityFrameworkCore.Migrations;

namespace apiPlantas2.Migrations
{
    public partial class cambios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reportes_Plantas_plantasId",
                table: "Reportes");

            migrationBuilder.DropIndex(
                name: "IX_Reportes_plantasId",
                table: "Reportes");

            migrationBuilder.DropColumn(
                name: "IdPlanta",
                table: "Reportes");

            migrationBuilder.DropColumn(
                name: "plantasId",
                table: "Reportes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPlanta",
                table: "Reportes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "plantasId",
                table: "Reportes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_plantasId",
                table: "Reportes",
                column: "plantasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reportes_Plantas_plantasId",
                table: "Reportes",
                column: "plantasId",
                principalTable: "Plantas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
