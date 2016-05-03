using HistoriaPersonalCormillot;
using System.Linq;

public class ComentarioGeneralValidaciones: PasosValidaciones
{
    private int idUsuario;

    public ComentarioGeneralValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ComentarioGeneral datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.Comentario = datosNuevos.Comentario;

        model.SaveChanges();
    }

    public ComentarioGeneral getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ComentarioGeneral.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ComentarioGeneral.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ComentarioGeneral()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ComentarioGeneral.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}