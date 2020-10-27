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
    }
}