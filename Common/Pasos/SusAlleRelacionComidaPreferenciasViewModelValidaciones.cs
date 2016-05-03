using System;
using System.Linq;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;

public class SusAlleRelacionComidaPreferenciasViewModelValidaciones:PasosValidaciones
{
       private int idUsuario;

       public SusAlleRelacionComidaPreferenciasViewModelValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }

       public void save(SusAllegadosRelacComPreferenciasViewModel datos)
       {
           var datosGuardados = getDatos();
          // SusAllegadosRelacionConLaComida
           datosGuardados.relacioncom.RadioPorcentajeIngesta = datos.relacioncom.RadioPorcentajeIngesta;
           datosGuardados.relacioncom.AlergiaAComida = datos.relacioncom.AlergiaAComida;

           //Preferencias
           datosGuardados.preferencias.SuDieta = datos.preferencias.SuDieta;
           datosGuardados.preferencias.RadioAlimentoPreferido = datos.preferencias.RadioAlimentoPreferido;
           datosGuardados.preferencias.AlimentoPreferido = datos.preferencias.AlimentoPreferido;
           datosGuardados.preferencias.RadioTipoAlimentoPreferido = datos.preferencias.RadioTipoAlimentoPreferido;
           datosGuardados.preferencias.RadioDesordenado = datos.preferencias.RadioDesordenado;
           datosGuardados.preferencias.RadioSalteo = datos.preferencias.RadioSalteo;
           datosGuardados.preferencias.RadioPicoteo = datos.preferencias.RadioPicoteo;
           datosGuardados.preferencias.RadioHagoAyunos = datos.preferencias.RadioHagoAyunos;
           datosGuardados.preferencias.RadioDepresion = datos.preferencias.RadioDepresion;
           datosGuardados.preferencias.RadioAnsiedad = datos.preferencias.RadioAnsiedad;
           datosGuardados.preferencias.RadioEstres = datos.preferencias.RadioEstres;
           datosGuardados.preferencias.RadioEnojo = datos.preferencias.RadioEnojo;
           datosGuardados.preferencias.RadioAburrimiento = datos.preferencias.RadioAburrimiento;
           datosGuardados.preferencias.RadioAlegria = datos.preferencias.RadioAlegria;
           datosGuardados.preferencias.RadioDescontrol = datos.preferencias.RadioDescontrol;
           datosGuardados.preferencias.RadioCansancio = datos.preferencias.RadioCansancio;
           datosGuardados.preferencias.RadioPreSentimental = datos.preferencias.RadioPreSentimental;
           datosGuardados.preferencias.RadioEmbarazo = datos.preferencias.RadioEmbarazo;

           model.SaveChanges();
       }





       public SusAllegadosRelacComPreferenciasViewModel getDatos()
       {
           crearDatosSiNoExiste();
           var relacionComidaPreferencias = new SusAllegadosRelacComPreferenciasViewModel();
           relacionComidaPreferencias.relacioncom = model.SusAllegadosSuRelacionConLaComida.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                       .First();
           relacionComidaPreferencias.preferencias = model.Preferencias.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                       .First();

           return relacionComidaPreferencias;

       }
       private void crearDatosSiNoExiste()
       {
           var hayDatosR =
                   model.SusAllegadosSuRelacionConLaComida.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
           var hayDatosP =
                   model.Preferencias.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

           if (!hayDatosR)
           {
               var antecedentesR = new SusAllegadosSuRelacionConLaComida()
               {
                   Usuario = getUsuario(idUsuario)
               };
               model.SusAllegadosSuRelacionConLaComida.AddObject(antecedentesR);
           }
           if (!hayDatosP)
           {
               var antecedentesP = new Preferencias()
               {
                   Usuario = getUsuario(idUsuario)
               };


               model.Preferencias.AddObject(antecedentesP);
           }
           model.SaveChanges();

       }
}
