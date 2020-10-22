using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class Paciente_HabitacionController : Controller
    {
        // GET: Paciente_Habitacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Paciente_Habitacion()
        {
            var _pacihabi = Paciente_HabitacionBLL.ListPaciHabi();

            return View(_pacihabi);
        }
    }
}