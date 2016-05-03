using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;

namespace HistoriaPersonalCormillot.ViewModels
{
    public class ClasificacionAlimentacion1_2_3ViewModel
    {
        public ClasificacionAlimentacion alimen1 { get; set;}
        public ClasificacionAlimentacion2 alimen2 { get; set; }
        public ClasificacionAlimentacion3 alimen3 { get; set; }


        public ClasificacionAlimentacion1_2_3ViewModel() { }

        public ClasificacionAlimentacion1_2_3ViewModel(ClasificacionAlimentacion _alimentacion1,ClasificacionAlimentacion2 _alimentacion2,ClasificacionAlimentacion3 _alimentacion3)
        {
            this.alimen1 = _alimentacion1;
            this.alimen2 = _alimentacion2;
            this.alimen3 = _alimentacion3;
        }
    }
}