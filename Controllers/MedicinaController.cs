using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class MedicinaController : Controller
    {
        // GET: Medicina
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Medicina()
        {
            var _mecicina = MedicinaBLL.ListMedicina();

            return View(_mecicina);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Editar(int id)
        {
            var medicina = MedicinaBLL.GetMedicina(id);
            return View("~/Views/Medicina/Editar.cshtml", medicina);
        }

        [HttpPost]
        public ActionResult Editar(MEDICINA medicina)
        {
            return View(medicina);
        }


        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/Medicina/Medicina.cshtml");
        }
    }
}