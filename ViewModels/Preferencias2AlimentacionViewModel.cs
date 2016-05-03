using System;
using System.Linq;
using System.Collections.Generic;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;
using System.Web;


namespace HistoriaPersonalCormillot.ViewModels
{
    public class Preferencias2AlimentacionViewModel
    {
        public Preferencias2 preferencias { get; set; }
        public Alimentacion alimentacion { get; set; }


        public Preferencias2AlimentacionViewModel() { }

        public Preferencias2AlimentacionViewModel(Preferencias2 _preferencias2,Alimentacion _alimentacion)
        {
            this.preferencias = _preferencias2;
            this.alimentacion = _alimentacion;
        }
    }
}