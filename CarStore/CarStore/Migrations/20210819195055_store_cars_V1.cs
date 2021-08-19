using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStore.Migrations
{
    public partial class store_cars_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarDescriptionEntityCarFeaturesEntity",
                columns: table => new
                {
                    CarDescriptionsId = table.Column<int>(type: "int", nullable: false),
                    CarFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDescriptionEntityCarFeaturesEntity", x => new { x.CarDescriptionsId, x.CarFeaturesId });
                    table.ForeignKey(
                        name: "FK_CarDescriptionEntityCarFeaturesEntity_CarDescriptions_CarDescriptionsId",
                        column: x => x.CarDescriptionsId,
                        principalTable: "CarDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDescriptionEntityCarFeaturesEntity_CarFeatures_CarFeaturesId",
                        column: x => x.CarFeaturesId,
                        principalTable: "CarFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDescriptionId = table.Column<int>(type: "int", nullable: false),
                    CarFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescriptionFeatures_CarDescriptions_CarDescriptionId",
                        column: x => x.CarDescriptionId,
                        principalTable: "CarDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DescriptionFeatures_CarFeatures_CarFeaturesId",
                        column: x => x.CarFeaturesId,
                        principalTable: "CarFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarDescriptionEntityCarFeaturesEntity_CarFeaturesId",
                table: "CarDescriptionEntityCarFeaturesEntity",
                column: "CarFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionFeatures_CarDescriptionId",
                table: "DescriptionFeatures",
                column: "CarDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionFeatures_CarFeaturesId",
                table: "DescriptionFeatures",
                column: "CarFeaturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarDescriptionEntityCarFeaturesEntity");

            migrationBuilder.DropTable(
                name: "DescriptionFeatures");

            migrationBuilder.DropTable(
                name: "CarDescriptions");

            migrationBuilder.DropTable(
                name: "CarFeatures");
        }
    }
}
