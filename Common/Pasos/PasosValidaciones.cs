using HistoriaPersonalCormillot;
using System.Linq;

public class PasosValidaciones
{
    protected  CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();

    protected Usuario getUsuario(int idUsuario)
    {
        return model.Usuario.Where(u => u.Id == idUsuario).First();
    }
}