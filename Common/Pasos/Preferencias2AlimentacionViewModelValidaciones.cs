using System.Linq;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;


    public class Preferencias2AlimentacionViewModelValidaciones:PasosValidaciones
    {
           private int idUsuario;

           public Preferencias2AlimentacionViewModelValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }

           public void save(Preferencias2AlimentacionViewModel datosNuevos)
           {  
               var datosGuardados = getDatos();
               //Preferencias
               datosGuardados.preferencias.LugarCasa = datosNuevos.preferencias.LugarCasa;
               datosGuardados.preferencias.LugarTraslados = datosNuevos.preferencias.LugarTraslados;
               datosGuardados.preferencias.LugarCalle = datosNuevos.preferencias.LugarCalle;
               datosGuardados.preferencias.LugarColegio = datosNuevos.preferencias.LugarColegio;
               datosGuardados.preferencias.LugarRestaurante = datosNuevos.preferencias.LugarRestaurante;
               datosGuardados.preferencias.LugarViaje = datosNuevos.preferencias.LugarViaje;
               datosGuardados.preferencias.LugarVacaciones = datosNuevos.preferencias.LugarVacaciones;
               datosGuardados.preferencias.LugarEstudioB = datosNuevos.preferencias.LugarEstudioB;
               datosGuardados.preferencias.LugarBarB = datosNuevos.preferencias.LugarBarB;
               datosGuardados.preferencias.LugarTrabajo = datosNuevos.preferencias.LugarTrabajo;
               datosGuardados.preferencias.LugarKiosko = datosNuevos.preferencias.LugarKiosko;
               datosGuardados.preferencias.LugarClub = datosNuevos.preferencias.LugarClub;

               //Alimentacion
               datosGuardados.alimentacion.DecideComida = datosNuevos.alimentacion.DecideComida;
               datosGuardados.alimentacion.CompraComida = datosNuevos.alimentacion.CompraComida;
               datosGuardados.alimentacion.CocinaComida = datosNuevos.alimentacion.CocinaComida;
               datosGuardados.alimentacion.GustaCocinar = datosNuevos.alimentacion.GustaCocinar;

               datosGuardados.alimentacion.ComidaEnCasa = datosNuevos.alimentacion.ComidaEnCasa;
               datosGuardados.alimentacion.ComidaEnTrabajo = datosNuevos.alimentacion.ComidaEnTrabajo;
               datosGuardados.alimentacion.ComidaEnEstudio = datosNuevos.alimentacion.ComidaEnEstudio;
               datosGuardados.alimentacion.ComidaEnFinde = datosNuevos.alimentacion.ComidaEnFinde;

               datosGuardados.alimentacion.AlimentosEngordan = datosNuevos.alimentacion.AlimentosEngordan;
               datosGuardados.alimentacion.ComeDeMas = datosNuevos.alimentacion.ComeDeMas;

               datosGuardados.alimentacion.TrabajoPuedeComprarSiNo = datosNuevos.alimentacion.TrabajoPuedeComprarSiNo;
               datosGuardados.alimentacion.TrabajoPuedeComprarQue = datosNuevos.alimentacion.TrabajoPuedeComprarQue;
               datosGuardados.alimentacion.TrabajoPuedeLlevarSiNo = datosNuevos.alimentacion.TrabajoPuedeLlevarSiNo;
               datosGuardados.alimentacion.TrabajoPuedeLlevarQue = datosNuevos.alimentacion.TrabajoPuedeLlevarQue;
               datosGuardados.alimentacion.TrabajoPuedePrepararSiNo = datosNuevos.alimentacion.TrabajoPuedePrepararSiNo;
               datosGuardados.alimentacion.TrabajoPuedePrepararQue = datosNuevos.alimentacion.TrabajoPuedePrepararQue;



               model.SaveChanges();
           }





           public Preferencias2AlimentacionViewModel getDatos()
           {
               crearDatosSiNoExiste();
               var alimentosPreferencias = new Preferencias2AlimentacionViewModel();
               alimentosPreferencias.preferencias = model.Preferencias2.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                           .First();
               alimentosPreferencias.alimentacion = model.Alimentacion.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                           .First();

               return alimentosPreferencias;

           }

           private void crearDatosSiNoExiste()
           {
               var hayDatosP2 =
                       model.Preferencias2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
               var hayDatosA =
                       model.Alimentacion.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

               if (!hayDatosP2)
               {
                   var antecedentes = new Preferencias2()
                   {
                       Usuario = getUsuario(idUsuario)
                   };
                   model.Preferencias2.AddObject(antecedentes);
               }
               if (!hayDatosA)
               {
                   var antecedentesH = new Alimentacion()
                   {
                       Usuario = getUsuario(idUsuario)
                   };


                   model.Alimentacion.AddObject(antecedentesH);
               }
               model.SaveChanges();

           }
         
    }
