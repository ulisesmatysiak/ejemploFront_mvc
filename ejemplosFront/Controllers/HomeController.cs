using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
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
            HttpContext.Session["Persona"] = personaViewModel;

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


        public ActionResult Detalle(int id)
        {
            var persona = HttpContext.Session["Persona"] as List<PersonaViewModel>;
            var seleccionado = persona.FirstOrDefault(x => x.Id == id);

            int edad = Utils.CalcularEdad(seleccionado.fechaNacimiento);
            ViewBag.Edad = edad;

            return View(seleccionado);
        }

        [HttpPost]
        public ActionResult Guardar(PersonaViewModel persona)
        {
            var personaViewModel = invocaejemplosAnses.modificarPersona(persona);
            return RedirectToAction("Index");
        }

        [HttpPost]

        public ActionResult Eliminar(int id)
        {
            var invocador = new invocaejemplosAnses();
            invocador.eliminarPersona(id);
            return RedirectToAction("Index");
        }

    }
}