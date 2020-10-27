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
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Usuario()
        {
            var _usuario = UsuarioBLL.ListUsuario();

            return View(_usuario);
        }
    }
}