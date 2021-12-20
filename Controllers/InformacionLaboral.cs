using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class InformacionLaboral : Controller
    {
        private readonly DBLiquidacion DB;
        public InformacionLaboral(DBLiquidacion db)
        {
            DB = db;
        }
        public IActionResult Index(string provincia = "", int paginaActual = 1)
        {
            int registrosPorPagina = 5;
            Func<InformacionPersonal, bool> predicado = (cel) => string.IsNullOrEmpty(provincia) || cel.NombreEmpleado == provincia;
            IEnumerable<InformacionPersonal> ListaLiquidaciones = DB.personales
                .Where(predicado)
                .OrderBy(cel => cel.Id)
                .Skip((paginaActual - 1) * registrosPorPagina)//saltarce los primero (p-1) *n registros
                .Take(registrosPorPagina);//Tomar los siguientes n registros 

            int TotalDeRegistros = DB.personales.Where(predicado).Count();

            var modeloConPaginacion = new Paginacion
            {
               entidades = ListaLiquidaciones,
                PaginaActual = paginaActual,
                RegistrosPorPagina = registrosPorPagina,
                TotalDeRegistros = TotalDeRegistros
            }; ;
            return View(modeloConPaginacion);
        }
         [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(InformacionPersonal informacion)
        {
            DB.personales.Add(informacion);
            DB.SaveChanges();
            return RedirectToAction("Index");

        }
        //editar un item
        [HttpGet]
        public IActionResult Edit(int id)
        {
            InformacionPersonal empleado = DB.personales.Find(id);
            return View(empleado);

        }
        [HttpPost]
        public IActionResult Edit(InformacionPersonal empleado)
        {
            DB.personales.Update(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        //Borrar un item
        [HttpGet]
        public IActionResult Delete(int id)
        {
            InformacionPersonal celular = DB.personales.Find(id);
            return View(celular);
        }
        [HttpPost]
        public IActionResult Delete(InformacionPersonal empleado)
        {
            DB.personales.Remove(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
