using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeProductComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "ProductComponent");

            migrationBuilder.RenameColumn(
                name: "ComponentId",
                table: "ProductComponent",
                newName: "ComponentProductId");

            migrationBuilder.AddColumn<int>(
                name: "ComponentIngredientId",
                table: "ProductComponent",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponentIngredientId",
                table: "ProductComponent");

            migrationBuilder.RenameColumn(
                name: "ComponentProductId",
                table: "ProductComponent",
                newName: "ComponentId");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "ProductComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
