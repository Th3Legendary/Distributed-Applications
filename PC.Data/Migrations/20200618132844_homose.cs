using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PC.Data.Migrations
{
    public partial class homose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    CaseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: false),
                    SidePanel = table.Column<string>(maxLength: 40, nullable: false),
                    Colour = table.Column<string>(maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.CaseId);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    CPUId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    CoreCount = table.Column<int>(nullable: false),
                    BaseClock = table.Column<float>(nullable: false),
                    BoostClock = table.Column<float>(nullable: false),
                    TDP = table.Column<int>(nullable: false),
                    Socket = table.Column<string>(maxLength: 40, nullable: false),
                    Lithography = table.Column<int>(nullable: false),
                    IntegrateGraphics = table.Column<bool>(nullable: false),
                    SimultaniousMultithreading = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.CPUId);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    GPUId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    MemoryCapacity = table.Column<int>(nullable: false),
                    MemoryType = table.Column<string>(maxLength: 40, nullable: false),
                    MemoryClock = table.Column<int>(nullable: false),
                    BaseClock = table.Column<float>(nullable: false),
                    BoostClock = table.Column<float>(nullable: false),
                    TDP = table.Column<int>(nullable: false),
                    Chipset = table.Column<string>(maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.GPUId);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    MemoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Clock = table.Column<float>(nullable: false),
                    Timings = table.Column<string>(maxLength: 40, nullable: false),
                    Voltage = table.Column<float>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.MemoryId);
                });

            migrationBuilder.CreateTable(
                name: "Motherbaords",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    Socket = table.Column<string>(maxLength: 40, nullable: false),
                    FormFactor = table.Column<string>(maxLength: 40, nullable: false),
                    Chipset = table.Column<string>(maxLength: 40, nullable: false),
                    MemorySlots = table.Column<int>(nullable: false),
                    PCIESlots = table.Column<int>(nullable: false),
                    M2Slots = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherbaords", x => x.MotherboardId);
                });

            migrationBuilder.CreateTable(
                name: "PSUs",
                columns: table => new
                {
                    PSUId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    FormFactor = table.Column<string>(maxLength: 40, nullable: false),
                    Efficiency = table.Column<string>(maxLength: 40, nullable: false),
                    Wattage = table.Column<int>(nullable: false),
                    Modular = table.Column<string>(maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSUs", x => x.PSUId);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StorageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(maxLength: 40, nullable: false),
                    Model = table.Column<string>(maxLength: 40, nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 40, nullable: false),
                    Interface = table.Column<string>(maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StorageId);
                });

            migrationBuilder.CreateTable(
                name: "BuildLists",
                columns: table => new
                {
                    BuildId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CPUId = table.Column<int>(nullable: false),
                    MotherboardId = table.Column<int>(nullable: false),
                    MemoryId = table.Column<int>(nullable: false),
                    StorageId = table.Column<int>(nullable: false),
                    GPUId = table.Column<int>(nullable: false),
                    PSUId = table.Column<int>(nullable: false),
                    CaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildLists", x => x.BuildId);
                    table.ForeignKey(
                        name: "FK_BuildLists_CPUs_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPUs",
                        principalColumn: "CPUId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildLists_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "CaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildLists_GPUs_GPUId",
                        column: x => x.GPUId,
                        principalTable: "GPUs",
                        principalColumn: "GPUId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildLists_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "MemoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildLists_Motherbaords_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherbaords",
                        principalColumn: "MotherboardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildLists_PSUs_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSUs",
                        principalColumn: "PSUId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildLists_Storages_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storages",
                        principalColumn: "StorageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_CPUId",
                table: "BuildLists",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_CaseId",
                table: "BuildLists",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_GPUId",
                table: "BuildLists",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_MemoryId",
                table: "BuildLists",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_MotherboardId",
                table: "BuildLists",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_PSUId",
                table: "BuildLists",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildLists_StorageId",
                table: "BuildLists",
                column: "StorageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildLists");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Motherbaords");

            migrationBuilder.DropTable(
                name: "PSUs");

            migrationBuilder.DropTable(
                name: "Storages");
        }
    }
}
