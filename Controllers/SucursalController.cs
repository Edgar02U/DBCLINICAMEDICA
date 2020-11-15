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
        public ActionResult Sucursal()
        {
            var _sucursal = SucuarsalBLL.ListSucursal();

            return View(_sucursal);
        }

        public JsonResult Sucursal_()
        {
            var data = SucuarsalBLL.ListSucursales();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Sucursal/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(SUCURSAL sucursal)
        {
            SucuarsalBLL.Agregar(sucursal);
            return View("~/Views/Sucursal/Sucursal.cshtml", sucursal);
        }

        public ActionResult Editar(int id)
        {
            var sucursal = SucuarsalBLL.GetSucursal(id);
            return View("~/Views/Sucursal/Editar.cshtml", sucursal);
        }

        [HttpPost]
        public ActionResult Editar(SUCURSAL sucursal)
        {
            return View(sucursal);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            SucuarsalBLL.Eliminar(id);
            return View("~/Views/Sucursal/Sucursal.cshtml");
        }
    }
}