using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog_Hierarhy.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalogs_Catalogs_ParentId",
                table: "Catalogs");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalogs_Catalogs_ParentId",
                table: "Catalogs",
                column: "ParentId",
                principalTable: "Catalogs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalogs_Catalogs_ParentId",
                table: "Catalogs");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalogs_Catalogs_ParentId",
                table: "Catalogs",
                column: "ParentId",
                principalTable: "Catalogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
