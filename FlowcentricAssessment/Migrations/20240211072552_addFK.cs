using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowcentricAssessment.Migrations
{
    /// <inheritdoc />
    public partial class addFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_CustomSettings_ParentLinkId",
                table: "CustomSettings");

            migrationBuilder.RenameColumn(
                name: "ParentLinkId",
                table: "CustomSettings",
                newName: "ParentLinkIDId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomSettings_ParentLinkId",
                table: "CustomSettings",
                newName: "IX_CustomSettings_ParentLinkIDId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_CustomSettings_ParentLinkIDId",
                table: "CustomSettings",
                column: "ParentLinkIDId",
                principalTable: "CustomSettings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSettings_ProductSettings_ProductSettingsLinkIDId",
                table: "ClientSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_ClientSettings_ClientSettingsLinkIDId",
                table: "CustomSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomSettings_CustomSettings_ParentLinkIDId",
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

            migrationBuilder.RenameColumn(
                name: "ParentLinkIDId",
                table: "CustomSettings",
                newName: "ParentLinkId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomSettings_ParentLinkIDId",
                table: "CustomSettings",
                newName: "IX_CustomSettings_ParentLinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomSettings_CustomSettings_ParentLinkId",
                table: "CustomSettings",
                column: "ParentLinkId",
                principalTable: "CustomSettings",
                principalColumn: "Id");
        }
    }
}
