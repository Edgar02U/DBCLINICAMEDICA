using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class CitaController : Controller
    {
        CitasBLL dbc = new CitasBLL();
        public ActionResult Cita()
        {
            var _cita = CitasBLL.ListCita();
            return View(_cita);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Cita/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(CITAS cita)
        {

            CitasBLL.Agregar(cita);
            return View("~/Views/Cita/Cita.cshtml", cita);
        }

        public ActionResult Editar(int id)
        {
            var cita = CitasBLL.GetCita(id);
            return View("~/Views/Cita/Editar.cshtml", cita);
        }

        [HttpPost]
        public ActionResult Editar(CITAS cita)
        {
            return View(cita);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/Cita/Cita.cshtml");
        }

        public JsonResult Citas_()
        {
            var data = CitasBLL.List_Citas();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}