using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowcentricAssessment.Migrations
{
    /// <inheritdoc />
    public partial class addFKFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSettings_ClientSettings_ClientSettingsId",
                table: "ProductSettings");

            migrationBuilder.DropIndex(
                name: "IX_ProductSettings_ClientSettingsId",
                table: "ProductSettings");

            migrationBuilder.DropColumn(
                name: "ClientSettingsId",
                table: "ProductSettings");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductSettingsId",
                table: "ClientSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientSettings_ProductSettingsId",
                table: "ClientSettings",
                column: "ProductSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSettings_ProductSettings_ProductSettingsId",
                table: "ClientSettings",
                column: "ProductSettingsId",
                principalTable: "ProductSettings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSettings_ProductSettings_ProductSettingsId",
                table: "ClientSettings");

            migrationBuilder.DropIndex(
                name: "IX_ClientSettings_ProductSettingsId",
                table: "ClientSettings");

            migrationBuilder.DropColumn(
                name: "ProductSettingsId",
                table: "ClientSettings");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientSettingsId",
                table: "ProductSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ProductSettings_ClientSettingsId",
                table: "ProductSettings",
                column: "ClientSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSettings_ClientSettings_ClientSettingsId",
                table: "ProductSettings",
                column: "ClientSettingsId",
                principalTable: "ClientSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
