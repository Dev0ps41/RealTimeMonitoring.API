using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealTimeMonitoring.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionRecords",
                table: "ProductionRecords");

            migrationBuilder.RenameTable(
                name: "ProductionRecords",
                newName: "ProductionData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionData",
                table: "ProductionData",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionData",
                table: "ProductionData");

            migrationBuilder.RenameTable(
                name: "ProductionData",
                newName: "ProductionRecords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionRecords",
                table: "ProductionRecords",
                column: "Id");
        }
    }
}
