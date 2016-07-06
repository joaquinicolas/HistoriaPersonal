using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HistoriaPersonalCormillot.ViewModels;

namespace HistoriaPersonalCormillot.Controllers
{
    public class UsuariosController : Controller
    {
        private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();

        public ActionResult Login()
        {
            return RedirectToAction("RealLogin");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View("Login");
        }

        [HttpPost]
        public ActionResult ValidarCredenciales(LoginViewModel login)
        {
         
            var query = from u in model.Usuario
                        where u.Username == login.NombreUsuario && u.Password == login.Password
                        select u;
            if (!query.Any())
            {
                login.ErrorValidacion = "El usuario y/o la contraseña son inválidos";
                return View("Login", login);
            }

            var usuario = query.First();
            Session["IdUsuario"] = usuario.Id;
            Session["NombreUsuario"] = usuario.Username;
            if (usuario.Habilitado == false)
            {
                return View("Login", login);
            }
            if(usuario.IdRol == 1)
            {
                return RedirectToAction("Home", "Administrador");
            }
            return RedirectToAction("DatosPersonales", "Pasos");
        }

        public ActionResult RealLogin()
        {
            int _id = 2;//Convert.ToInt16(Request.QueryString["id"]);
            Usuario user = new Usuario();
            if (_id == 0)
            {
                Guid idx = Guid.Parse(Request.QueryString["idx"]);
                user = model.Usuario.FirstOrDefault(u => u.idx == idx);
            }
            else
                user = model.Usuario.First(u => u.Id == _id);

            Session["NombreUsuario"] = user.Username;
            Session["IdUsuario"] = user.Id;
            if (user.IdRol == 1)
                return RedirectToAction("Home", "Administrador");
            else
                return RedirectToAction("DatosPersonales", "Pasos");
        }

        /// <summary>
        /// IR A LA PAGINA PARA BUSCAR E IMPRIMIR EL FORMULARIO DE UN USUARIO
        /// </summary>
        /// <returns></returns>
        public ActionResult FormPrint()
        {
            return View("PrintForm", null);
        }

        public ActionResult TraerFormulario(int idUsuar)
        {
            Usuario user = model.Usuario.Where(u => u.Id == idUsuar).First();

            Session["NombreUsuario"] = user.Username;
            Session["IdUsuario"] = user.Id;
            
            return RedirectToAction("DatosPersonales", "Pasos");
        }
       
    }
}
