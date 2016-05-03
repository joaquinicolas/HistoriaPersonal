using HistoriaPersonalCormillot;
using System.Linq;

public class SusHabitos2Validaciones : PasosValidaciones
{
    private int idUsuario;

    public SusHabitos2Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(SusHabitos2 datos)
    {
        var datosGuardados = getDatosGuardados();
        datosGuardados.ActitudPadres = datos.ActitudPadres;
        datosGuardados.ActitudHermanos = datos.ActitudHermanos;
        datosGuardados.ActitudConyuge = datos.ActitudConyuge;
        datosGuardados.ActitudHijos = datos.ActitudHijos;
        datosGuardados.ActitudAmigos = datos.ActitudAmigos;
        datosGuardados.ActitudCompañeros = datos.ActitudCompañeros;

        datosGuardados.RelacionHijos = datos.RelacionHijos;
        datosGuardados.RelacionAmigos = datos.RelacionAmigos;
        datosGuardados.RelacionPareja = datos.RelacionPareja;
        datosGuardados.RelacionFamilia = datos.RelacionFamilia;
        datosGuardados.RelacionCompañerosTrabajo = datos.RelacionCompañerosTrabajo;

        model.SaveChanges();
    }

    public SusHabitos2 getDatosGuardados()
    {
        crearDatosSiNoExisten();
        return model.SusHabitos2.Where(p => p.Usuario.Id == idUsuario)
                .OrderBy(p => p.Id)
                    .First();
    }

    public void crearDatosSiNoExisten()
    {
        var hayDatos = 
            model.SusHabitos2.Where(p => p.Usuario.Id == idUsuario).Count() > 0;
        if(!hayDatos)
        {
            var data = new SusHabitos2()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.SusHabitos2.AddObject(data);
            model.SaveChanges();
        }
    }


}
