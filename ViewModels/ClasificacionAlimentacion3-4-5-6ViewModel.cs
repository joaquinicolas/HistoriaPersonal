using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.ViewModels
{
    public class ClasificacionAlimentacion3_4_5_6ViewModel
    {
        public ClasificacionAlimentacion3 aliment3 { get; set; }
        public ClasificacionAlimentacion4 aliment4 { get; set; }
        public ClasificacionAlimentacion5 aliment5 { get; set; }
        public ClasificacionAlimentacion6 aliment6 { get; set; }

        public ClasificacionAlimentacion3_4_5_6ViewModel() { }

        public ClasificacionAlimentacion3_4_5_6ViewModel(ClasificacionAlimentacion3 _alimentacion3,ClasificacionAlimentacion4 _alimentacion4,
                   ClasificacionAlimentacion5 _alimentacion5, ClasificacionAlimentacion6 _alimentacion6 
            )
        {
            this.aliment3 = _alimentacion3;
            this.aliment4 = _alimentacion4;
            this.aliment5 = _alimentacion5;
            this.aliment6 = _alimentacion6;
        }
    }
}