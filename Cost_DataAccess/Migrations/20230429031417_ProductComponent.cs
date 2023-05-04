using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ProductComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComponent_Components_ComponentId",
                table: "ProductComponent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComponent_Products_ProductId",
                table: "ProductComponent");

            migrationBuilder.DropIndex(
                name: "IX_ProductComponent_ComponentId",
                table: "ProductComponent");

            migrationBuilder.DropIndex(
                name: "IX_ProductComponent_ProductId",
                table: "ProductComponent");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductComponent");

            migrationBuilder.RenameColumn(
                name: "ComponentUoM",
                table: "ProductComponent",
                newName: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductComponent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "ProductComponent",
                newName: "ComponentUoM");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductComponent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ProductComponent",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductComponent_ComponentId",
                table: "ProductComponent",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComponent_ProductId",
                table: "ProductComponent",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComponent_Components_ComponentId",
                table: "ProductComponent",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "ComponentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComponent_Products_ProductId",
                table: "ProductComponent",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
