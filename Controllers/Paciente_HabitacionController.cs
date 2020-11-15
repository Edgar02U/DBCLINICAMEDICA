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
        public ActionResult Paciente_Habitacion()
        {
            var _pacihabi = Paciente_HabitacionBLL.ListPaciHabi();

            return View(_pacihabi);
        }

        public JsonResult PaciHabi_()
        {
            var data = Paciente_HabitacionBLL.ListPaciHabis();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Paciente_Habitacion/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(PACIENTE_HABITACION pacienteHabitacion)
        {
            Paciente_HabitacionBLL.Agregar(pacienteHabitacion);
            return View("~/Views/Paciente_Habitacion/Paciente_Habitacion.cshtml", pacienteHabitacion);
        }

        public ActionResult Editar(int id)
        {
            var pacienteHabitacion = Paciente_HabitacionBLL.GetPaciHabit(id);
            return View("~/Views/Paciente/Editar.cshtml", pacienteHabitacion);
        }

        [HttpPost]
        public ActionResult Editar(PACIENTE_HABITACION pacienteHabitacion)
        {
            return View(pacienteHabitacion);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            Paciente_HabitacionBLL.Eliminar(id);
            return View("~/Views/Paciente_Habitacion/Paciente_Habitacion.cshtml");
        }
    }
}