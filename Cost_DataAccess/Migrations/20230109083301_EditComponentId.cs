using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditComponentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Components",
                newName: "ComponentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComponentId",
                table: "Components",
                newName: "Id");
        }
    }
}
