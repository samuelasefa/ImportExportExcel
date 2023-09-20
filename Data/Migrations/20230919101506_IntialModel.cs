using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportExportExcel.Data.Migrations
{
    public partial class IntialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherId = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Subtotal = table.Column<double>(nullable: false),
                    GrandTotal = table.Column<double>(nullable: false),
                    PrepardBy = table.Column<string>(nullable: true),
                    FsNo = table.Column<string>(nullable: true),
                    SalesPerson = table.Column<string>(nullable: true),
                    SourceStore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesModels");
        }
    }
}
