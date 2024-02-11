using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowcentricAssessment.Migrations
{
    /// <inheritdoc />
    public partial class addFKFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSettings_ProductSettings_ProductSettingsLinkIDId",
                table: "ClientSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_ClientSettings_ClientSettingsLinkIDId",
                table: "CustomSettings");

            migrationBuilder.DropIndex(
                name: "IX_CustomSettings_ClientSettingsLinkIDId",
                table: "CustomSettings");

            migrationBuilder.DropIndex(
                name: "IX_ClientSettings_ProductSettingsLinkIDId",
                table: "ClientSettings");

            migrationBuilder.DropColumn(
                name: "ClientSettingsLinkIDId",
                table: "CustomSettings");

            migrationBuilder.DropColumn(
                name: "ProductSettingsLinkIDId",
                table: "ClientSettings");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientSettingsId",
                table: "ProductSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClientSettingsId",
                table: "CustomSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSettings_ClientSettingsId",
                table: "ProductSettings",
                column: "ClientSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_ClientSettingsId",
                table: "CustomSettings",
                column: "ClientSettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_ClientSettings_ClientSettingsId",
                table: "CustomSettings",
                column: "ClientSettingsId",
                principalTable: "ClientSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSettings_ClientSettings_ClientSettingsId",
                table: "ProductSettings",
                column: "ClientSettingsId",
                principalTable: "ClientSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_ClientSettings_ClientSettingsId",
                table: "CustomSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSettings_ClientSettings_ClientSettingsId",
                table: "ProductSettings");

            migrationBuilder.DropIndex(
                name: "IX_ProductSettings_ClientSettingsId",
                table: "ProductSettings");

            migrationBuilder.DropIndex(
                name: "IX_CustomSettings_ClientSettingsId",
                table: "CustomSettings");

            migrationBuilder.DropColumn(
                name: "ClientSettingsId",
                table: "ProductSettings");

            migrationBuilder.DropColumn(
                name: "ClientSettingsId",
                table: "CustomSettings");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientSettingsLinkIDId",
                table: "CustomSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductSettingsLinkIDId",
                table: "ClientSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_ClientSettingsLinkIDId",
                table: "CustomSettings",
                column: "ClientSettingsLinkIDId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSettings_ProductSettingsLinkIDId",
                table: "ClientSettings",
                column: "ProductSettingsLinkIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSettings_ProductSettings_ProductSettingsLinkIDId",
                table: "ClientSettings",
                column: "ProductSettingsLinkIDId",
                principalTable: "ProductSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_ClientSettings_ClientSettingsLinkIDId",
                table: "CustomSettings",
                column: "ClientSettingsLinkIDId",
                principalTable: "ClientSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
