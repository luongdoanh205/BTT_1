using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LVDDay9.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LvdLoai_San_Pham",
                columns: table => new
                {
                    lvdId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lvdMaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    lvdTenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lvdTrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LvdLoai_San_Pham", x => x.lvdId);
                });

            migrationBuilder.CreateTable(
                name: "LvdSan_Pham",
                columns: table => new
                {
                    lvdId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lvdMaSanPham = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    lvdTenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lvdHinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lvdSoLuong = table.Column<int>(type: "int", nullable: false),
                    lvdDonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    lvdLoaiSanPhamId = table.Column<long>(type: "bigint", nullable: false),
                    lvdLoai_San_PhamlvdId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LvdSan_Pham", x => x.lvdId);
                    table.ForeignKey(
                        name: "FK_LvdSan_Pham_LvdLoai_San_Pham_lvdLoai_San_PhamlvdId",
                        column: x => x.lvdLoai_San_PhamlvdId,
                        principalTable: "LvdLoai_San_Pham",
                        principalColumn: "lvdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LvdLoai_San_Pham_lvdMaLoai",
                table: "LvdLoai_San_Pham",
                column: "lvdMaLoai",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LvdSan_Pham_lvdLoai_San_PhamlvdId",
                table: "LvdSan_Pham",
                column: "lvdLoai_San_PhamlvdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LvdSan_Pham");

            migrationBuilder.DropTable(
                name: "LvdLoai_San_Pham");
        }
    }
}
