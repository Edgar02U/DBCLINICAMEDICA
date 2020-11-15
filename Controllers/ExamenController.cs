using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class ExamenController : Controller
    {
        public ActionResult Examen()
        {
            var _examen = ExamenBLL.ListExamen();
            return View(_examen);
        }

        public JsonResult Examen_()
        {
            var data = ExamenBLL.ListExamenes();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Examen/Create.cshtml");
        }

        [HttpPost]
        public ActionResult Create(EXAMEN examen)
        {

            ExamenBLL.Agregar(examen);
            return View("~/Views/Examen/Examen.cshtml", examen);
        }

        public ActionResult Editar(int id)
        {
            var examen = ExamenBLL.GetExamen(id);
            return View("~/Views/Examen/Editar.cshtml", examen);
        }

        [HttpPost]
        public ActionResult Editar(EXAMEN examen)
        {
            return View(examen);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/Examen/Examen.cshtml");
        }
    }
}