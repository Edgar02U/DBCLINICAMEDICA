using Entidad;
using Negocio.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebClinicaMedica.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Usuario()
        {
            var _usuario = UsuarioBLL.ListUsuario();

            return View(_usuario);
        }
        public JsonResult Usuario_()
        {
            var data = UsuarioBLL.ListUsuarios();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Usuario/Create.cshtml");
        }
        [HttpPost]
        public ActionResult Create(USUARIO usuario)
        {
            UsuarioBLL.Agregar(usuario);
            return View("~/Views/Usuario/Usuario.cshtml", usuario);
        }

        public ActionResult Editar(int id)
        {
            var usuario = UsuarioBLL.GetUsuario(id);
            return View("~/Views/Usuario/Editar.cshtml", usuario);
        }

        [HttpPost]
        public ActionResult Editar(PACIENTE usuario)
        {
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            PacientesBLL.Eliminar(id);
            return View("~/Views/Usuario/Usuario.cshtml");
        }
    }
}