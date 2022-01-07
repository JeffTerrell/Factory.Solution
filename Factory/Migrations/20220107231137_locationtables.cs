using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class locationtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loactions",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loactions", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "EngineerLocation",
                columns: table => new
                {
                    EngineerLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    EngineerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineerLocation", x => x.EngineerLocationId);
                    table.ForeignKey(
                        name: "FK_EngineerLocation_Engineers_EngineerId",
                        column: x => x.EngineerId,
                        principalTable: "Engineers",
                        principalColumn: "EngineerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EngineerLocation_Loactions_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Loactions",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationMachine",
                columns: table => new
                {
                    LocationMachineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MachineId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationMachine", x => x.LocationMachineId);
                    table.ForeignKey(
                        name: "FK_LocationMachine_Loactions_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Loactions",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationMachine_Machines_MachineId",
                        column: x => x.MachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EngineerLocation_EngineerId",
                table: "EngineerLocation",
                column: "EngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerLocation_LocationId",
                table: "EngineerLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationMachine_LocationId",
                table: "LocationMachine",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationMachine_MachineId",
                table: "LocationMachine",
                column: "MachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EngineerLocation");

            migrationBuilder.DropTable(
                name: "LocationMachine");

            migrationBuilder.DropTable(
                name: "Loactions");
        }
    }
}
