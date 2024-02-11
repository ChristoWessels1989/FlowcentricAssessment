using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowcentricAssessment.Migrations
{
    /// <inheritdoc />
    public partial class initialTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowHeader = table.Column<bool>(type: "bit", nullable: false),
                    ShowMenuBar = table.Column<bool>(type: "bit", nullable: false),
                    SubMenusToShow = table.Column<int>(type: "int", nullable: false),
                    EnableFeature1 = table.Column<bool>(type: "bit", nullable: false),
                    EnableFeature1AdvancedSearch = table.Column<bool>(type: "bit", nullable: false),
                    EnableFeature2 = table.Column<bool>(type: "bit", nullable: false),
                    EnableFeature3 = table.Column<bool>(type: "bit", nullable: false),
                    EnableFeature3AdvancedSearch = table.Column<bool>(type: "bit", nullable: false),
                    Feature3ItemCount = table.Column<int>(type: "int", nullable: false),
                    EnableFeature4 = table.Column<bool>(type: "bit", nullable: false),
                    EnableFeature5 = table.Column<bool>(type: "bit", nullable: false),
                    DisplayFullError = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomSettingsType = table.Column<int>(type: "int", nullable: false),
                    ParentLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    boolValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intValue = table.Column<int>(type: "int", nullable: true),
                    stringValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomSettings_CustomSettings_ParentLinkId",
                        column: x => x.ParentLinkId,
                        principalTable: "CustomSettings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    License = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoginAttemptLimit = table.Column<int>(type: "int", nullable: false),
                    PasswordHistory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSettings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_ParentLinkId",
                table: "CustomSettings",
                column: "ParentLinkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientSettings");

            migrationBuilder.DropTable(
                name: "CustomSettings");

            migrationBuilder.DropTable(
                name: "ProductSettings");
        }
    }
}
