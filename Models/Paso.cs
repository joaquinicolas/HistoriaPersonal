using System;
using System.Linq;


namespace HistoriaPersonalCormillot{
    public partial class Paso
    {
        private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();
        public Paso Anterior()
        {
            var query = from Paso p in model.Paso
                        where p.Orden < this.Orden
                        orderby p.Orden descending
                        select p;
            if (query.Count() == 0)
                throw new Exception("No hay anterior");

            return query.First();
        }
        public Paso Siguiente()
        {
            var query = from Paso p in model.Paso
                        where p.Orden > this.Orden
                        orderby p.Orden
                        select p;
            if (query.Count() == 0)
                throw new Exception("No hay siguiente");

            return query.First();
        }
    }
}