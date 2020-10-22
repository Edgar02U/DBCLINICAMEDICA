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

        //------------------------- Examen Paciente-----------------
       
        public JsonResult ExamPaciente()
        {
            var data = Examen_PacienteBLL.ListExPatient();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}