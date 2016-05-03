using HistoriaPersonalCormillot;
using System.Linq;


public class ComeDiaTipicoYFinde2Validaciones : PasosValidaciones
{
    private int idUsuario;

    public ComeDiaTipicoYFinde2Validaciones( int idUsuario )
    {
        this.idUsuario = idUsuario;
    }

    public void save(ComeDiaTipicoYFinde2 datos)
    {
        var datosGuardados = getdatosGuardados();
        datosGuardados.MediaTardeLugar = datos.MediaTardeLugar;
        datosGuardados.MediaTardeHora = datos.MediaTardeHora;
        datosGuardados.MediaTardeQueYCuanto = datos.MediaTardeQueYCuanto;
        datosGuardados.MediaTardeFinde = datos.MediaTardeFinde;
        datosGuardados.CenaLugar = datos.CenaLugar;
        datosGuardados.CenaHora = datos.CenaHora;
        datosGuardados.CenaQueYCuanto = datos.CenaQueYCuanto;
        datosGuardados.CenaFinde = datos.CenaFinde;
        datosGuardados.DespuesCenaLugar = datos.DespuesCenaLugar;
        datosGuardados.DespuesCenaHora = datos.DespuesCenaHora;
        datosGuardados.DespuesCenaQueYCuanto = datos.DespuesCenaQueYCuanto;
        datosGuardados.DespuesCenaFinde = datos.DespuesCenaFinde;
        datosGuardados.NocheLugar = datos.NocheLugar;
        datosGuardados.NocheHora = datos.NocheHora;
        datosGuardados.NocheQueYCuanto = datos.NocheQueYCuanto;
        datosGuardados.NocheFinde = datos.NocheFinde;
        model.SaveChanges();
    }

    public ComeDiaTipicoYFinde2 getdatosGuardados()
    {
        crearSiNoExiste();
        return model.ComeDiaTipicoYFinde2.Where(cm => cm.Usuario.Id == idUsuario)
                .OrderBy(cm => cm.Id)
                    .First();
    }

    public void crearSiNoExiste()
    {
        var hayDatos = model.ComeDiaTipicoYFinde2.Where(cm => cm.Usuario.Id == idUsuario).Count() > 0;
        if(!hayDatos)
        {
            var comediaTipicio = new ComeDiaTipicoYFinde2()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ComeDiaTipicoYFinde2.AddObject(comediaTipicio);
            model.SaveChanges();
        }
    }
}
