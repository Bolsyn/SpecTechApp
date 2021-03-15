using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpecTechApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfTech",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfTech", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Techs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeOfTechId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Techs_TypeOfTech_TypeOfTechId",
                        column: x => x.TypeOfTechId,
                        principalTable: "TypeOfTech",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quests_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quests_Techs_TechId",
                        column: x => x.TechId,
                        principalTable: "Techs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5d12665e-7b9f-4625-b450-e20825c5b6bd"), "Заказчик" },
                    { new Guid("e5df3611-1e64-420d-87d6-d408b1434481"), "Исполнитель" },
                    { new Guid("f1e4e859-aa75-4b31-9f1c-132621172160"), "Система" },
                    { new Guid("a67fee06-72a8-469f-a615-aba1baf361b3"), "Администратор" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("406da934-8d82-4874-bb77-ebd698ce6e0b"), "Создано" },
                    { new Guid("7f6da3cb-54a4-4385-a1d4-bacdc89fcb6d"), "Поиск" },
                    { new Guid("8cf2c3f4-fb6f-4dd2-a942-476b92665cee"), "Предложено" },
                    { new Guid("5e719636-110d-4e09-8bc8-f21ffad6fb4e"), "Отказано" },
                    { new Guid("fff4691e-43b4-42de-b8a1-656705967d7c"), "Отмена" },
                    { new Guid("7630cad8-6eed-4e06-8a73-3d0aa2fbce99"), "В работе" },
                    { new Guid("56fc39c1-41c1-484b-8e65-d32f9a403b42"), "Выполнено" }
                });

            migrationBuilder.InsertData(
                table: "TypeOfTech",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("30fe6c87-4123-4ac4-9f95-f2788cd2b92b"), "Кран" },
                    { new Guid("a957cce7-6b25-4050-9bf9-2eb27d7d71ce"), "Грузовик" },
                    { new Guid("c67dff8e-b2e7-4068-a7f0-5130619f7130"), "Бульдозер" },
                    { new Guid("516d3ca0-4bdb-488b-a1cb-fcb0174127d3"), "Трактор" },
                    { new Guid("62abd389-1276-42bd-a6ef-1960ca184258"), "Газель" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quests_StatusId",
                table: "Quests",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Quests_TechId",
                table: "Quests",
                column: "TechId");

            migrationBuilder.CreateIndex(
                name: "IX_Techs_TypeOfTechId",
                table: "Techs",
                column: "TypeOfTechId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Techs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TypeOfTech");
        }
    }
}
