using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrmData.Migrations
{
    public partial class hadi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tür = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    picture = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "denemeler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(nullable: true),
                    il = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_denemeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "iller",
                columns: table => new
                {
                    ıd = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iller", x => x.ıd);
                });

            migrationBuilder.CreateTable(
                name: "calisans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Prim = table.Column<string>(nullable: true),
                    picture = table.Column<string>(nullable: true),
                    iseGiris = table.Column<DateTime>(nullable: false),
                    Kanun = table.Column<string>(nullable: true),
                    companyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calisans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calisans_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "companyCategories",
                columns: table => new
                {
                    companyId = table.Column<int>(nullable: false),
                    categoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyCategories", x => new { x.categoryId, x.companyId });
                    table.ForeignKey(
                        name: "FK_companyCategories_categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_companyCategories_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    companyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_customers_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "muhasebes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alacak = table.Column<int>(nullable: false),
                    verecek = table.Column<int>(nullable: false),
                    companyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_muhasebes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_muhasebes_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    companyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notes_Companies_companyId",
                        column: x => x.companyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "denemeiller",
                columns: table => new
                {
                    ilId = table.Column<int>(nullable: false),
                    denemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_denemeiller", x => new { x.denemeId, x.ilId });
                    table.ForeignKey(
                        name: "FK_denemeiller_denemeler_denemeId",
                        column: x => x.denemeId,
                        principalTable: "denemeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_denemeiller_iller_ilId",
                        column: x => x.ilId,
                        principalTable: "iller",
                        principalColumn: "ıd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gorevs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    Zaman = table.Column<DateTime>(nullable: false),
                    calisanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gorevs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gorevs_calisans_calisanId",
                        column: x => x.calisanId,
                        principalTable: "calisans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notify",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(nullable: true),
                    zaman = table.Column<DateTime>(nullable: false),
                    calisanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notify", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notify_calisans_calisanId",
                        column: x => x.calisanId,
                        principalTable: "calisans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_calisans_companyId",
                table: "calisans",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_companyCategories_companyId",
                table: "companyCategories",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_companyId",
                table: "customers",
                column: "companyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_denemeiller_ilId",
                table: "denemeiller",
                column: "ilId");

            migrationBuilder.CreateIndex(
                name: "IX_gorevs_calisanId",
                table: "gorevs",
                column: "calisanId");

            migrationBuilder.CreateIndex(
                name: "IX_muhasebes_companyId",
                table: "muhasebes",
                column: "companyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_notes_companyId",
                table: "notes",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_notify_calisanId",
                table: "notify",
                column: "calisanId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companyCategories");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "denemeiller");

            migrationBuilder.DropTable(
                name: "gorevs");

            migrationBuilder.DropTable(
                name: "muhasebes");

            migrationBuilder.DropTable(
                name: "notes");

            migrationBuilder.DropTable(
                name: "notify");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "denemeler");

            migrationBuilder.DropTable(
                name: "iller");

            migrationBuilder.DropTable(
                name: "calisans");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
