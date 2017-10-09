using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Pedro",
                Edad = 20,
                Empleado = true,
                Nacimiento = new DateTime(2017, 10, 10)
            };

            ViewBag.Persona = persona;
            ViewBag.MiListado = ObtenerListado();
            return View();
        }
        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            ViewBag.Message = "exitoso";
            return View(persona);
        }
        public List<SelectListItem> ObtenerListado(){
            return new List<SelectListItem>()
            {
                   new SelectListItem()
        {
            Text = "Sí",
            Value = "1" 
        },
        new SelectListItem()
        {
            Text = "No",
            Value = "2"
        }
            };
        }
        public ActionResult About(int edad)
            {
            ViewBag.Message = "Tu edad es " +edad ;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de contacto.";

            return View();
        }
        public ActionResult Mapa()
        {
            return View();
        }
    }
     public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Empleado { get; set; }
        public DateTime Nacimiento { get; set; }

    }
}