using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo_Seeing.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Wachtwoord = table.Column<string>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true),
                    Achternaam = table.Column<string>(nullable: true),
                    Geboortendatum = table.Column<DateTime>(nullable: false),
                    Geslacht = table.Column<int>(nullable: false),
                    Rol = table.Column<int>(nullable: false),
                    UserActive = table.Column<bool>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sensoren",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Locatie = table.Column<string>(nullable: true),
                    Battery = table.Column<int>(nullable: false),
                    SensorType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensoren", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activiteiten",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Naam = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Aantal = table.Column<int>(nullable: false),
                    Tijdslot_grote = table.Column<int>(nullable: false),
                    Start_Activiteit = table.Column<DateTime>(nullable: false),
                    Eind_Activiteit = table.Column<DateTime>(nullable: false),
                    Gebruiker_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activiteiten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activiteiten_Gebruikers_Gebruiker_Id",
                        column: x => x.Gebruiker_Id,
                        principalTable: "Gebruikers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sensors_Acties",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sensor_Id = table.Column<Guid>(nullable: false),
                    Aantal_bewegingen = table.Column<int>(nullable: false),
                    Tijd = table.Column<DateTime>(nullable: false),
                    Soort_beweging = table.Column<int>(nullable: false),
                    Snelheid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors_Acties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sensors_Acties_Sensoren_Sensor_Id",
                        column: x => x.Sensor_Id,
                        principalTable: "Sensoren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reseverings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tijdslot_Start = table.Column<DateTime>(nullable: false),
                    Tijdslot_Eind = table.Column<DateTime>(nullable: false),
                    Gebruiker_Id = table.Column<Guid>(nullable: false),
                    Activiteit_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reseverings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reseverings_Activiteiten_Activiteit_Id",
                        column: x => x.Activiteit_Id,
                        principalTable: "Activiteiten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reseverings_Gebruikers_Gebruiker_Id",
                        column: x => x.Gebruiker_Id,
                        principalTable: "Gebruikers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activiteiten_Gebruiker_Id",
                table: "Activiteiten",
                column: "Gebruiker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reseverings_Activiteit_Id",
                table: "Reseverings",
                column: "Activiteit_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reseverings_Gebruiker_Id",
                table: "Reseverings",
                column: "Gebruiker_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Sensors_Acties_Sensor_Id",
                table: "Sensors_Acties",
                column: "Sensor_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reseverings");

            migrationBuilder.DropTable(
                name: "Sensors_Acties");

            migrationBuilder.DropTable(
                name: "Activiteiten");

            migrationBuilder.DropTable(
                name: "Sensoren");

            migrationBuilder.DropTable(
                name: "Gebruikers");
        }
    }
}
