using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using MVC.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AlumnoController : Controller
    {

        // GET: AsignaturaController
        public IActionResult Index()
        {
            var alumno = new Alumno();

            alumno.Nombre = "Maycold Marcelo Vasquez Artola";
            alumno.UniqueId = Guid.NewGuid().ToString();
            alumno.FechaInicio = DateTime.Now;
            ViewBag.Fecha = DateTime.Now;
            ViewBag.CosaDinamica = "El mejor Alumno";

            return View(alumno);
        }
        // GET: Lista de Alumnos
        public IActionResult MultiAlumno()
        {
            var listaAlumnos = GenerarAlumnosAlAzar();
            ViewBag.CosaDinamica = "El mejor Alumno";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", listaAlumnos);
        }
        


        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   UniqueId = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }


        // GET: EscuelaController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: EscuelaController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: EscuelaController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: EscuelaController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: EscuelaController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: EscuelaController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: EscuelaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
