using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.ViewModels.Impresion
{
    public class Page6
    {
        public Preferencias2 pref2 { get; set; }
        public Preferencias2AlimentacionViewModel prefalim { get; set; }
   
        public Page6(Preferencias2 _preferencias2, Preferencias2AlimentacionViewModel _preferencias_alimentacionViewModel)
        {
            this.pref2 = _preferencias2;
            this.prefalim = _preferencias_alimentacionViewModel;
        }
    }
}