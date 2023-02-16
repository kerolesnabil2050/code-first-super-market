using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Super_Market.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Pos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorys_Stors_StorId",
                        column: x => x.StorId,
                        principalTable: "Stors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recipts",
                columns: table => new
                {
                    bon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuppliersId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipts", x => x.bon);
                    table.ForeignKey(
                        name: "FK_recipts_suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sellinvoces",
                columns: table => new
                {
                    BonNumberr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    casherUserNameUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    PaidMoney = table.Column<double>(type: "float", nullable: false),
                    RemainingMoney = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellinvoces", x => x.BonNumberr);
                    table.ForeignKey(
                        name: "FK_sellinvoces_users_casherUserNameUserName",
                        column: x => x.casherUserNameUserName,
                        principalTable: "users",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proudcts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingPrice = table.Column<double>(type: "float", nullable: false),
                    PurchasingPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategorysId = table.Column<int>(type: "int", nullable: false),
                    Suppliersid = table.Column<int>(type: "int", nullable: false),
                    Sellinvoceid = table.Column<int>(type: "int", nullable: false),
                    ReciptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proudcts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proudcts_Categorys_CategorysId",
                        column: x => x.CategorysId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_proudcts_recipts_ReciptId",
                        column: x => x.ReciptId,
                        principalTable: "recipts",
                        principalColumn: "bon",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_proudcts_sellinvoces_Sellinvoceid",
                        column: x => x.Sellinvoceid,
                        principalTable: "sellinvoces",
                        principalColumn: "BonNumberr",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_proudcts_suppliers_Suppliersid",
                        column: x => x.Suppliersid,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_StorId",
                table: "Categorys",
                column: "StorId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_CategorysId",
                table: "proudcts",
                column: "CategorysId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_ReciptId",
                table: "proudcts",
                column: "ReciptId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_Sellinvoceid",
                table: "proudcts",
                column: "Sellinvoceid");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_Suppliersid",
                table: "proudcts",
                column: "Suppliersid");

            migrationBuilder.CreateIndex(
                name: "IX_recipts_SuppliersId",
                table: "recipts",
                column: "SuppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_sellinvoces_casherUserNameUserName",
                table: "sellinvoces",
                column: "casherUserNameUserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "proudcts");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "recipts");

            migrationBuilder.DropTable(
                name: "sellinvoces");

            migrationBuilder.DropTable(
                name: "Stors");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
