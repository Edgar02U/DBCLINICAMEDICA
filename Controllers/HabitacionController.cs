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
        // GET: Habitacion
        public ActionResult Index()
        {
            return View();
        }
        //------------------------- Habitacion-----------------
        public ActionResult Habitacion()
        {
            var _habitacion = HabitacionBLL.ListHabitacion();

            return View(_habitacion);
        }
    }
}