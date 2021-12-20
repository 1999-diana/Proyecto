using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Proyecto.Migrations
{
    public partial class ini9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Decimost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "text", nullable: true),
                    fechaInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechafin = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    meses = table.Column<string>(type: "text", nullable: true),
                    total = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decimost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "text", nullable: true),
                    sueldo = table.Column<double>(type: "double precision", nullable: false),
                    LiquidacionTotal = table.Column<double>(type: "double precision", nullable: false),
                    DicemoTercerSueldo = table.Column<double>(type: "double precision", nullable: false),
                    RoldePagos = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Liquidaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "text", nullable: true),
                    periodoCesa = table.Column<string>(type: "text", nullable: true),
                    periodoPri = table.Column<string>(type: "text", nullable: true),
                    periodoVaca = table.Column<string>(type: "text", nullable: true),
                    salarioBase = table.Column<double>(type: "double precision", nullable: false),
                    auxilioTrans = table.Column<double>(type: "double precision", nullable: false),
                    tipoContrato = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "text", nullable: true),
                    tipocontrato = table.Column<string>(type: "text", nullable: true),
                    fechaInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechafin = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ultimaremuneracion = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    tipoprovincia = table.Column<string>(type: "text", nullable: true),
                    decimotercer = table.Column<double>(type: "double precision", nullable: false),
                    diasvacaciones = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreEmpleado = table.Column<string>(type: "text", nullable: true),
                    sueldobasico = table.Column<double>(type: "double precision", nullable: false),
                    horasextras = table.Column<double>(type: "double precision", nullable: false),
                    comision = table.Column<double>(type: "double precision", nullable: false),
                    aportes = table.Column<double>(type: "double precision", nullable: false),
                    prestamos = table.Column<double>(type: "double precision", nullable: false),
                    total = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Decimost",
                columns: new[] { "Id", "NombreEmpleado", "fechaInicio", "fechafin", "meses", "total" },
                values: new object[,]
                {
                    { 1, "JOSE CORREA", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 MESES", 329.0 },
                    { 2, "ANDRES CORDOVA", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " 8 MESES", 440.45001220703125 },
                    { 3, "GABRIEL SANDOVAL", new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), " 8 MESES", 440.45001220703125 },
                    { 4, "DILAN LEON", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), " 8 MESES", 440.45001220703125 },
                    { 5, "ANDREA LOPEZ", new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), " 8 MESES", 440.45001220703125 },
                    { 6, "JOSE CORREA", new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), " 8 MESES", 440.45001220703125 },
                    { 7, "ANDRES CORDOVA", new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), " 8 MESES", 440.45001220703125 }
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "id", "DicemoTercerSueldo", "LiquidacionTotal", "NombreEmpleado", "RoldePagos", "sueldo" },
                values: new object[,]
                {
                    { 6, 560.0, 1670.0, "CARMEN MENDOZA", 390.0, 280.0 },
                    { 5, 760.0, 200.0, "ANDREA LOPEZ", 420.0, 300.0 },
                    { 4, 450.0, 255.89999389648438, "DILAN LEON", 450.0, 350.0 },
                    { 3, 670.0, 275.0, "GABRIEL SANDOVAL", 500.0, 400.0 },
                    { 2, 880.0, 6780.0, "ANDRES CORDOVA", 700.0, 550.5 },
                    { 1, 780.0, 3780.0, "JOSE CORREA", 520.0, 450.0 }
                });

            migrationBuilder.InsertData(
                table: "Liquidaciones",
                columns: new[] { "Id", "NombreEmpleado", "auxilioTrans", "periodoCesa", "periodoPri", "periodoVaca", "salarioBase", "tipoContrato" },
                values: new object[,]
                {
                    { 7, "ANDRES CORDOVA", 100.0, " 9 AÑOS ", " 3 AÑOS ", " 4 Años ", 280.0, "Por acuerdo de las partes" },
                    { 6, "JOSE CORREA", 200.0, " 7 AÑOS ", " 1 AÑOS ", " 3 Años ", 450.0, "Por la conclusion de la obra" },
                    { 5, "ANDREA LOPEZ", 4500.0, " 1 AÑOS ", " 2 AÑOS ", " 7 Años ", 300.0, "Por la conclusion de la obra" },
                    { 4, "DILAN LEON", 380.0, " 4 AÑOS ", " 7 AÑOS ", " 6 Años ", 350.0, "Por desahicio" },
                    { 3, "GABRIEL SANDOVAL", 240.0, " 6 AÑOS ", " 5 AÑOS ", " 4 Años ", 400.0, "Por desahicio" },
                    { 2, "ANDRES CORDOVA", 220.0, " 8 AÑOS ", " 2 AÑOS ", " 1 Años ", 550.0, "Por acuerdo de las partes" },
                    { 1, "JOSE CORREA", 120.0, " 5 AÑOS ", " 3 AÑOS ", " 2 Años ", 450.0, "Por acuerdo de las partes" }
                });

            migrationBuilder.InsertData(
                table: "personales",
                columns: new[] { "Id", "NombreEmpleado", "decimotercer", "diasvacaciones", "fechaInicio", "fechafin", "tipocontrato", "tipoprovincia", "ultimaremuneracion" },
                values: new object[,]
                {
                    { 4, "DILAN LEON", 330.0, "90 dias", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Por la conclusion de la obra", "costa", new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "ANDREA LOPEZ", 460.0, "80 dias", new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Por la conclusion de la obra", "sierra", new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "GABRIEL SANDOVAL", 300.0, "70 dias", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), " Por desahicio ", "costa", new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ANDRES CORDOVA", 280.0, "60 dias", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), " Por desahicio ", "oriente", new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "JOSE CORREA", 230.0, "90 dias", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Por acuerdo de las partes ", "sierra", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "JOSE CORREA", 780.0, "110 dias", new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Por acuerdo de las partes ", "oriente", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "Id", "NombreEmpleado", "aportes", "comision", "horasextras", "prestamos", "sueldobasico", "total" },
                values: new object[,]
                {
                    { 6, "JOSE CORREA", 10.0, 31.0, 55.0, 21.0, 650.0, 300.0 },
                    { 1, "JOSE CORREA", 0.0, 23.0, 45.0, 23.0, 340.0, 340.0 },
                    { 2, "ANDRES CORDOVA", 8.0, 21.0, 48.0, 21.0, 380.0, 740.0 },
                    { 3, "GABRIEL SANDOVAL", 0.0, 20.0, 40.0, 22.0, 440.0, 640.0 },
                    { 4, "DILAN LEON", 9.0, 22.0, 41.0, 22.0, 400.0, 540.0 },
                    { 5, "ANDREA LOPEZ", 0.0, 33.0, 50.0, 23.0, 230.0, 440.0 },
                    { 7, "ANDRES CORDOVA", 0.0, 30.0, 75.0, 13.0, 670.0, 680.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decimost");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Liquidaciones");

            migrationBuilder.DropTable(
                name: "personales");

            migrationBuilder.DropTable(
                name: "rol");
        }
    }
}
