using HistoriaPersonalCormillot;
using System.Linq;

public class ClasificacionAlimentacion6Validaciones: PasosValidaciones
{
    private int idUsuario;

    public ClasificacionAlimentacion6Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ClasificacionAlimentacion6 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();
        
        datosGuardados.DulceDeLeche = datosNuevos.DulceDeLeche;
        datosGuardados.Facturas = datosNuevos.Facturas;
        datosGuardados.Golosinas = datosNuevos.Golosinas;
        datosGuardados.Masitas = datosNuevos.Masitas;

        datosGuardados.Mermeladas = datosNuevos.Mermeladas;
        datosGuardados.Panqueques = datosNuevos.Panqueques;
        datosGuardados.Pastelitos = datosNuevos.Pastelitos;
        datosGuardados.Tortas = datosNuevos.Tortas;

        datosGuardados.Otros = datosNuevos.Otros;
        
        model.SaveChanges();
    }

    public ClasificacionAlimentacion6 getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ClasificacionAlimentacion6.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ClasificacionAlimentacion6.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ClasificacionAlimentacion6()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ClasificacionAlimentacion6.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}