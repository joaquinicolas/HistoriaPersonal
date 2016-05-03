using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HistoriaPersonalCormillot.ViewModels;

namespace HistoriaPersonalCormillot.Controllers
{
    public class AdministradorController : Controller
    {   
         private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();

        public ActionResult Registro()
        {
            var regist = new Registro1ViewModel();
            return View(regist);
        }
       
        public ActionResult Home()
        {    ICollection<Usuario> listuser = model.Usuario.ToList<Usuario>();
             return View(listuser);
        }

        public ActionResult Edicion(Usuario us)
        {
            Usuario edi = us;
            return View(edi);
        }

        [HttpPost]
        public ActionResult Registrar(Registro1ViewModel regis)
        {
            Usuario user = new Usuario();
            user.Username = regis.Email;
            if (regis.Password != regis.Password2)
            { return View("Registro", regis); }
            user.Password = regis.Password;
            user.Formulario = false;
            user.IdRol = 2;
            model.Usuario.AddObject(user);
            model.SaveChanges();

            return RedirectToAction("Home", "Administrador");
           
        }
        [HttpPost]
        public ActionResult Editar(Usuario user)
        {
            var edit = model.Usuario.Where(e => e.Id == user.Id).First();
            edit.Username = user.Username;
            edit.Id = user.Id;
            edit.IdRol = user.IdRol;
            edit.Habilitado = user.Habilitado;
            edit.Password = user.Password;
            model.SaveChanges();
            return RedirectToAction("Home", "Administrador");
        }
   
        public ActionResult Eliminar(int userdel)
        {
            Usuario usuario = model.Usuario.Where(u => u.Id == userdel).First();
            int actividad = usuario.ActividadFisica.Count();
            int antecedentes = usuario.AntecedentesFamiliares.Count();
            int clasificacion1 = usuario.ClasificacionAlimentacion.Count();
            int clasificacion2 = usuario.ClasificacionAlimentacion2.Count();
            int clasificacion3 = usuario.ClasificacionAlimentacion3.Count();
            int clasificacion4 = usuario.ClasificacionAlimentacion4.Count();
            int clasificacion5 = usuario.ClasificacionAlimentacion5.Count();
            int clasificacion6 = usuario.ClasificacionAlimentacion6.Count();
            int comedia1 = usuario.ComeDiaTipicoYFinde.Count();
            int comedia2 = usuario.ComeDiaTipicoYFinde2.Count();
            int coment = usuario.ComentarioGeneral.Count();
            int datosper = usuario.DatosPersonales.Count();
            int habit = usuario.Habitos.Count();
            int preferenc = usuario.Preferencias.Count();
            int preferenc2 = usuario.Preferencias2.Count();
            int relacion = usuario.RelacionTratamientoMotivacion.Count();
            int relacion2 = usuario.RelacionTratamientoMotivacion2.Count();
            int relacion3 = usuario.RelacionTratamientoMotivacion3.Count();
            int sintoma = usuario.Sintomas.Count();
            int sintomas2 = usuario.Sintomas2.Count();
            int sintomas3 = usuario.Sintomas3.Count();
            int suestado = usuario.SuEstadoClinico.Count();
            int susallegados = usuario.SusAllegadosSuRelacionConLaComida.Count();
            int alimentacion = usuario.Alimentacion.Count();

            if (actividad != 0)
            {
                ActividadFisica activ = model.ActividadFisica.Where(dt => dt.IdUsuario == userdel).First();
                model.ActividadFisica.DeleteObject(activ);
            }
            if (antecedentes != 0)
            {
                AntecedentesFamiliares ante = model.AntecedentesFamiliares.Where(dt => dt.IdUsuario == userdel).First();
                model.AntecedentesFamiliares.DeleteObject(ante);
            }
            if (clasificacion1 != 0)
            {
                ClasificacionAlimentacion cl = model.ClasificacionAlimentacion.Where(dt => dt.IdUsuario == userdel).First();
                model.ClasificacionAlimentacion.DeleteObject(cl);
            }
            if (clasificacion2 != 0)
            {
                ClasificacionAlimentacion2 c2 = model.ClasificacionAlimentacion2.Where(dt => dt.IdUsuario == userdel).First();
                model.ClasificacionAlimentacion2.DeleteObject(c2);
            }
            if (clasificacion3 != 0)
            {
                ClasificacionAlimentacion3 c3 = model.ClasificacionAlimentacion3.Where(dt => dt.IdUsuario == userdel).First();
                model.ClasificacionAlimentacion3.DeleteObject(c3);
            }
            if (clasificacion4 != 0)
            {
                ClasificacionAlimentacion4 c4 = model.ClasificacionAlimentacion4.Where(dt => dt.IdUsuario == userdel).First();
                model.ClasificacionAlimentacion4.DeleteObject(c4);
            }
            if (clasificacion5 != 0)
            {
                ClasificacionAlimentacion5 c5 = model.ClasificacionAlimentacion5.Where(dt => dt.IdUsuario == userdel).First();
                model.ClasificacionAlimentacion5.DeleteObject(c5);
            }
            if (clasificacion6 != 0)
            {
                ClasificacionAlimentacion6 c6 = model.ClasificacionAlimentacion6.Where(dt => dt.IdUsuario == userdel).First();
                model.ClasificacionAlimentacion6.DeleteObject(c6);
            }
            if (comedia1 != 0)
            {
                ComeDiaTipicoYFinde com = model.ComeDiaTipicoYFinde.Where(dt => dt.IdUsuario == userdel).First();
                model.ComeDiaTipicoYFinde.DeleteObject(com);
            }
            if (comedia2 != 0)
            {
                ComeDiaTipicoYFinde2 com2 = model.ComeDiaTipicoYFinde2.Where(dt => dt.IdUsuario == userdel).First();
                model.ComeDiaTipicoYFinde2.DeleteObject(com2);
            }
            if (datosper != 0)
            {
                DatosPersonales date = model.DatosPersonales.Where(dt => dt.usuario_Id == userdel).First();
                model.DatosPersonales.DeleteObject(date);
            }
            if (coment != 0)
            {
                ComentarioGeneral comenta = model.ComentarioGeneral.Where(dt => dt.IdUsuario == userdel).First();
                model.ComentarioGeneral.DeleteObject(comenta);

            }
            if (habit != 0)
            {
                Habitos habi = model.Habitos.Where(dt => dt.IdUsuario == userdel).First();
                model.Habitos.DeleteObject(habi);

            }
            if (preferenc != 0)
            {
                Preferencias pr = model.Preferencias.Where(dt => dt.Idusuario == userdel).First();
                model.Preferencias.DeleteObject(pr);
            }
            if (preferenc2 != 0)
            {
                Preferencias2 pr = model.Preferencias2.Where(dt => dt.IdUsuario == userdel).First();
                model.Preferencias2.DeleteObject(pr);
            }
            if (relacion != 0)
            {
                RelacionTratamientoMotivacion rele1 = model.RelacionTratamientoMotivacion.Where(dt => dt.IdUsuario == userdel).First();
                model.RelacionTratamientoMotivacion.DeleteObject(rele1);

            }
            if (relacion2 != 0)
            {
                RelacionTratamientoMotivacion2 rele2 = model.RelacionTratamientoMotivacion2.Where(dt => dt.IdUsuario == userdel).First();
                model.RelacionTratamientoMotivacion2.DeleteObject(rele2);
            }
            if (relacion3 != 0)
            {
                RelacionTratamientoMotivacion3 rele3 = model.RelacionTratamientoMotivacion3.Where(dt => dt.IdUsuario == userdel).First();
                model.RelacionTratamientoMotivacion3.DeleteObject(rele3);
            }
            if (sintoma != 0)
            {
                Sintomas s1 = model.Sintomas.Where(dt => dt.IdUsuario == userdel).First();
                model.Sintomas.DeleteObject(s1);
            }
            if (sintomas2 != 0)
            {
                Sintomas2 s2 = model.Sintomas2.Where(dt => dt.IdUsuario == userdel).First();
                model.Sintomas2.DeleteObject(s2);
            }
            if (sintomas3 != 0)
            {
                Sintomas3 su = model.Sintomas3.Where(dt => dt.IdUsuario == userdel).First();
                model.Sintomas3.DeleteObject(su);
            }
            if (suestado != 0)
            {
                SuEstadoClinico est = model.SuEstadoClinico.Where(dt => dt.IdUsuario == userdel).First();
                model.SuEstadoClinico.DeleteObject(est);
            }
            if (susallegados != 0)
            {
                SusAllegadosSuRelacionConLaComida est = model.SusAllegadosSuRelacionConLaComida.Where(dt => dt.IdUsuario == userdel).First();
                model.SusAllegadosSuRelacionConLaComida.DeleteObject(est);
            }
            if (alimentacion != 0)
            {
                Alimentacion ali = model.Alimentacion.Where(dt => dt.IdUsuario == userdel).First();
                model.Alimentacion.DeleteObject(ali);
            }

            model.Usuario.DeleteObject(usuario);
            model.SaveChanges();
            return RedirectToAction("Home", "Administrador");
        }
    }
}
