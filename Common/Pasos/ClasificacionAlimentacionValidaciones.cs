using HistoriaPersonalCormillot;
using System.Linq;

public class ClasificacionAlimentacionValidaciones: PasosValidaciones
{
    private int idUsuario;

    public ClasificacionAlimentacionValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ClasificacionAlimentacion datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.LecheDescremada = datosNuevos.LecheDescremada;
        datosGuardados.QuesoBlanco = datosNuevos.QuesoBlanco;
        datosGuardados.QuesoGruyere = datosNuevos.QuesoGruyere;
        datosGuardados.QuesoPortSalut = datosNuevos.QuesoPortSalut;
        datosGuardados.QuesoRoquefort = datosNuevos.QuesoRoquefort;
        datosGuardados.QuesoDuros = datosNuevos.QuesoDuros;
        datosGuardados.YofurtDescremado = datosNuevos.YofurtDescremado;

        datosGuardados.Amargos = datosNuevos.Amargos;
        datosGuardados.Soja = datosNuevos.Soja;
        datosGuardados.Cafe = datosNuevos.Cafe;
        datosGuardados.GaseosaLight = datosNuevos.GaseosaLight;
        datosGuardados.JugoLight = datosNuevos.JugoLight;
        datosGuardados.JugoNatural = datosNuevos.JugoNatural;
        datosGuardados.Chocolatada = datosNuevos.Chocolatada;
        datosGuardados.Cerveza = datosNuevos.Cerveza;
        datosGuardados.Champan = datosNuevos.Champan;
        datosGuardados.Sidra = datosNuevos.Sidra;

        datosGuardados.Fernet = datosNuevos.Fernet;
        datosGuardados.Tes = datosNuevos.Tes;
        datosGuardados.Sidra = datosNuevos.Sidra;

        datosGuardados.Cerdo = datosNuevos.Cerdo;
        datosGuardados.Chinchulin = datosNuevos.Chinchulin;
        datosGuardados.Chorizo = datosNuevos.Chorizo;
        datosGuardados.Fiambres = datosNuevos.Fiambres;
        datosGuardados.Higado = datosNuevos.Higado;
        datosGuardados.Molleja = datosNuevos.Molleja;
        datosGuardados.Morcilla = datosNuevos.Morcilla;
        datosGuardados.Salchichas = datosNuevos.Salchichas;
        datosGuardados.Rinion = datosNuevos.Rinion;
        datosGuardados.Vacuna = datosNuevos.Vacuna;
        datosGuardados.Albondigas = datosNuevos.Albondigas;
        datosGuardados.Asado = datosNuevos.Asado;
        datosGuardados.CarneHorno = datosNuevos.CarneHorno;
        datosGuardados.Hamburguesas = datosNuevos.Hamburguesas;
        datosGuardados.McDonald = datosNuevos.McDonald;
        datosGuardados.Milanesas = datosNuevos.Milanesas;

        model.SaveChanges();
    }

    public ClasificacionAlimentacion getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ClasificacionAlimentacion.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ClasificacionAlimentacion.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ClasificacionAlimentacion()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ClasificacionAlimentacion.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}