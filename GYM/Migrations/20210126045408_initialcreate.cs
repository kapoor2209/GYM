using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GYM.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerDetail",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    DoB = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetail", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Exersice",
                columns: table => new
                {
                    ExcerciseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExersiceName = table.Column<string>(nullable: true),
                    TimeDuration = table.Column<DateTime>(nullable: false),
                    Advantage = table.Column<string>(nullable: true),
                    Disadvantage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exersice", x => x.ExcerciseID);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    TrainerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trainername = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    CostPerHour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.TrainerID);
                });

            migrationBuilder.CreateTable(
                name: "ExpTrainer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerID = table.Column<int>(nullable: false),
                    ExersiceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpTrainer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExpTrainer_Exersice_ExersiceID",
                        column: x => x.ExersiceID,
                        principalTable: "Exersice",
                        principalColumn: "ExcerciseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpTrainer_Trainer_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainer",
                        principalColumn: "TrainerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpTrainer_ExersiceID",
                table: "ExpTrainer",
                column: "ExersiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ExpTrainer_TrainerID",
                table: "ExpTrainer",
                column: "TrainerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDetail");

            migrationBuilder.DropTable(
                name: "ExpTrainer");

            migrationBuilder.DropTable(
                name: "Exersice");

            migrationBuilder.DropTable(
                name: "Trainer");
        }
    }
}
