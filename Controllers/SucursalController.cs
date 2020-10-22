using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            return View();
        }

        //------------------------- Sucursal-----------------
        public ActionResult Sucursal()
        {
            var _sucursal = SucuarsalBLL.ListSucursal();

            return View(_sucursal);
        }
    }
}