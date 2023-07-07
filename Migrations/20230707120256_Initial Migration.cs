using Microsoft.EntityFrameworkCore.Migrations;

namespace Praca_Inżynierska.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    producent = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    opis = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    kategoria = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    haslo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    czy_admin = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    imie = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    ulica = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    numer_domu = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
                    email = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsUsers",
                columns: table => new
                {
                    Productsid = table.Column<int>(type: "int", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsUsers", x => new { x.Productsid, x.Usersid });
                    table.ForeignKey(
                        name: "FK_ProductsUsers_Products_Productsid",
                        column: x => x.Productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsUsers_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsUsers_Usersid",
                table: "ProductsUsers",
                column: "Usersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
