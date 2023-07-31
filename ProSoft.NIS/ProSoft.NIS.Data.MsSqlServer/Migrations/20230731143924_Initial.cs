using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSoft.NIS.Data.MsSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Campuses",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Campuses_CampusId",
                        column: x => x.CampusId,
                        principalSchema: "data",
                        principalTable: "Campuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalSchema: "data",
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hallways",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hallways", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hallways_Floors_FloorId",
                        column: x => x.FloorId,
                        principalSchema: "data",
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HallwayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hallways_HallwayId",
                        column: x => x.HallwayId,
                        principalSchema: "data",
                        principalTable: "Hallways",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cages",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cages_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "data",
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Racks",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CageId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racks_Cages_CageId",
                        column: x => x.CageId,
                        principalSchema: "data",
                        principalTable: "Cages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Racks_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalSchema: "data",
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RackItems",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RackItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RackItems_Racks_RackId",
                        column: x => x.RackId,
                        principalSchema: "data",
                        principalTable: "Racks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ports",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RackItemId = table.Column<int>(type: "int", nullable: false),
                    CableAId = table.Column<int>(type: "int", nullable: true),
                    CableBId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ports_RackItems_RackItemId",
                        column: x => x.RackItemId,
                        principalSchema: "data",
                        principalTable: "RackItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Switches",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Switches_RackItems_Id",
                        column: x => x.Id,
                        principalSchema: "data",
                        principalTable: "RackItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cables",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortAId = table.Column<int>(type: "int", nullable: false),
                    PortBId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cables_Ports_PortAId",
                        column: x => x.PortAId,
                        principalSchema: "data",
                        principalTable: "Ports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cables_Ports_PortBId",
                        column: x => x.PortBId,
                        principalSchema: "data",
                        principalTable: "Ports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_CampusId",
                schema: "data",
                table: "Buildings",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_PortAId",
                schema: "data",
                table: "Cables",
                column: "PortAId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cables_PortBId",
                schema: "data",
                table: "Cables",
                column: "PortBId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cages_RoomId",
                schema: "data",
                table: "Cages",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                schema: "data",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Hallways_FloorId",
                schema: "data",
                table: "Hallways",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ports_RackItemId",
                schema: "data",
                table: "Ports",
                column: "RackItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RackItems_RackId",
                schema: "data",
                table: "RackItems",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_CageId",
                schema: "data",
                table: "Racks",
                column: "CageId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_RoomId",
                schema: "data",
                table: "Racks",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HallwayId",
                schema: "data",
                table: "Rooms",
                column: "HallwayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cables",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Switches",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Ports",
                schema: "data");

            migrationBuilder.DropTable(
                name: "RackItems",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Racks",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Cages",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Rooms",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Hallways",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Floors",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Buildings",
                schema: "data");

            migrationBuilder.DropTable(
                name: "Campuses",
                schema: "data");
        }
    }
}
