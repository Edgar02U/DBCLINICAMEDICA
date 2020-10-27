using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class InventarioController : Controller
    {       
        public ActionResult Inventario()
        {
            var _inventario = InventarioBLL.ListInventario();
            
            return View(_inventario);
        }

        public JsonResult Inventario_()
        {
            var data = InventarioBLL.ListInvetarios();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}