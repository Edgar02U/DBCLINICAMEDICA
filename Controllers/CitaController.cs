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

        public JsonResult Citas_()
        {
            var data = CitasBLL.List_Citas();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}