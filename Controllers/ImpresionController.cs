﻿using System;
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
            pag1.datper = model?.DatosPersonales.First(d => d.usuario_Id == idUsuario);
            pag1.relac = model?.RelacionTratamientoMotivacion.First(r => r.IdUsuario == idUsuario);

            return View(pag1);
        }

        public ActionResult Page2()
        {
            Page2 pag2 = new Page2();
            if (model != null)
            {
                pag2.relac2 = model.RelacionTratamientoMotivacion2.First(d => d.IdUsuario == idUsuario);
                if (model.RelacionTratamientoMotivacion3 != null)
                    pag2.relac3 = model.RelacionTratamientoMotivacion3.First(d => d.IdUsuario == idUsuario);
            }
            return View(pag2);
        }
        
        public ActionResult Page3()
        {
            Page3 pag3 = new Page3
            {
                antec = model?.AntecedentesFamiliares.First(a => a.IdUsuario == idUsuario),
                suestado = model?.SuEstadoClinico.First(su => su.IdUsuario == idUsuario)
            };
            return View(pag3);
        }

      public ActionResult Page4()
        {
          Page4 pag4 = new Page4
          {
              sintoma1 = model.Sintomas.First(d => d.IdUsuario == idUsuario),
              sintoma2 = model.Sintomas2.First(d => d.IdUsuario == idUsuario),
              sintoma3 = model.Sintomas3.First(d => d.IdUsuario == idUsuario),
              habitos = model.Habitos.First(d => d.IdUsuario == idUsuario)
          };
          return View(pag4);
        }

        public ActionResult Page5()
      {
          Preferencias preferencias = model.Preferencias.FirstOrDefault(u => u.Idusuario == idUsuario);
          SusAllegadosSuRelacionConLaComida allegadosComida = model.SusAllegadosSuRelacionConLaComida
              .FirstOrDefault(x => x.IdUsuario == idUsuario);
            SusHabitos2 sushabitos2 = model.SusHabitos2
         .FirstOrDefault(x => x.IdUsuario == idUsuario);

            SusAllegadosRelacComPreferenciasViewModel allegadosPreferencias = new SusAllegadosRelacComPreferenciasViewModel(
                  allegadosComida,preferencias
               );

       
            Page5 viewModel = new Page5(allegadosComida, allegadosPreferencias, sushabitos2);
            return View(viewModel);
            
      }

        public ActionResult Page6()
        {
            Preferencias2 preferencias2 = model.Preferencias2.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            Alimentacion alimentacion = model.Alimentacion.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            Preferencias2AlimentacionViewModel preferenciasAlimentacionViewModel = new Preferencias2AlimentacionViewModel(
                    preferencias2,alimentacion
                );
            Page6 viewModel = new Page6( preferencias2,preferenciasAlimentacionViewModel);
            return View(viewModel);
        }

        public ActionResult Page7()
        {
            ComeDiaTipicoYFinde cuandoCome = model.ComeDiaTipicoYFinde.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ComeDiaTipicoYFinde2 cuandoCome2 = model.ComeDiaTipicoYFinde2.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );
            Page7 page7 = new Page7(
                    cuandoCome,cuandoCome2
                );
            return View(page7);
        }

        public ActionResult Page8()
        {
            ClasificacionAlimentacion clasificacionAlimentacion =
                model.ClasificacionAlimentacion.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );
            if (clasificacionAlimentacion == null) throw new ArgumentNullException(nameof(clasificacionAlimentacion));
            ClasificacionAlimentacion2 clasificacionAlimentacion2 =
                model.ClasificacionAlimentacion2.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );
            if (clasificacionAlimentacion2 == null)
                throw new ArgumentNullException(nameof(clasificacionAlimentacion2));

            ClasificacionAlimentacion3 clasificacionAlimentacion3 =
                model.ClasificacionAlimentacion3.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion4 clasificacionAlimentacion4 =
                model.ClasificacionAlimentacion4.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion5 clasificacionAlimentacion5 =
                model.ClasificacionAlimentacion5.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion6 clasificacionAlimentacion6 =
                model.ClasificacionAlimentacion6.FirstOrDefault(
                    x => x.IdUsuario == idUsuario
                );

            ClasificacionAlimentacion1_2_3ViewModel clasificacion123Viewmodel =
                new ClasificacionAlimentacion1_2_3ViewModel(
                        clasificacionAlimentacion,clasificacionAlimentacion2,clasificacionAlimentacion3
                    );

            ClasificacionAlimentacion3_4_5_6ViewModel clasificacionAlimentacionViewmodel =
                new ClasificacionAlimentacion3_4_5_6ViewModel(
                        clasificacionAlimentacion3,clasificacionAlimentacion4,
                        clasificacionAlimentacion5,clasificacionAlimentacion6
                    );

            Page8 viewmodel = new Page8(
                    clasificacion123Viewmodel,clasificacionAlimentacionViewmodel
                );
            return View(viewmodel);
        }

        public ActionResult Page9()
        {
            ActividadFisica actividadFisica = model.ActividadFisica
                .FirstOrDefault(x => x.IdUsuario == idUsuario);

            ComentarioGeneral comentarioGral = model.ComentarioGeneral
                .FirstOrDefault( x => x.IdUsuario == idUsuario );
            Page9 viewmodel = new Page9(actividadFisica,comentarioGral);
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