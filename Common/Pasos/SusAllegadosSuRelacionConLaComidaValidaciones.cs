using HistoriaPersonalCormillot;
using System.Linq;


public class SusAllegadosSuRelacionConLaComidaValidaciones : PasosValidaciones
{
    private int idUsuario;

    public SusAllegadosSuRelacionConLaComidaValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(SusAllegadosSuRelacionConLaComida datos)
    {
        var datosGuardados = getDatosGuardados();
        datosGuardados.CantPesoNormal = datos.CantPesoNormal;
        datosGuardados.TienenPesoNormal = datos.TienenPesoNormal;
        datosGuardados.CantSobrepeso = datos.CantSobrepeso;
        datosGuardados.TienenSobrepeso = datos.TienenSobrepeso;
        datosGuardados.RadioUrgenciaDeComer = datos.RadioUrgenciaDeComer;
        datosGuardados.RadioComeDeNoche = datos.RadioComeDeNoche;
        datosGuardados.RadioComeParaDormir = datos.RadioComeParaDormir;
        datosGuardados.RadioComeSinControl = datos.RadioComeSinControl;
        datosGuardados.RadioLaxantes = datos.RadioLaxantes;
        datosGuardados.RadioDiureticos = datos.RadioDiureticos;
        datosGuardados.RadioInduceVomito = datos.RadioInduceVomito;
        datosGuardados.RadioRestringeAlimento = datos.RadioRestringeAlimento;
        datosGuardados.RadioActFisicaExagerada = datos.RadioActFisicaExagerada;
        datosGuardados.RadioPorcentajeIngesta = datos.RadioPorcentajeIngesta;
        datosGuardados.AlergiaAComida = datos.AlergiaAComida;
        model.SaveChanges();
    }

    public SusAllegadosSuRelacionConLaComida getDatosGuardados()
    {
        crearDatosSiNoExisten();
        return model.SusAllegadosSuRelacionConLaComida.Where(src => src.Usuario.Id == idUsuario)
                .OrderBy(src => src.Id)
                    .First();
    }

    public void crearDatosSiNoExisten()
    {
        var hayDatos =
            model.SusAllegadosSuRelacionConLaComida.Where(src => src.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var SusAllegadosRelacion = new SusAllegadosSuRelacionConLaComida()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.SusAllegadosSuRelacionConLaComida.AddObject(SusAllegadosRelacion);
            model.SaveChanges();
        }

    }

}
