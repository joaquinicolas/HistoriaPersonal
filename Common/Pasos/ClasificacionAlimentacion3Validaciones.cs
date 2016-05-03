using HistoriaPersonalCormillot;
using System.Linq;

public class ClasificacionAlimentacion3Validaciones: PasosValidaciones
{
    private int idUsuario;

    public ClasificacionAlimentacion3Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ClasificacionAlimentacion3 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.Rucula = datosNuevos.Rucula;
        datosGuardados.Tomate = datosNuevos.Tomate;
        datosGuardados.TomateCherry = datosNuevos.TomateCherry;
        datosGuardados.Zanahoria = datosNuevos.Zanahoria;
        datosGuardados.Zapallito = datosNuevos.Zapallito;
        datosGuardados.Zapallo = datosNuevos.Zapallo;
        datosGuardados.Cazuelas = datosNuevos.Cazuelas;
        datosGuardados.PapasFritas = datosNuevos.PapasFritas;
        datosGuardados.PapasHorno = datosNuevos.PapasHorno;
        datosGuardados.Pure = datosNuevos.Pure;
        datosGuardados.Revueltos = datosNuevos.Revueltos;
        datosGuardados.Sopas = datosNuevos.Sopas;
        datosGuardados.Tartas = datosNuevos.Tartas;
        datosGuardados.Tortillas = datosNuevos.Tortillas;
        datosGuardados.VegetalesRellenos = datosNuevos.VegetalesRellenos;

        datosGuardados.Arvejas = datosNuevos.Arvejas;
        datosGuardados.Chauchas = datosNuevos.Chauchas;
        datosGuardados.Lentejas = datosNuevos.Lentejas;
        datosGuardados.MilanesasSoja = datosNuevos.MilanesasSoja;
        datosGuardados.PorotosComunes = datosNuevos.PorotosComunes;
        datosGuardados.PorotosSoja = datosNuevos.PorotosSoja;
        datosGuardados.BrotesSoja = datosNuevos.BrotesSoja;

        datosGuardados.ArrozBlanco = datosNuevos.ArrozBlanco;
        datosGuardados.ArrozIntegral = datosNuevos.ArrozIntegral;
        datosGuardados.AvenaArrollada = datosNuevos.AvenaArrollada;
        datosGuardados.BarrasCereal = datosNuevos.BarrasCereal;
        datosGuardados.CoposCereal = datosNuevos.CoposCereal;
        datosGuardados.GalletasArroz = datosNuevos.GalletasArroz;
        datosGuardados.GalletitasAgua = datosNuevos.GalletitasAgua;
        datosGuardados.GalletitasDulces = datosNuevos.GalletitasDulces;
        datosGuardados.Mueslix = datosNuevos.Mueslix;
        datosGuardados.PanArabe = datosNuevos.PanArabe;
        datosGuardados.PanBaguette = datosNuevos.PanBaguette;
        datosGuardados.PanBlanco = datosNuevos.PanBlanco;
        datosGuardados.PanSalvado = datosNuevos.PanSalvado;

        model.SaveChanges();
    }

    public ClasificacionAlimentacion3 getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ClasificacionAlimentacion3.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ClasificacionAlimentacion3.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ClasificacionAlimentacion3()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ClasificacionAlimentacion3.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}