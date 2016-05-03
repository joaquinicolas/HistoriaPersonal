using HistoriaPersonalCormillot;
using System.Linq;

public class AlimentacionValidaciones: PasosValidaciones
{
    private int idUsuario;

    public AlimentacionValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(Alimentacion datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.DecideComida = datosNuevos.DecideComida;
        datosGuardados.CompraComida = datosNuevos.CompraComida;
        datosGuardados.CocinaComida = datosNuevos.CocinaComida;
        datosGuardados.GustaCocinar = datosNuevos.GustaCocinar;

        datosGuardados.ComidaEnCasa = datosNuevos.ComidaEnCasa;
        datosGuardados.ComidaEnTrabajo = datosNuevos.ComidaEnTrabajo;
        datosGuardados.ComidaEnEstudio = datosNuevos.ComidaEnEstudio;
        datosGuardados.ComidaEnFinde = datosNuevos.ComidaEnFinde;

        datosGuardados.AlimentosEngordan = datosNuevos.AlimentosEngordan;
        datosGuardados.ComeDeMas = datosNuevos.ComeDeMas;
        
        datosGuardados.TrabajoPuedeComprarSiNo = datosNuevos.TrabajoPuedeComprarSiNo;
        datosGuardados.TrabajoPuedeComprarQue = datosNuevos.TrabajoPuedeComprarQue;
        datosGuardados.TrabajoPuedeLlevarSiNo = datosNuevos.TrabajoPuedeLlevarSiNo;
        datosGuardados.TrabajoPuedeLlevarQue = datosNuevos.TrabajoPuedeLlevarQue;
        datosGuardados.TrabajoPuedePrepararSiNo = datosNuevos.TrabajoPuedePrepararSiNo;
        datosGuardados.TrabajoPuedePrepararQue = datosNuevos.TrabajoPuedePrepararQue;

        model.SaveChanges();
    }

    public Alimentacion getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.Alimentacion.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.Alimentacion.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new Alimentacion()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.Alimentacion.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}