using System;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class DBLiquidacion:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Liquidacion> Liquidaciones { get; set; }
        public DbSet<InformacionPersonal> personales { get; set; }
        public DbSet<DecimoTercer>Decimost{ get; set; }
        public DbSet<RoldePago> rol { get; set; }

        public DBLiquidacion(DbContextOptions<DBLiquidacion> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Empleado>().HasData(
                new Empleado { id = 1, NombreEmpleado = "JOSE CORREA", sueldo=450.00f,LiquidacionTotal=3780.00f,DicemoTercerSueldo=780.00f,RoldePagos=520.00f},
               new Empleado { id = 2, NombreEmpleado = "ANDRES CORDOVA", sueldo = 550.50f, LiquidacionTotal = 6780.00f, DicemoTercerSueldo = 880.00f, RoldePagos = 700.00f },
               new Empleado { id = 3, NombreEmpleado = "GABRIEL SANDOVAL", sueldo = 400.00f, LiquidacionTotal = 275.00f, DicemoTercerSueldo = 670.00f, RoldePagos = 500.00f },
               new Empleado { id = 4, NombreEmpleado = "DILAN LEON", sueldo = 350.00f, LiquidacionTotal = 255.90f, DicemoTercerSueldo = 450.00f, RoldePagos = 450.00f },
               new Empleado { id = 5, NombreEmpleado = "ANDREA LOPEZ", sueldo =300.00f, LiquidacionTotal = 200.00f, DicemoTercerSueldo = 760.00f, RoldePagos = 420.00f },
               new Empleado { id = 6, NombreEmpleado = "CARMEN MENDOZA", sueldo = 280.00f, LiquidacionTotal = 1670.00f, DicemoTercerSueldo = 560.00f, RoldePagos = 390.00f }
               
                );

            builder.Entity<Liquidacion>().HasData(
                new Liquidacion{ Id = 1, NombreEmpleado = "JOSE CORREA", periodoCesa = " 5 AÑOS ", periodoPri = " 3 AÑOS ", periodoVaca = " 2 Años ", salarioBase=450.00f ,auxilioTrans=120.00f ,tipoContrato= "Por acuerdo de las partes" },
                new Liquidacion { Id = 2, NombreEmpleado = "ANDRES CORDOVA", periodoCesa = " 8 AÑOS ", periodoPri = " 2 AÑOS ", periodoVaca = " 1 Años ", salarioBase = 550.00f, auxilioTrans = 220.00f, tipoContrato = "Por acuerdo de las partes" },
                 new Liquidacion { Id = 3, NombreEmpleado = "GABRIEL SANDOVAL", periodoCesa = " 6 AÑOS ", periodoPri = " 5 AÑOS ", periodoVaca = " 4 Años ", salarioBase = 400.00f, auxilioTrans = 240.00f, tipoContrato = "Por desahicio" },
                  new Liquidacion { Id = 4, NombreEmpleado = "DILAN LEON", periodoCesa = " 4 AÑOS ", periodoPri = " 7 AÑOS ", periodoVaca = " 6 Años ", salarioBase = 350.00f, auxilioTrans = 380.00f, tipoContrato = "Por desahicio" },
                   new Liquidacion { Id = 5, NombreEmpleado = "ANDREA LOPEZ", periodoCesa = " 1 AÑOS ", periodoPri = " 2 AÑOS ", periodoVaca = " 7 Años ", salarioBase = 300.00f, auxilioTrans = 4500.00f, tipoContrato = "Por la conclusion de la obra" },
                    new Liquidacion { Id = 6, NombreEmpleado = "JOSE CORREA", periodoCesa = " 7 AÑOS ", periodoPri = " 1 AÑOS ", periodoVaca = " 3 Años ", salarioBase = 450.00f, auxilioTrans = 200.00f, tipoContrato = "Por la conclusion de la obra" },
                     new Liquidacion { Id = 7, NombreEmpleado = "ANDRES CORDOVA", periodoCesa = " 9 AÑOS ", periodoPri = " 3 AÑOS ", periodoVaca = " 4 Años ", salarioBase = 280.00f, auxilioTrans = 100.00f, tipoContrato = "Por acuerdo de las partes" }


                );
              builder.Entity<InformacionPersonal>().HasData(
               new InformacionPersonal { Id = 1, NombreEmpleado = "JOSE CORREA", tipocontrato = " Por acuerdo de las partes ", fechaInicio = new DateTime(2020, 4, 1), fechafin = new DateTime (2021, 4, 1), ultimaremuneracion = new DateTime(2020, 4, 1), tipoprovincia = "sierra", decimotercer = 230.00f,diasvacaciones="90 dias"},
              new InformacionPersonal { Id = 2, NombreEmpleado = "ANDRES CORDOVA", tipocontrato = " Por desahicio ", fechaInicio = new DateTime(2020, 5, 1), fechafin = new DateTime (2022, 12, 11), ultimaremuneracion = new DateTime(2019, 12, 11), tipoprovincia = "oriente", decimotercer = 280.00f, diasvacaciones = "60 dias" },
              new InformacionPersonal { Id = 3, NombreEmpleado = "GABRIEL SANDOVAL", tipocontrato = " Por desahicio ", fechaInicio = new DateTime (2020, 6, 1), fechafin = new DateTime (2020, 8, 10), ultimaremuneracion = new DateTime (2021, 8, 10), tipoprovincia = "costa", decimotercer = 300.00f, diasvacaciones = "70 dias" },
              new InformacionPersonal { Id = 4, NombreEmpleado = "DILAN LEON", tipocontrato = "Por la conclusion de la obra", fechaInicio = new DateTime(2020, 9, 1 ),fechafin = new DateTime (2022, 4, 11), ultimaremuneracion = new DateTime(2021, 4, 11), tipoprovincia = "costa", decimotercer = 330.00f, diasvacaciones = "90 dias" },
              new InformacionPersonal { Id = 5, NombreEmpleado = "ANDREA LOPEZ", tipocontrato = "Por la conclusion de la obra", fechaInicio = new DateTime(2020, 10, 1), fechafin = new DateTime (2024, 4, 1), ultimaremuneracion = new DateTime (2023, 4, 1), tipoprovincia = "sierra", decimotercer = 460.00f, diasvacaciones = "80 dias" },
              new InformacionPersonal { Id = 6, NombreEmpleado = "JOSE CORREA", tipocontrato = " Por acuerdo de las partes ", fechaInicio = new DateTime (2020, 12, 1), fechafin = new DateTime(2025, 4, 1), ultimaremuneracion = new DateTime (2024, 4, 1), tipoprovincia = "oriente", decimotercer = 780.00f, diasvacaciones = "110 dias" }


               );
            builder.Entity<DecimoTercer>().HasData(
               new DecimoTercer { Id = 1, NombreEmpleado = "JOSE CORREA", fechaInicio = new DateTime(2020, 4, 1), fechafin = new DateTime (2021, 4, 1),meses="6 MESES",total=329.00f },
               new DecimoTercer { Id = 2, NombreEmpleado = "ANDRES CORDOVA", fechaInicio = new DateTime (2020, 6, 1), fechafin = new DateTime (2021, 9, 1) ,meses=" 8 MESES",total=440.45f},
                new DecimoTercer{ Id = 3, NombreEmpleado = "GABRIEL SANDOVAL", fechaInicio = new DateTime (2021, 8, 1), fechafin = new DateTime (2022, 11, 11), meses = " 8 MESES", total = 440.45f },
                 new DecimoTercer { Id = 4, NombreEmpleado = "DILAN LEON", fechaInicio = new DateTime(2023, 11, 1), fechafin = new DateTime(2024, 7, 8), meses = " 8 MESES", total = 440.45f },
                  new DecimoTercer { Id = 5, NombreEmpleado = "ANDREA LOPEZ", fechaInicio = new DateTime(2021, 12, 1), fechafin = new DateTime(2022, 3, 2), meses = " 8 MESES", total = 440.45f },
                   new DecimoTercer { Id = 6, NombreEmpleado = "JOSE CORREA", fechaInicio = new DateTime(2026, 9, 1),fechafin = new DateTime(2026, 7, 11), meses = " 8 MESES", total = 440.45f },
                    new DecimoTercer{ Id = 7, NombreEmpleado = "ANDRES CORDOVA", fechaInicio = new DateTime(2024, 5, 19), fechafin = new DateTime (2025, 12, 11), meses = " 8 MESES", total = 440.45f }


               );
            builder.Entity<RoldePago>().HasData(
               new RoldePago { Id = 1, NombreEmpleado = "JOSE CORREA", sueldobasico = 340.00f, horasextras = 45f, comision=23f,aportes= 0f ,prestamos=23f,total=340f},
               new RoldePago { Id = 2, NombreEmpleado = "ANDRES CORDOVA", sueldobasico = 380.00f, horasextras = 48f, comision = 21f, aportes = 8f, prestamos = 21f, total = 740f } ,
                new RoldePago { Id = 3, NombreEmpleado = "GABRIEL SANDOVAL", sueldobasico = 440.00f, horasextras = 40f, comision=20f,aportes= 0f ,prestamos=22f,total=640f},
                 new RoldePago{ Id = 4, NombreEmpleado = "DILAN LEON", sueldobasico = 400.00f, horasextras = 41f, comision = 22f, aportes = 9f, prestamos = 22f, total = 540f },
                  new RoldePago { Id = 5, NombreEmpleado = "ANDREA LOPEZ", sueldobasico = 230.00f, horasextras = 50f, comision = 33f, aportes = 0f, prestamos = 23f, total = 440f },
                   new RoldePago { Id = 6, NombreEmpleado = "JOSE CORREA", sueldobasico = 650.00f, horasextras = 55f, comision = 31f, aportes = 10f, prestamos = 21f, total = 300f },
                    new RoldePago { Id = 7, NombreEmpleado = "ANDRES CORDOVA", sueldobasico = 670.00f, horasextras = 75f, comision = 30f, aportes = 0f, prestamos = 13f, total = 680f }


               );
        }
       
    }
}

