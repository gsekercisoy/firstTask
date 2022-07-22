using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class migfrist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategoriler",
                columns: table => new
                {
                    categoryid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoriler", x => x.categoryid);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    productid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    stok = table.Column<int>(type: "int", nullable: false),
                    Kategorilercategoryid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.productid);
                    table.ForeignKey(
                        name: "FK_urunler_kategoriler_Kategorilercategoryid",
                        column: x => x.Kategorilercategoryid,
                        principalTable: "kategoriler",
                        principalColumn: "categoryid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_urunler_Kategorilercategoryid",
                table: "urunler",
                column: "Kategorilercategoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "urunler");

            migrationBuilder.DropTable(
                name: "kategoriler");
        }
    }
}
