using HistoriaPersonalCormillot;
using System.Linq;


public class ComeDiaTipicoYFindeValidaciones : PasosValidaciones
{
    private int idUsuario;

    public ComeDiaTipicoYFindeValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ComeDiaTipicoYFinde datos)
    {
        var datosGuardados = getDatosGuardados();
        datosGuardados.DesayunoLugar = datos.DesayunoLugar;
        datosGuardados.DesayunoHora = datos.DesayunoHora;
        datosGuardados.DesayunoQueYCuanto = datos.DesayunoQueYCuanto;
        datosGuardados.DesayunoFinde = datos.DesayunoFinde;
        datosGuardados.MediaMnianaLugar = datos.MediaMnianaLugar;
        datosGuardados.MediaManianaHora = datos.MediaManianaHora;
        datosGuardados.MediaManianaQueyCuanto = datos.MediaManianaQueyCuanto;
        datosGuardados.MediaManianaFinde = datos.MediaManianaFinde;
        datosGuardados.AlmuerzoLugar = datos.AlmuerzoLugar;
        datosGuardados.AlmuerzoHora = datos.AlmuerzoHora;
        datosGuardados.AlmuerzoQueYcuanto = datos.AlmuerzoQueYcuanto;
        datosGuardados.AlmuerzoFinde = datos.AlmuerzoFinde;
        datosGuardados.MeriendaLugar = datos.MeriendaLugar;
        datosGuardados.MeriendaHora = datos.MeriendaHora;
        datosGuardados.MeriendaQueYCuanto = datos.MeriendaQueYCuanto;
        datosGuardados.MeriendaFinde = datos.MeriendaFinde;

        model.SaveChanges();
    }

    public ComeDiaTipicoYFinde getDatosGuardados()
    {
        crearSiNoExiste();
        return model.ComeDiaTipicoYFinde.Where(cm => cm.Usuario.Id == idUsuario)
                .OrderBy(cm => cm.Id)
                    .First();
    }

    public void crearSiNoExiste()
    {
        var hayDatos =
            model.ComeDiaTipicoYFinde.Where(cm => cm.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var ComeDiaTipico = new ComeDiaTipicoYFinde()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ComeDiaTipicoYFinde.AddObject(ComeDiaTipico);
            model.SaveChanges();
        }
    }
}
