using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agencias",
                columns: table => new
                {
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direction = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Poblation = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencias", x => x.AgencyId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Province = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    DNI = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecondSurname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direction = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.DNI);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAgency = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Celular_Agencias_IdAgency",
                        column: x => x.IdAgency,
                        principalTable: "Agencias",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Garaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCity = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Num = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garaje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Garaje_Ciudad_IdCity",
                        column: x => x.IdCity,
                        principalTable: "Ciudad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Motocicleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumBast = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Color = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    model = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdGarage = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Num = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdAgency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motocicleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motocicleta_Agencias_IdAgency",
                        column: x => x.IdAgency,
                        principalTable: "Agencias",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motocicleta_Garaje_IdGarage",
                        column: x => x.IdGarage,
                        principalTable: "Garaje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Renta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMotorcycle = table.Column<int>(type: "int", nullable: false),
                    IdAgency = table.Column<int>(type: "int", nullable: false),
                    DNIClient = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateI = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dateF = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dateR = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Paidout = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Renta_Agencias_IdAgency",
                        column: x => x.IdAgency,
                        principalTable: "Agencias",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Renta_Cliente_DNIClient",
                        column: x => x.DNIClient,
                        principalTable: "Cliente",
                        principalColumn: "DNI",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Renta_Motocicleta_IdMotorcycle",
                        column: x => x.IdMotorcycle,
                        principalTable: "Motocicleta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Agencias",
                columns: new[] { "AgencyId", "Direction", "Name", "Poblation" },
                values: new object[,]
                {
                    { 1, "Calle del recuerdo", "Kevin", "Santa Barbara" },
                    { 2, "Calle de la soledad", "Jose", "Santa Ana" }
                });

            migrationBuilder.InsertData(
                table: "Ciudad",
                columns: new[] { "Id", "Name", "Population", "Province" },
                values: new object[,]
                {
                    { 1, "Kevin", 1000, "Kennedy" },
                    { 2, "Jose", 10000, "Guateque" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "DNI", "City", "Direction", "Name", "Phone", "SecondSurname", "Surname" },
                values: new object[,]
                {
                    { "1049794204", "Bogota", "cr 82 #42 f 56 sur", "Kevin", "3219250893", "Ramirez", "Moreno" },
                    { "23622563", "Guateque", "calle 13 #4-37", "Luz", "3145463634", "Sayns", "Banish" }
                });

            migrationBuilder.InsertData(
                table: "Celular",
                columns: new[] { "Id", "IdAgency", "phone" },
                values: new object[,]
                {
                    { 1, 1, "3219250893" },
                    { 2, 2, "3514567895" }
                });

            migrationBuilder.InsertData(
                table: "Garaje",
                columns: new[] { "Id", "IdCity", "Name", "Num", "Street" },
                values: new object[,]
                {
                    { 1, 1, "Kevin", 123, "cr 82 #42 f 56 sur" },
                    { 2, 2, "Jose", 456, "cr 82 #42 f 56 sur" }
                });

            migrationBuilder.InsertData(
                table: "Motocicleta",
                columns: new[] { "Id", "Brand", "Color", "Date", "IdAgency", "IdGarage", "Num", "NumBast", "Street", "model" },
                values: new object[] { 1, "Ferrari", "Blue", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, 123, "White", "Griislong", "C-666" });

            migrationBuilder.InsertData(
                table: "Motocicleta",
                columns: new[] { "Id", "Brand", "Color", "Date", "IdAgency", "IdGarage", "Num", "NumBast", "Street", "model" },
                values: new object[] { 2, "Supra", "Red", new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, 2, 345, "Dark", "Smile", "Z-333" });

            migrationBuilder.InsertData(
                table: "Renta",
                columns: new[] { "Id", "DNIClient", "IdAgency", "IdMotorcycle", "Paidout", "Price", "dateF", "dateI", "dateR" },
                values: new object[] { 1, "1049794204", 1, 1, "Yes", 1000, new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Renta",
                columns: new[] { "Id", "DNIClient", "IdAgency", "IdMotorcycle", "Paidout", "Price", "dateF", "dateI", "dateR" },
                values: new object[] { 2, "23622563", 2, 2, "No", 2000, new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_IdAgency",
                table: "Celular",
                column: "IdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Garaje_IdCity",
                table: "Garaje",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_Motocicleta_IdAgency",
                table: "Motocicleta",
                column: "IdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Motocicleta_IdGarage",
                table: "Motocicleta",
                column: "IdGarage");

            migrationBuilder.CreateIndex(
                name: "IX_Renta_DNIClient",
                table: "Renta",
                column: "DNIClient");

            migrationBuilder.CreateIndex(
                name: "IX_Renta_IdAgency",
                table: "Renta",
                column: "IdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Renta_IdMotorcycle",
                table: "Renta",
                column: "IdMotorcycle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Celular");

            migrationBuilder.DropTable(
                name: "Renta");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Motocicleta");

            migrationBuilder.DropTable(
                name: "Agencias");

            migrationBuilder.DropTable(
                name: "Garaje");

            migrationBuilder.DropTable(
                name: "Ciudad");
        }
    }
}
