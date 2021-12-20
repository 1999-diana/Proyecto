﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proyecto.Data;

namespace Proyecto.Migrations
{
    [DbContext(typeof(DBLiquidacion))]
    [Migration("20211214052946_ini9")]
    partial class ini9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Proyecto.Models.DecimoTercer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechafin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("meses")
                        .HasColumnType("text");

                    b.Property<double>("total")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Decimost");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NombreEmpleado = "JOSE CORREA",
                            fechaInicio = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = "6 MESES",
                            total = 329.0
                        },
                        new
                        {
                            Id = 2,
                            NombreEmpleado = "ANDRES CORDOVA",
                            fechaInicio = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = " 8 MESES",
                            total = 440.45001220703125
                        },
                        new
                        {
                            Id = 3,
                            NombreEmpleado = "GABRIEL SANDOVAL",
                            fechaInicio = new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = " 8 MESES",
                            total = 440.45001220703125
                        },
                        new
                        {
                            Id = 4,
                            NombreEmpleado = "DILAN LEON",
                            fechaInicio = new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = " 8 MESES",
                            total = 440.45001220703125
                        },
                        new
                        {
                            Id = 5,
                            NombreEmpleado = "ANDREA LOPEZ",
                            fechaInicio = new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = " 8 MESES",
                            total = 440.45001220703125
                        },
                        new
                        {
                            Id = 6,
                            NombreEmpleado = "JOSE CORREA",
                            fechaInicio = new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2026, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = " 8 MESES",
                            total = 440.45001220703125
                        },
                        new
                        {
                            Id = 7,
                            NombreEmpleado = "ANDRES CORDOVA",
                            fechaInicio = new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2025, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            meses = " 8 MESES",
                            total = 440.45001220703125
                        });
                });

            modelBuilder.Entity("Proyecto.Models.Empleado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("DicemoTercerSueldo")
                        .HasColumnType("double precision");

                    b.Property<double>("LiquidacionTotal")
                        .HasColumnType("double precision");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("text");

                    b.Property<double>("RoldePagos")
                        .HasColumnType("double precision");

                    b.Property<double>("sueldo")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DicemoTercerSueldo = 780.0,
                            LiquidacionTotal = 3780.0,
                            NombreEmpleado = "JOSE CORREA",
                            RoldePagos = 520.0,
                            sueldo = 450.0
                        },
                        new
                        {
                            id = 2,
                            DicemoTercerSueldo = 880.0,
                            LiquidacionTotal = 6780.0,
                            NombreEmpleado = "ANDRES CORDOVA",
                            RoldePagos = 700.0,
                            sueldo = 550.5
                        },
                        new
                        {
                            id = 3,
                            DicemoTercerSueldo = 670.0,
                            LiquidacionTotal = 275.0,
                            NombreEmpleado = "GABRIEL SANDOVAL",
                            RoldePagos = 500.0,
                            sueldo = 400.0
                        },
                        new
                        {
                            id = 4,
                            DicemoTercerSueldo = 450.0,
                            LiquidacionTotal = 255.89999389648438,
                            NombreEmpleado = "DILAN LEON",
                            RoldePagos = 450.0,
                            sueldo = 350.0
                        },
                        new
                        {
                            id = 5,
                            DicemoTercerSueldo = 760.0,
                            LiquidacionTotal = 200.0,
                            NombreEmpleado = "ANDREA LOPEZ",
                            RoldePagos = 420.0,
                            sueldo = 300.0
                        },
                        new
                        {
                            id = 6,
                            DicemoTercerSueldo = 560.0,
                            LiquidacionTotal = 1670.0,
                            NombreEmpleado = "CARMEN MENDOZA",
                            RoldePagos = 390.0,
                            sueldo = 280.0
                        });
                });

            modelBuilder.Entity("Proyecto.Models.InformacionPersonal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("text");

                    b.Property<double>("decimotercer")
                        .HasColumnType("double precision");

                    b.Property<string>("diasvacaciones")
                        .HasColumnType("text");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("fechafin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("tipocontrato")
                        .HasColumnType("text");

                    b.Property<string>("tipoprovincia")
                        .HasColumnType("text");

                    b.Property<DateTime>("ultimaremuneracion")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("personales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NombreEmpleado = "JOSE CORREA",
                            decimotercer = 230.0,
                            diasvacaciones = "90 dias",
                            fechaInicio = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipocontrato = " Por acuerdo de las partes ",
                            tipoprovincia = "sierra",
                            ultimaremuneracion = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            NombreEmpleado = "ANDRES CORDOVA",
                            decimotercer = 280.0,
                            diasvacaciones = "60 dias",
                            fechaInicio = new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipocontrato = " Por desahicio ",
                            tipoprovincia = "oriente",
                            ultimaremuneracion = new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            NombreEmpleado = "GABRIEL SANDOVAL",
                            decimotercer = 300.0,
                            diasvacaciones = "70 dias",
                            fechaInicio = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipocontrato = " Por desahicio ",
                            tipoprovincia = "costa",
                            ultimaremuneracion = new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            NombreEmpleado = "DILAN LEON",
                            decimotercer = 330.0,
                            diasvacaciones = "90 dias",
                            fechaInicio = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipocontrato = "Por la conclusion de la obra",
                            tipoprovincia = "costa",
                            ultimaremuneracion = new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            NombreEmpleado = "ANDREA LOPEZ",
                            decimotercer = 460.0,
                            diasvacaciones = "80 dias",
                            fechaInicio = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipocontrato = "Por la conclusion de la obra",
                            tipoprovincia = "sierra",
                            ultimaremuneracion = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            NombreEmpleado = "JOSE CORREA",
                            decimotercer = 780.0,
                            diasvacaciones = "110 dias",
                            fechaInicio = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            fechafin = new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipocontrato = " Por acuerdo de las partes ",
                            tipoprovincia = "oriente",
                            ultimaremuneracion = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Proyecto.Models.Liquidacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("text");

                    b.Property<double>("auxilioTrans")
                        .HasColumnType("double precision");

                    b.Property<string>("periodoCesa")
                        .HasColumnType("text");

                    b.Property<string>("periodoPri")
                        .HasColumnType("text");

                    b.Property<string>("periodoVaca")
                        .HasColumnType("text");

                    b.Property<double>("salarioBase")
                        .HasColumnType("double precision");

                    b.Property<string>("tipoContrato")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Liquidaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NombreEmpleado = "JOSE CORREA",
                            auxilioTrans = 120.0,
                            periodoCesa = " 5 AÑOS ",
                            periodoPri = " 3 AÑOS ",
                            periodoVaca = " 2 Años ",
                            salarioBase = 450.0,
                            tipoContrato = "Por acuerdo de las partes"
                        },
                        new
                        {
                            Id = 2,
                            NombreEmpleado = "ANDRES CORDOVA",
                            auxilioTrans = 220.0,
                            periodoCesa = " 8 AÑOS ",
                            periodoPri = " 2 AÑOS ",
                            periodoVaca = " 1 Años ",
                            salarioBase = 550.0,
                            tipoContrato = "Por acuerdo de las partes"
                        },
                        new
                        {
                            Id = 3,
                            NombreEmpleado = "GABRIEL SANDOVAL",
                            auxilioTrans = 240.0,
                            periodoCesa = " 6 AÑOS ",
                            periodoPri = " 5 AÑOS ",
                            periodoVaca = " 4 Años ",
                            salarioBase = 400.0,
                            tipoContrato = "Por desahicio"
                        },
                        new
                        {
                            Id = 4,
                            NombreEmpleado = "DILAN LEON",
                            auxilioTrans = 380.0,
                            periodoCesa = " 4 AÑOS ",
                            periodoPri = " 7 AÑOS ",
                            periodoVaca = " 6 Años ",
                            salarioBase = 350.0,
                            tipoContrato = "Por desahicio"
                        },
                        new
                        {
                            Id = 5,
                            NombreEmpleado = "ANDREA LOPEZ",
                            auxilioTrans = 4500.0,
                            periodoCesa = " 1 AÑOS ",
                            periodoPri = " 2 AÑOS ",
                            periodoVaca = " 7 Años ",
                            salarioBase = 300.0,
                            tipoContrato = "Por la conclusion de la obra"
                        },
                        new
                        {
                            Id = 6,
                            NombreEmpleado = "JOSE CORREA",
                            auxilioTrans = 200.0,
                            periodoCesa = " 7 AÑOS ",
                            periodoPri = " 1 AÑOS ",
                            periodoVaca = " 3 Años ",
                            salarioBase = 450.0,
                            tipoContrato = "Por la conclusion de la obra"
                        },
                        new
                        {
                            Id = 7,
                            NombreEmpleado = "ANDRES CORDOVA",
                            auxilioTrans = 100.0,
                            periodoCesa = " 9 AÑOS ",
                            periodoPri = " 3 AÑOS ",
                            periodoVaca = " 4 Años ",
                            salarioBase = 280.0,
                            tipoContrato = "Por acuerdo de las partes"
                        });
                });

            modelBuilder.Entity("Proyecto.Models.RoldePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("text");

                    b.Property<double>("aportes")
                        .HasColumnType("double precision");

                    b.Property<double>("comision")
                        .HasColumnType("double precision");

                    b.Property<double>("horasextras")
                        .HasColumnType("double precision");

                    b.Property<double>("prestamos")
                        .HasColumnType("double precision");

                    b.Property<double>("sueldobasico")
                        .HasColumnType("double precision");

                    b.Property<double>("total")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("rol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NombreEmpleado = "JOSE CORREA",
                            aportes = 0.0,
                            comision = 23.0,
                            horasextras = 45.0,
                            prestamos = 23.0,
                            sueldobasico = 340.0,
                            total = 340.0
                        },
                        new
                        {
                            Id = 2,
                            NombreEmpleado = "ANDRES CORDOVA",
                            aportes = 8.0,
                            comision = 21.0,
                            horasextras = 48.0,
                            prestamos = 21.0,
                            sueldobasico = 380.0,
                            total = 740.0
                        },
                        new
                        {
                            Id = 3,
                            NombreEmpleado = "GABRIEL SANDOVAL",
                            aportes = 0.0,
                            comision = 20.0,
                            horasextras = 40.0,
                            prestamos = 22.0,
                            sueldobasico = 440.0,
                            total = 640.0
                        },
                        new
                        {
                            Id = 4,
                            NombreEmpleado = "DILAN LEON",
                            aportes = 9.0,
                            comision = 22.0,
                            horasextras = 41.0,
                            prestamos = 22.0,
                            sueldobasico = 400.0,
                            total = 540.0
                        },
                        new
                        {
                            Id = 5,
                            NombreEmpleado = "ANDREA LOPEZ",
                            aportes = 0.0,
                            comision = 33.0,
                            horasextras = 50.0,
                            prestamos = 23.0,
                            sueldobasico = 230.0,
                            total = 440.0
                        },
                        new
                        {
                            Id = 6,
                            NombreEmpleado = "JOSE CORREA",
                            aportes = 10.0,
                            comision = 31.0,
                            horasextras = 55.0,
                            prestamos = 21.0,
                            sueldobasico = 650.0,
                            total = 300.0
                        },
                        new
                        {
                            Id = 7,
                            NombreEmpleado = "ANDRES CORDOVA",
                            aportes = 0.0,
                            comision = 30.0,
                            horasextras = 75.0,
                            prestamos = 13.0,
                            sueldobasico = 670.0,
                            total = 680.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
