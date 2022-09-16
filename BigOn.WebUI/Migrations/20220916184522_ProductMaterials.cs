using Microsoft.EntityFrameworkCore.Migrations;

namespace BigOn.WebUI.Migrations
{
    public partial class ProductMaterials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductMaterial_ProductMaterialId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMaterial",
                table: "ProductMaterial");

            migrationBuilder.RenameTable(
                name: "ProductMaterial",
                newName: "ProductMaterials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMaterials",
                table: "ProductMaterials",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductMaterials_ProductMaterialId",
                table: "Products",
                column: "ProductMaterialId",
                principalTable: "ProductMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductMaterials_ProductMaterialId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMaterials",
                table: "ProductMaterials");

            migrationBuilder.RenameTable(
                name: "ProductMaterials",
                newName: "ProductMaterial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMaterial",
                table: "ProductMaterial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductMaterial_ProductMaterialId",
                table: "Products",
                column: "ProductMaterialId",
                principalTable: "ProductMaterial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
