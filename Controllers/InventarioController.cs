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
        INVENTARIO dbinv = new INVENTARIO();
        
        public ActionResult Inventario()
        {
            var _inventario = InventarioBLL.ListInventario();
            
            return View(_inventario);
        }

        
    }
}