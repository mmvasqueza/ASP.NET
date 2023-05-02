using Microsoft.AspNetCore.Http;
using System;
using MVC.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AsignaturaController : Controller
    {

        // GET: AsignaturaController
        public IActionResult Index()
        {
            var asignatura = new Asignatura();

            asignatura.Nombre = "La Programación";
            asignatura.UniqueId = Guid.NewGuid().ToString();

            ViewBag.Fecha = DateTime.Now;
            ViewBag.CosaDinamica = "La monja2";

            return View(asignatura);
        }


        // GET: AsignaturaController
        public IActionResult MultiAsignatura()
        {
            ViewBag.Fecha = DateTime.Now;
            ViewBag.CosaDinamica = "La monja2";

            var listaAsignaturas = new List<Asignatura>()
            {
                new Asignatura
                {
                    Nombre = "La Programación",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Matemáticas",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura
                {
                    Nombre = "Castellano",
                    UniqueId = Guid.NewGuid().ToString()
                },
                 new Asignatura
                {
                    Nombre = "Ciencias Naturales",
                    UniqueId = Guid.NewGuid().ToString()
                }
            };

            return View("MultiAsignatura", listaAsignaturas);
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
