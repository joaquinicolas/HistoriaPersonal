using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HistoriaPersonalCormillot.ViewModels;
using HistoriaPersonalCormillot.ViewModels.Impresion;

namespace HistoriaPersonalCormillot.Controllers
{
    public class ImpresionController:Controller
    {
        private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();
        private int _idUsuario;
        private int idUsuario
        {
            get
            {
                if (_idUsuario == 0 && Session["IdUsuario"] != null)
                {
                    _idUsuario = (int)Session["IdUsuario"];
                }
                return _idUsuario;
            }
            set
            {
                _idUsuario = value;
            }
        }

        public ActionResult Page1()
        {
            Page1 pag1 = new Page1();
            pag1.datper = model.DatosPersonales.Where(d => d.usuario_Id == idUsuario).First();
            pag1.relac = model.RelacionTratamientoMotivacion.Where(r => r.IdUsuario == idUsuario).First();

            return View(pag1);
        }

        public ActionResult Page2()
        {
            Page2 pag2 = new Page2();
            pag2.relac2 = model.RelacionTratamientoMotivacion2.Where(d => d.IdUsuario == idUsuario).First();
            pag2.relac3 = model.RelacionTratamientoMotivacion3.Where(d => d.IdUsuario == idUsuario).First();
            return View(pag2);
        }
        
        public ActionResult Page3()
        {
            Page3 pag3 = new Page3();
            pag3.antec = model.AntecedentesFamiliares.Where(a => a.IdUsuario == idUsuario).First();
            pag3.suestado = model.SuEstadoClinico.Where(Su => Su.IdUsuario == idUsuario).First();
            return View(pag3);
        }

      public ActionResult Page4()
        {
            Page4 pag4 = new Page4();
            pag4.sintoma1 = model.Sintomas.Where(d => d.IdUsuario == idUsuario).First();
            pag4.sintoma2 = model.Sintomas2.Where(d => d.IdUsuario == idUsuario).First();
            pag4.sintoma3 = model.Sintomas3.Where(d => d.IdUsuario == idUsuario).First();
            pag4.habitos = model.Habitos.Where(d => d.IdUsuario == idUsuario).First();
            return View(pag4);
        }

        public ActionResult Page5()
      {
          Preferencias preferencias = model.Preferencias.FirstOrDefault(u => u.Idusuario == idUsuario);
          SusAllegadosSuRelacionConLaComida allegados_comida = model.SusAllegadosSuRelacionConLaComida
              .FirstOrDefault(x => x.IdUsuario == idUsuario);
            SusHabitos2 _sushabitos2 = model.SusHabitos2
         .FirstOrDefault(x => x.IdUsuario == idUsuario);

            SusAllegadosRelacComPreferenciasViewModel allegados_preferencias = new SusAllegadosRelacComPreferenciasViewModel(
                  allegados_comida,preferencias
               );

       
            Page5 view_model = new Page5(allegados_comida, allegados_preferencias, _sushabitos2);
            return View(view_model);
            
      }

        public ActionResult Page6()
        {
            Preferencias2 preferencias2 = model.Preferencias2.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            Alimentacion alimentacion = model.Alimentacion.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            Preferencias2AlimentacionViewModel preferencias_alimentacionViewModel = new Preferencias2AlimentacionViewModel(
                    preferencias2,alimentacion
                );
            Page6 viewModel = new Page6( preferencias2,preferencias_alimentacionViewModel);
            return View(viewModel);
        }

        public ActionResult Page7()
        {
            ComeDiaTipicoYFinde cuando_come = model.ComeDiaTipicoYFinde.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ComeDiaTipicoYFinde2 cuando_come2 = model.ComeDiaTipicoYFinde2.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );
            Page7 page7 = new Page7(
                    cuando_come,cuando_come2
                );
            return View(page7);
        }

        public ActionResult Page8()
        {
            ClasificacionAlimentacion clasificacion_alimentacion =
                model.ClasificacionAlimentacion.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );
            ClasificacionAlimentacion2 clasificacion_alimentacion2 =
                model.ClasificacionAlimentacion2.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion3 clasificacion_alimentacion3 =
                model.ClasificacionAlimentacion3.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion4 clasificacion_alimentacion4 =
                model.ClasificacionAlimentacion4.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion5 clasificacion_alimentacion5 =
                model.ClasificacionAlimentacion5.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion6 clasificacion_alimentacion6 =
                model.ClasificacionAlimentacion6.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion1_2_3ViewModel clasificacion123_viewmodel =
                new ClasificacionAlimentacion1_2_3ViewModel(
                        clasificacion_alimentacion,clasificacion_alimentacion2,clasificacion_alimentacion3
                    );

            ClasificacionAlimentacion3_4_5_6ViewModel clasificacion_alimentacion_Viewmodel =
                new ClasificacionAlimentacion3_4_5_6ViewModel(
                        clasificacion_alimentacion3,clasificacion_alimentacion4,
                        clasificacion_alimentacion5,clasificacion_alimentacion6
                    );

            Page8 viewmodel = new Page8(
                    clasificacion123_viewmodel,clasificacion_alimentacion_Viewmodel
                );
            return View(viewmodel);
        }

        public ActionResult Page9()
        {
            ActividadFisica actividad_fisica = model.ActividadFisica
                .FirstOrDefault(x => x.IdUsuario == idUsuario);

            ComentarioGeneral comentario_gral = model.ComentarioGeneral
                .FirstOrDefault( x => x.IdUsuario == idUsuario );
            Page9 viewmodel = new Page9(actividad_fisica,comentario_gral);
            return View(viewmodel);
        }
       
        public ActionResult Imprimir()
        {
            return View();
        }
        public ActionResult ComoImprimir()
        {
            return View();
        }
       public ActionResult PagePrueba()
        {
            return View();
        }
    }
}