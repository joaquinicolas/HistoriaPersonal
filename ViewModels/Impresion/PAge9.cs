using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.ViewModels.Impresion
{
    public class Page9
    {
        public ActividadFisica actfis { get; set; }
        public ComentarioGeneral comentgen { get; set; }

        public Page9(ActividadFisica _actividad_fisica, ComentarioGeneral _comentariogral)
        {
            this.actfis = _actividad_fisica;
            this.comentgen = _comentariogral;
        }
    }
}