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
        // GET: Examen
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Examen()
        {
            var _examen = ExamenBLL.ListExamen();

            return View(_examen);
        }
    }
}