using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class RoldePagos : Controller
    {
        private readonly DBLiquidacion DB;
        public RoldePagos(DBLiquidacion db)
        {
            DB = db;
        }
        public IActionResult Index(string nombre = "", int paginaActual = 1)
        {
            int registrosPorPagina = 5;
           Func<RoldePago, bool> predicado = (cel) => string.IsNullOrEmpty(nombre) || cel.NombreEmpleado ==nombre;
            IEnumerable<RoldePago> ListaRol = DB.rol
                .Where(predicado)
                .OrderBy(cel => cel.Id)
                .Skip((paginaActual - 1) * registrosPorPagina)//saltarce los primero (p-1) *n registros
                .Take(registrosPorPagina);//Tomar los siguientes n registros 

            int TotalDeRegistros = DB.rol.Where(predicado).Count();

            var modeloConPaginacion = new Paginacion
            {
                entidades = ListaRol,
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
        public IActionResult Create(RoldePago empleado)
        {
            DB.rol.Add(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");

        }
        //editar un item
        [HttpGet]
        public IActionResult Edit(int id)
        {
            RoldePago empleado = DB.rol.Find(id);
            return View(empleado);

        }
        [HttpPost]
        public IActionResult Edit(RoldePago empleado)
        {
            DB.rol.Update(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }
        //Borrar un item
        [HttpGet]
        public IActionResult Delete(int id)
        {
            RoldePago celular = DB.rol.Find(id);
            return View(celular);
        }
        [HttpPost]
        public IActionResult Delete(RoldePago empleado)
        {
            DB.rol.Remove(empleado);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
