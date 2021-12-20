using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class DecimoTercero : Controller
    {
        private readonly DBLiquidacion DB;
        public DecimoTercero(DBLiquidacion db)
        {
            DB = db;
        }
        public IActionResult Index( string nombreEmpleado="",int paginaActual = 1)
        {
            int registrosPorPagina = 5;
            Func<DecimoTercer, bool> predicado = (cel) => string.IsNullOrEmpty(nombreEmpleado) || cel.NombreEmpleado == nombreEmpleado;
            IEnumerable<DecimoTercer> ListaLiquidaciones =
                DB.Decimost
                .Where(predicado)
                .OrderBy(cel => cel.Id)
                .Skip((paginaActual - 1) * registrosPorPagina)//saltarce los primero (p-1) *n registros
                .Take(registrosPorPagina);//Tomar los siguientes n registros 

            int TotalDeRegistros = DB.Decimost.Where(predicado).Count();

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
        public IActionResult Create(DecimoTercer empleado)
        {
            DB.Decimost.Add(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");

        }
        //editar un item
        [HttpGet]
        public IActionResult Edit(int id)
        {
          DecimoTercer empleado = DB.Decimost.Find(id);
            return View(empleado);

        }
        [HttpPost]
        public IActionResult Edit(DecimoTercer empleado)
        {
            DB.Decimost.Update(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        //Borrar un item
        [HttpGet]
        public IActionResult Delete(int id)
        {
            DecimoTercer celular = DB.Decimost.Find(id);
            return View(celular);
        }
        [HttpPost]
        public IActionResult Delete(DecimoTercer empleado)
        {
            DB.Decimost.Remove(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
