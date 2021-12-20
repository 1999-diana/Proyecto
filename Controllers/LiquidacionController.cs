using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class LiquidacionController : Controller
    {
        private readonly DBLiquidacion DB;

        // GET: LiquidacionController
        public LiquidacionController(DBLiquidacion db)
        {
            DB = db;
        }
        public IActionResult Index(string empleado="",int paginaActual = 1)
        {
            int registrosPorPagina = 5;
            Func<Empleado,bool> predicado = (cel) => string.IsNullOrEmpty(empleado) || cel.NombreEmpleado == empleado;
            IEnumerable<Empleado> ListaEmpleados = DB.Empleados
                .Where(predicado)
                .OrderBy(cel => cel.id)
                .Skip((paginaActual - 1) * registrosPorPagina)//saltarce los primero (p-1) *n registros
                .Take(registrosPorPagina);//Tomar los siguientes n registros 

            int TotalDeRegistros = DB.Empleados.Where(predicado).Count();

            var modeloConPaginacion = new Paginacion
            {
              entidades = ListaEmpleados,
                PaginaActual = paginaActual,
                RegistrosPorPagina = registrosPorPagina,
                TotalDeRegistros = TotalDeRegistros
            };
            
            return View(modeloConPaginacion);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            DB.Empleados.Add(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");

        }
        //editar un item
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Empleado empleado = DB.Empleados.Find(id);
            return View(empleado);

        }
        [HttpPost]
        public IActionResult Edit(Empleado empleado)
        {
            DB.Empleados.Update(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        //Borrar un item
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Empleado celular = DB.Empleados.Find(id);
            return View(celular);
        }
        [HttpPost]
        public IActionResult Delete(Empleado empleado)
        {
            DB.Empleados.Remove(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
