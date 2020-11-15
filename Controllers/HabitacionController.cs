using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class HabitacionController : Controller
    {
        public ActionResult Habitacion()
        {
            var _habitacion = HabitacionBLL.ListHabitacion();

            return View(_habitacion);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Habitacion/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(HABITACION habitacion)
        {
            HabitacionBLL.Agregar(habitacion);
            return View("~/Views/Habitacion/Habitacion.cshtml", habitacion);
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var habitacion = HabitacionBLL.GetHabitacion(id);
            return View("~/Views/Habitacion/Editar.cshtml", habitacion);
        }

        [HttpPost]
        public ActionResult Editar(HABITACION habitacion)
        {
            
            return View(habitacion);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            HabitacionBLL.Eliminar(id);
            return View("~/Views/Habitacion/Habitacion.cshtml");
        }

        public JsonResult Habitacion_()
        {
            var data = HabitacionBLL.ListHabitaciones();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}