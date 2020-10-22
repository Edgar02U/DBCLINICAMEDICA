using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        //get create
        public ActionResult Create()
        {
            return View();
        }

        //post create
        //[HttpPost]
        //public ActionResult Create([Bind(Exclude ="ID_CITA")])
        //{
            
        //    return RedirectToAction("Cita");
        //}
    }
}