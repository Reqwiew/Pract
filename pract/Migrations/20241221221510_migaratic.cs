using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pract.Migrations
{
    /// <inheritdoc />
    public partial class migaratic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "masters",
                columns: table => new
                {
                    MasterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masters", x => x.MasterID);
                });

            migrationBuilder.CreateTable(
                name: "parts",
                columns: table => new
                {
                    PartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts", x => x.PartID);
                });

            migrationBuilder.CreateTable(
                name: "receptionits",
                columns: table => new
                {
                    ReceptionistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receptionits", x => x.ReceptionistID);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipment", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_equipment_clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "repairs",
                columns: table => new
                {
                    RepairID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false),
                    MasterID = table.Column<int>(type: "int", nullable: false),
                    ReceptionistID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repairs", x => x.RepairID);
                    table.ForeignKey(
                        name: "FK_repairs_equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_repairs_masters_MasterID",
                        column: x => x.MasterID,
                        principalTable: "masters",
                        principalColumn: "MasterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_repairs_receptionits_ReceptionistID",
                        column: x => x.ReceptionistID,
                        principalTable: "receptionits",
                        principalColumn: "ReceptionistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "repairServices",
                columns: table => new
                {
                    RepairServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repairServices", x => x.RepairServiceID);
                    table.ForeignKey(
                        name: "FK_repairServices_repairs_RepairID",
                        column: x => x.RepairID,
                        principalTable: "repairs",
                        principalColumn: "RepairID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_repairServices_services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usedParts",
                columns: table => new
                {
                    UsedPartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairID = table.Column<int>(type: "int", nullable: false),
                    PartID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usedParts", x => x.UsedPartID);
                    table.ForeignKey(
                        name: "FK_usedParts_parts_PartID",
                        column: x => x.PartID,
                        principalTable: "parts",
                        principalColumn: "PartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usedParts_repairs_RepairID",
                        column: x => x.RepairID,
                        principalTable: "repairs",
                        principalColumn: "RepairID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_equipment_ClientID",
                table: "equipment",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_repairs_EquipmentID",
                table: "repairs",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_repairs_MasterID",
                table: "repairs",
                column: "MasterID");

            migrationBuilder.CreateIndex(
                name: "IX_repairs_ReceptionistID",
                table: "repairs",
                column: "ReceptionistID");

            migrationBuilder.CreateIndex(
                name: "IX_repairServices_RepairID",
                table: "repairServices",
                column: "RepairID");

            migrationBuilder.CreateIndex(
                name: "IX_repairServices_ServiceID",
                table: "repairServices",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_usedParts_PartID",
                table: "usedParts",
                column: "PartID");

            migrationBuilder.CreateIndex(
                name: "IX_usedParts_RepairID",
                table: "usedParts",
                column: "RepairID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "repairServices");

            migrationBuilder.DropTable(
                name: "usedParts");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "parts");

            migrationBuilder.DropTable(
                name: "repairs");

            migrationBuilder.DropTable(
                name: "equipment");

            migrationBuilder.DropTable(
                name: "masters");

            migrationBuilder.DropTable(
                name: "receptionits");

            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
