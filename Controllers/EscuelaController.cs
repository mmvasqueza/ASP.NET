using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;

namespace MVC.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: EscuelaController
        public IActionResult Index()
        {
            //Instancia dle objeto escuela que proviene del modelo
            var escuela = new Escuela();

            //Asignando valores a las propiedades del modelo
                        escuela.UniqueId = Guid.NewGuid().ToString(); // Genera un Id aleatoreo
            escuela.AñoDeCreación = 2005;
            escuela.Nombre = "Platzi School";
            escuela.Ciudad = "Granada, NI";
            escuela.Pais = "Nicaragua";
            escuela.Dirección = "Av. 1263 Road Street";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            
            //Obtiene datos del controlador que podemos usar como banderas
            ViewBag.CosaDinamica = "La monja1";

            return View(escuela);//Retornamos como parametro el objeto escuela
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
