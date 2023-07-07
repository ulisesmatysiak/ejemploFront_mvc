using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejemplosFront.App_Code;
using ejemplosFront.ejemploWS;
using ejemplosFront.Models;

namespace ejemplosFront.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string nombre = null)
        {
            //var personaViewModel = invocaejemplosAnses.obtenerPersona(cuil);

            if (string.IsNullOrEmpty(nombre))
            {
                nombre = null;
            }
            var personaViewModel = invocaejemplosAnses.BuscarPorNombre(nombre);

            return View(personaViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuardarAlta(PersonaViewModel nuevo)
        {
            var personaViewModel = invocaejemplosAnses.personaAlta(nuevo);
            return RedirectToAction("Index");
        }


        public ActionResult Detalle(PersonaViewModel seleccionado)
        {
            return View(seleccionado);
        }
    }
}