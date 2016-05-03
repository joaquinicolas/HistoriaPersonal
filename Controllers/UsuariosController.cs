﻿using System;
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
            if (query.Count() == 0)
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
            int _id = 0;
             _id = Convert.ToInt16(Request.QueryString["id"]);
            Usuario user = new Usuario();
            if (_id == 0)
            {
                Guid _idx = Guid.Parse(Request.QueryString["idx"]);
                user = model.Usuario.Where(u => u.idx == _idx).FirstOrDefault();
            }
            else
                user = model.Usuario.Where(u => u.Id == _id).First();

            Session["NombreUsuario"] = user.Username;
            Session["IdUsuario"] = user.Id;
            if (user.IdRol == 1)
                return RedirectToAction("Home", "Administrador");
            else
                return RedirectToAction("DatosPersonales", "Pasos");
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
