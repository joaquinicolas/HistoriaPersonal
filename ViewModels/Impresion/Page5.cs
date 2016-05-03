using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.ViewModels.Impresion
{
    public class Page5
    {
        public SusAllegadosSuRelacionConLaComida sus_allegados { get; set; }
        public SusAllegadosRelacComPreferenciasViewModel preferencias { get; set; }
        
        public SusHabitos2 sushabitos2 { get; set; }

        public Page5(SusAllegadosSuRelacionConLaComida _allegados_comida, SusAllegadosRelacComPreferenciasViewModel _preferencias, SusHabitos2 _sushabitos2)
        {
            if(_allegados_comida != null && _preferencias != null && _sushabitos2 !=null) 
            {
                this.sus_allegados = _allegados_comida;
                this.preferencias = _preferencias;
                this.sushabitos2 = _sushabitos2;
               
            }
        }
    }
}