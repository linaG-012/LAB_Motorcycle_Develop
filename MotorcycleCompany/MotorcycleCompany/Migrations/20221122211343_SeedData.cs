using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agency",
                columns: new[] { "AgencyId", "Address", "Location", "Name", "Neighborhood" },
                values: new object[,]
                {
                    { new Guid("3eadac48-b832-49a5-888b-ad121f3ee0ff"), "Calle de la soledad", "Usaquen", "Agencia02", "Santa Ana" },
                    { new Guid("d5fb6bd2-86c7-4f22-a825-6f3c70b89c72"), "Calle del recuerdo", "Usaquen", "Agencia01", "Santa Barbara" }
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Address", "E-Mail", "FistName", "LastName", "Number", "Phone", "TypeId" },
                values: new object[,]
                {
                    { new Guid("63fe095b-7e00-4948-9849-73a4f4117eab"), "La calle de la Melancolia", "ana.yaqueline@misena.edu.co", "Ana Yaqueline", "Chavarro", "79802911", "3153666037", "CC" },
                    { new Guid("b99adb00-c777-4c55-a3a7-276ec9c99343"), "La calle del ocio", "german.alarcon@misena.edu.co", "German Gilberto", "Alarcon R", "79802910", "3153666036", "CC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agency",
                keyColumn: "AgencyId",
                keyValue: new Guid("3eadac48-b832-49a5-888b-ad121f3ee0ff"));

            migrationBuilder.DeleteData(
                table: "Agency",
                keyColumn: "AgencyId",
                keyValue: new Guid("d5fb6bd2-86c7-4f22-a825-6f3c70b89c72"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("63fe095b-7e00-4948-9849-73a4f4117eab"));

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: new Guid("b99adb00-c777-4c55-a3a7-276ec9c99343"));
        }
    }
}
