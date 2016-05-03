using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;

namespace HistoriaPersonalCormillot.ViewModels
{
    public class SusAllegadosRelacComPreferenciasViewModel
    {
        public SusAllegadosSuRelacionConLaComida relacioncom { get; set; }
        public Preferencias preferencias { get; set; }

        public SusAllegadosRelacComPreferenciasViewModel()
        {

        }

        public SusAllegadosRelacComPreferenciasViewModel(SusAllegadosSuRelacionConLaComida _relacionComida,Preferencias _preferencias)
        {
            this.relacioncom = _relacionComida;
            this.preferencias = _preferencias;
        }

    }
}