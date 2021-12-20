using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{

    public class LiquidacionTotal : Controller

    {
        private readonly DBLiquidacion DB;
        public LiquidacionTotal(DBLiquidacion db)
        {
            DB = db;
        }
        public IActionResult Index(string periodo = "", int paginaActual = 1)
        {
            int registrosPorPagina = 5;
            Func<Liquidacion, bool> predicado = (cel) => string.IsNullOrEmpty(periodo) || cel.NombreEmpleado == periodo;
            IEnumerable<Liquidacion> ListaLiquidaciones = DB.Liquidaciones
                .Where(predicado)
                .OrderBy(cel => cel.Id)
                .Skip((paginaActual - 1) * registrosPorPagina)//saltarce los primero (p-1) *n registros
                .Take(registrosPorPagina);//Tomar los siguientes n registros 

            int TotalDeRegistros = DB.Liquidaciones.Where(predicado).Count();

            var modeloConPaginacion = new Paginacion
            {
                entidades = ListaLiquidaciones,
                PaginaActual = paginaActual,
                RegistrosPorPagina = registrosPorPagina,
                TotalDeRegistros = TotalDeRegistros
            };
            ;
            return View(modeloConPaginacion);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Liquidacion empleado)
        {
            DB.Liquidaciones.Add(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");

        }
        //editar un item
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Liquidacion empleado = DB.Liquidaciones.Find(id);
            return View(empleado);

        }
        [HttpPost]
        public IActionResult Edit(Liquidacion empleado)
        {
            DB.Liquidaciones.Update(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        //Borrar un item
        [HttpGet]
        public IActionResult Delete(int id)
        {
           Liquidacion celular = DB.Liquidaciones.Find(id);
            return View(celular);
        }
        [HttpPost]
        public IActionResult Delete(Liquidacion empleado)
        {
            DB.Liquidaciones.Remove(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
