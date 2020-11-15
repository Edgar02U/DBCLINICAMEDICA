using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs(int tab)
        {
                ViewData["pestana"] = tab;
                return PartialView("~/Views/Home/Index.cshtml");

        }
        public ActionResult TabPanel(int pestana)
        {
            
                ViewData["pestana"] = pestana;
                return PartialView("~/Views/Home/Index.cshtml");
        }

    }
}