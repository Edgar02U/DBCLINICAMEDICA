using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class PacienteController : Controller
    {
        public ActionResult Paciente()
        {
            var _pacientes = PacientesBLL.ListPaciente();
            return View(_pacientes);
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(PACIENTE paciente)
        //{
        //    try
        //    {
        //        PacientesBLL.Agregar(paciente);
        //        return RedirectToAction("Paciente");
        //    }
        //    catch (Exception ex)
        //    {

        //        ModelState.AddModelError("","Ocurrio un error al agregar un paciente");
        //        return View();
        //    }
        //}

        public ActionResult Editar(int id)
        {
            var paciente = PacientesBLL.GetPaciente(id);
            return View("~/Views/Paciente/Editar.cshtml", paciente);
        }

        [HttpPost]
        public ActionResult Editar(PACIENTE paciente)
        {           
            return View(paciente);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/Paciente/Paciente.cshtml");
        }

        public JsonResult Paciente_()
        {
            var data = PacientesBLL.ListPacientes();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}