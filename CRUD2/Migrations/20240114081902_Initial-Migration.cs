using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD2.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaiHat",
                columns: table => new
                {
                    MaBaiHat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenBaiHat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiHat", x => x.MaBaiHat);
                });

            migrationBuilder.CreateTable(
                name: "CaSi",
                columns: table => new
                {
                    MaCaSi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCaSi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    NamSinh = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaSi", x => x.MaCaSi);
                });

            migrationBuilder.CreateTable(
                name: "CaSi_BaiHat",
                columns: table => new
                {
                    MaCaSi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaBaiHat = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaSi_BaiHat", x => new { x.MaCaSi, x.MaBaiHat });
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<long>(type: "bigint", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguoiNghe",
                columns: table => new
                {
                    MaNguoiNghe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiNghe", x => x.MaNguoiNghe);
                });

            migrationBuilder.CreateTable(
                name: "PlayList",
                columns: table => new
                {
                    MaPlayList = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPlayList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaNN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayList", x => x.MaPlayList);
                });

            migrationBuilder.CreateTable(
                name: "PlayList_BaiHat",
                columns: table => new
                {
                    MaPlayList = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaBaiHat = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayList_BaiHat", x => new { x.MaPlayList, x.MaBaiHat });
                });

            migrationBuilder.CreateTable(
                name: "tbl_Departments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepID = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Student", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiHat");

            migrationBuilder.DropTable(
                name: "CaSi");

            migrationBuilder.DropTable(
                name: "CaSi_BaiHat");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "NguoiNghe");

            migrationBuilder.DropTable(
                name: "PlayList");

            migrationBuilder.DropTable(
                name: "PlayList_BaiHat");

            migrationBuilder.DropTable(
                name: "tbl_Departments");

            migrationBuilder.DropTable(
                name: "tbl_Student");
        }
    }
}
