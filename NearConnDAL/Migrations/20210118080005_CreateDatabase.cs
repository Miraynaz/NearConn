using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NearConnDAL.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Etkinlik",
                columns: table => new
                {
                    EtkinlikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EtkinlikAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtkinlikAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtkinlikResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtkinlikAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtkinlikTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EtkinlikDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Etkinlik", x => x.EtkinlikId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Kullanici",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Kullanici", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_KullaniciEtkinlik",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    EtkinlikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_KullaniciEtkinlik", x => new { x.EtkinlikId, x.KullaniciId });
                    table.ForeignKey(
                        name: "FK_tbl_KullaniciEtkinlik_tbl_Etkinlik_EtkinlikId",
                        column: x => x.EtkinlikId,
                        principalTable: "tbl_Etkinlik",
                        principalColumn: "EtkinlikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_KullaniciEtkinlik_tbl_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "tbl_Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_KullaniciEtkinlik_KullaniciId",
                table: "tbl_KullaniciEtkinlik",
                column: "KullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_KullaniciEtkinlik");

            migrationBuilder.DropTable(
                name: "tbl_Etkinlik");

            migrationBuilder.DropTable(
                name: "tbl_Kullanici");
        }
    }
}
