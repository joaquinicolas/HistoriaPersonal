using HistoriaPersonalCormillot;
using System.Linq;

public class PreferenciasValidaciones : PasosValidaciones
{
    private int idUsuario;

    public PreferenciasValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(Preferencias datos)
    {
        var datosGuardados = getDatosGuardados();
        datosGuardados.SuDieta = datos.SuDieta;
        datosGuardados.RadioAlimentoPreferido = datos.RadioAlimentoPreferido;
        datosGuardados.AlimentoPreferido = datos.AlimentoPreferido;
        datosGuardados.RadioTipoAlimentoPreferido = datos.RadioTipoAlimentoPreferido;
        datosGuardados.RadioDesordenado = datos.RadioDesordenado;
        datosGuardados.RadioSalteo = datos.RadioSalteo;
        datosGuardados.RadioPicoteo = datos.RadioPicoteo;
        datosGuardados.RadioHagoAyunos = datos.RadioHagoAyunos;
        datosGuardados.RadioDepresion = datos.RadioDepresion;
        datosGuardados.RadioAnsiedad = datos.RadioAnsiedad;
        datosGuardados.RadioEstres = datos.RadioEstres;
        datosGuardados.RadioEnojo = datos.RadioEnojo;
        datosGuardados.RadioAburrimiento = datos.RadioAburrimiento;
        datosGuardados.RadioAlegria = datos.RadioAlegria;
        datosGuardados.RadioDescontrol = datos.RadioDescontrol;
        datosGuardados.RadioCansancio = datos.RadioCansancio;
        datosGuardados.RadioPreSentimental = datos.RadioPreSentimental;
        datosGuardados.RadioEmbarazo = datos.RadioEmbarazo;
        model.SaveChanges();
    }

    public Preferencias getDatosGuardados()
    {
        crearDatosSiNoExisten();
        return model.Preferencias.Where(p => p.Usuario.Id == idUsuario)
                .OrderBy(pr => pr.Id)
                    .First();
    }

    public void crearDatosSiNoExisten()
    {
        var hayDatos =
            model.Preferencias.Where(p => p.Usuario.Id == idUsuario).Count() > 0;
        if(!hayDatos)
        {
            var preferencias = new Preferencias()
            {
                Usuario = getUsuario(idUsuario)
            };
        model.Preferencias.AddObject(preferencias);
        model.SaveChanges();
        }
    }
}
