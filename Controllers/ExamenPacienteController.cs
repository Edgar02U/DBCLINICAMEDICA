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
    public class ExamenPacienteController : Controller
    {
        // GET: ExamenPaciente
        public ActionResult Examen_Paciente()
        {
            return View();
        }


        public JsonResult ExamPaciente()
        {
            var data = Examen_PacienteBLL.ListExPatient();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/ExamenPaciente/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(EXAMEN_PACIENTE examenPaciente)
        {

            Examen_PacienteBLL.Agregar(examenPaciente);
            return View("~/Views/ExamenPaciente/Examen_Paciente.cshtml", examenPaciente);
        }

        public ActionResult Editar(int id)
        {
            var examenPaciente = Examen_PacienteBLL.GetExamenPaciente(id);
            return View("~/Views/ExamenPaciente/Editar.cshtml", examenPaciente);
        }

        [HttpPost]
        public ActionResult Editar(EXAMEN_PACIENTE ExamenPaciente)
        {
            return View(ExamenPaciente);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/ExamenPaciente/Examen_Paciente.cshtml");
        }
    }
}