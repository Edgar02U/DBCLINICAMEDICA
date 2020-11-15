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

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Inventario/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(INVENTARIO inventario)
        {
            InventarioBLL.Agregar(inventario);
            return View("~/Views/Inventario/Inventario.cshtml", inventario);
        }

        public ActionResult Editar(int id)
        {
            var inventario = InventarioBLL.GetInventario(id);
            return View("~/Views/Inventario/Editar.cshtml", inventario);
        }

        [HttpPost]
        public ActionResult Editar(INVENTARIO inventario)
        {
            return View(inventario);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/Inventario/Inventario.cshtml");
        }
    }
}