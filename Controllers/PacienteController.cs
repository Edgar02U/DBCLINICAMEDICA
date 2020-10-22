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
        // GET: Paciente
        public ActionResult Index()
        {
            return View();
        }
        //------------------------- Paciente-----------------
        public ActionResult Pacientes()
        {
            var _pacientes = PacientesBLL.ListPacientes();
            return View(_pacientes);
        }
    }
}