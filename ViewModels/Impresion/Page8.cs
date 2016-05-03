using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.ViewModels.Impresion
{
    public class Page8
    {
        public ClasificacionAlimentacion1_2_3ViewModel clas123 { get; set; }
        public ClasificacionAlimentacion3_4_5_6ViewModel clas3456 { get; set; }
        
        public Page8(ClasificacionAlimentacion1_2_3ViewModel _clasificacion_alimentacion123, ClasificacionAlimentacion3_4_5_6ViewModel _clasificacion_alimentacion456)
        {
            this.clas123 = _clasificacion_alimentacion123;
            this.clas3456 = _clasificacion_alimentacion456;
        }
    
    }
}