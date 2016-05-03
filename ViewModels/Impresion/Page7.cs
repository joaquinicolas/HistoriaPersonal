using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.ViewModels.Impresion
{
    public class Page7
    {
        public ComeDiaTipicoYFinde comedia { get; set; }
        public ComeDiaTipicoYFinde2 comedia2 { get; set; }


        public Page7(ComeDiaTipicoYFinde _comedia, ComeDiaTipicoYFinde2 _comedia2)
        {
            this.comedia = _comedia;
            this.comedia2 = _comedia2;
        }
    }
}