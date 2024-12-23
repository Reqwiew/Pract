using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pract.Migrations
{
    /// <inheritdoc />
    public partial class migaret13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_equipment_clients_ClientID",
                table: "equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_repairs_equipment_EquipmentID",
                table: "repairs");

            migrationBuilder.DropForeignKey(
                name: "FK_repairs_masters_MasterID",
                table: "repairs");

            migrationBuilder.DropForeignKey(
                name: "FK_repairs_receptionits_ReceptionistID",
                table: "repairs");

            migrationBuilder.DropForeignKey(
                name: "FK_repairServices_repairs_RepairID",
                table: "repairServices");

            migrationBuilder.DropForeignKey(
                name: "FK_repairServices_services_ServiceID",
                table: "repairServices");

            migrationBuilder.DropForeignKey(
                name: "FK_usedParts_parts_PartID",
                table: "usedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_usedParts_repairs_RepairID",
                table: "usedParts");

            migrationBuilder.RenameColumn(
                name: "RepairID",
                table: "usedParts",
                newName: "RepairId");

            migrationBuilder.RenameColumn(
                name: "PartID",
                table: "usedParts",
                newName: "PartId");

            migrationBuilder.RenameColumn(
                name: "UsedPartID",
                table: "usedParts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_usedParts_RepairID",
                table: "usedParts",
                newName: "IX_usedParts_RepairId");

            migrationBuilder.RenameIndex(
                name: "IX_usedParts_PartID",
                table: "usedParts",
                newName: "IX_usedParts_PartId");

            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "services",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "repairServices",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "RepairID",
                table: "repairServices",
                newName: "RepairId");

            migrationBuilder.RenameColumn(
                name: "RepairServiceID",
                table: "repairServices",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_repairServices_ServiceID",
                table: "repairServices",
                newName: "IX_repairServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_repairServices_RepairID",
                table: "repairServices",
                newName: "IX_repairServices_RepairId");

            migrationBuilder.RenameColumn(
                name: "ReceptionistID",
                table: "repairs",
                newName: "ReceptionistId");

            migrationBuilder.RenameColumn(
                name: "MasterID",
                table: "repairs",
                newName: "MasterId");

            migrationBuilder.RenameColumn(
                name: "EquipmentID",
                table: "repairs",
                newName: "EquipmentId");

            migrationBuilder.RenameColumn(
                name: "RepairID",
                table: "repairs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_repairs_ReceptionistID",
                table: "repairs",
                newName: "IX_repairs_ReceptionistId");

            migrationBuilder.RenameIndex(
                name: "IX_repairs_MasterID",
                table: "repairs",
                newName: "IX_repairs_MasterId");

            migrationBuilder.RenameIndex(
                name: "IX_repairs_EquipmentID",
                table: "repairs",
                newName: "IX_repairs_EquipmentId");

            migrationBuilder.RenameColumn(
                name: "ReceptionistID",
                table: "receptionits",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PartID",
                table: "parts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MasterID",
                table: "masters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "equipment",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "EquipmentID",
                table: "equipment",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_equipment_ClientID",
                table: "equipment",
                newName: "IX_equipment_ClientId");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "clients",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_equipment_clients_ClientId",
                table: "equipment",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairs_equipment_EquipmentId",
                table: "repairs",
                column: "EquipmentId",
                principalTable: "equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairs_masters_MasterId",
                table: "repairs",
                column: "MasterId",
                principalTable: "masters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairs_receptionits_ReceptionistId",
                table: "repairs",
                column: "ReceptionistId",
                principalTable: "receptionits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairServices_repairs_RepairId",
                table: "repairServices",
                column: "RepairId",
                principalTable: "repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairServices_services_ServiceId",
                table: "repairServices",
                column: "ServiceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usedParts_parts_PartId",
                table: "usedParts",
                column: "PartId",
                principalTable: "parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usedParts_repairs_RepairId",
                table: "usedParts",
                column: "RepairId",
                principalTable: "repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_equipment_clients_ClientId",
                table: "equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_repairs_equipment_EquipmentId",
                table: "repairs");

            migrationBuilder.DropForeignKey(
                name: "FK_repairs_masters_MasterId",
                table: "repairs");

            migrationBuilder.DropForeignKey(
                name: "FK_repairs_receptionits_ReceptionistId",
                table: "repairs");

            migrationBuilder.DropForeignKey(
                name: "FK_repairServices_repairs_RepairId",
                table: "repairServices");

            migrationBuilder.DropForeignKey(
                name: "FK_repairServices_services_ServiceId",
                table: "repairServices");

            migrationBuilder.DropForeignKey(
                name: "FK_usedParts_parts_PartId",
                table: "usedParts");

            migrationBuilder.DropForeignKey(
                name: "FK_usedParts_repairs_RepairId",
                table: "usedParts");

            migrationBuilder.RenameColumn(
                name: "RepairId",
                table: "usedParts",
                newName: "RepairID");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "usedParts",
                newName: "PartID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usedParts",
                newName: "UsedPartID");

            migrationBuilder.RenameIndex(
                name: "IX_usedParts_RepairId",
                table: "usedParts",
                newName: "IX_usedParts_RepairID");

            migrationBuilder.RenameIndex(
                name: "IX_usedParts_PartId",
                table: "usedParts",
                newName: "IX_usedParts_PartID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "services",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "repairServices",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "RepairId",
                table: "repairServices",
                newName: "RepairID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "repairServices",
                newName: "RepairServiceID");

            migrationBuilder.RenameIndex(
                name: "IX_repairServices_ServiceId",
                table: "repairServices",
                newName: "IX_repairServices_ServiceID");

            migrationBuilder.RenameIndex(
                name: "IX_repairServices_RepairId",
                table: "repairServices",
                newName: "IX_repairServices_RepairID");

            migrationBuilder.RenameColumn(
                name: "ReceptionistId",
                table: "repairs",
                newName: "ReceptionistID");

            migrationBuilder.RenameColumn(
                name: "MasterId",
                table: "repairs",
                newName: "MasterID");

            migrationBuilder.RenameColumn(
                name: "EquipmentId",
                table: "repairs",
                newName: "EquipmentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "repairs",
                newName: "RepairID");

            migrationBuilder.RenameIndex(
                name: "IX_repairs_ReceptionistId",
                table: "repairs",
                newName: "IX_repairs_ReceptionistID");

            migrationBuilder.RenameIndex(
                name: "IX_repairs_MasterId",
                table: "repairs",
                newName: "IX_repairs_MasterID");

            migrationBuilder.RenameIndex(
                name: "IX_repairs_EquipmentId",
                table: "repairs",
                newName: "IX_repairs_EquipmentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "receptionits",
                newName: "ReceptionistID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "parts",
                newName: "PartID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "masters",
                newName: "MasterID");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "equipment",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "equipment",
                newName: "EquipmentID");

            migrationBuilder.RenameIndex(
                name: "IX_equipment_ClientId",
                table: "equipment",
                newName: "IX_equipment_ClientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clients",
                newName: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_equipment_clients_ClientID",
                table: "equipment",
                column: "ClientID",
                principalTable: "clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairs_equipment_EquipmentID",
                table: "repairs",
                column: "EquipmentID",
                principalTable: "equipment",
                principalColumn: "EquipmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairs_masters_MasterID",
                table: "repairs",
                column: "MasterID",
                principalTable: "masters",
                principalColumn: "MasterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairs_receptionits_ReceptionistID",
                table: "repairs",
                column: "ReceptionistID",
                principalTable: "receptionits",
                principalColumn: "ReceptionistID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairServices_repairs_RepairID",
                table: "repairServices",
                column: "RepairID",
                principalTable: "repairs",
                principalColumn: "RepairID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_repairServices_services_ServiceID",
                table: "repairServices",
                column: "ServiceID",
                principalTable: "services",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usedParts_parts_PartID",
                table: "usedParts",
                column: "PartID",
                principalTable: "parts",
                principalColumn: "PartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usedParts_repairs_RepairID",
                table: "usedParts",
                column: "RepairID",
                principalTable: "repairs",
                principalColumn: "RepairID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
