using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _22_23.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuyenBay",
                columns: table => new
                {
                    MaCH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Chuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DDi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DDen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GDen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thuong = table.Column<int>(type: "int", nullable: false),
                    Vip = table.Column<int>(type: "int", nullable: false),
                    MaMB = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenBay", x => x.MaCH);
                });

            migrationBuilder.CreateTable(
                name: "CT_CB",
                columns: table => new
                {
                    MaCH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaHK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoGhe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiGhe = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_CB", x => new { x.MaCH, x.MaHK });
                });

            migrationBuilder.CreateTable(
                name: "HanhKhach",
                columns: table => new
                {
                    MaHK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HanhKhach", x => x.MaHK);
                });

            migrationBuilder.CreateTable(
                name: "MayBay",
                columns: table => new
                {
                    MaMB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HangMB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoCho = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MayBay", x => x.MaMB);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuyenBay");

            migrationBuilder.DropTable(
                name: "CT_CB");

            migrationBuilder.DropTable(
                name: "HanhKhach");

            migrationBuilder.DropTable(
                name: "MayBay");
        }
    }
}
