using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CostDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateComponentAudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Components",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTimestamp",
                table: "Components",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Components",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTimestamp",
                table: "Components",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "CreatedTimestamp",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "UpdatedTimestamp",
                table: "Components");

            }
    }
}
