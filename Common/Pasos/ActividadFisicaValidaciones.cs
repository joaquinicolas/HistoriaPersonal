using HistoriaPersonalCormillot;
using System.Linq;


public class ActividadFisicaValidaciones : PasosValidaciones
{
    private int idUsuario;
    public ActividadFisicaValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ActividadFisica datos)
    {  
        var datosGuardados = getDatosGuardados();
        datosGuardados.RadioEstiloDeVida = datos.RadioEstiloDeVida;
        datosGuardados.RadioSuEstadoFisico = datos.RadioSuEstadoFisico;
        datosGuardados.CheckBañarse = datos.CheckBañarse;
        datosGuardados.CheckVerstirse = datos.CheckVerstirse;
        datosGuardados.CheckArreglarCasa = datos.CheckArreglarCasa;
        datosGuardados.CheckSubirEscaleras = datos.CheckSubirEscaleras;
        datosGuardados.CheckCaminarPorCasa = datos.CheckCaminarPorCasa;
        datosGuardados.CheckIrDeCompras = datos.CheckIrDeCompras;
        datosGuardados.CheckCamiarFueraDeCasa = datos.CheckCamiarFueraDeCasa;
        datosGuardados.CheckIrAlTrabajo = datos.CheckIrAlTrabajo;
        datosGuardados.CheckAtarseZapatos = datos.CheckAtarseZapatos;
        datosGuardados.CheckAtarseZapatos = datos.CheckAtarseZapatos;
        datosGuardados.CheckLevantarseDeSilla = datos.CheckLevantarseDeSilla;
        datosGuardados.CheckLevantarseDeCama = datos.CheckLevantarseDeCama;
        datosGuardados.OtraDificultad = datos.OtraDificultad;
        datosGuardados.RadioMotivacionActivdad = datos.RadioMotivacionActivdad;
        datosGuardados.RadioRealizaActivdad = datos.RadioRealizaActivdad;
        datosGuardados.ActivdadUno = datos.ActivdadUno;
        datosGuardados.PorSemanaActivdadUno = datos.PorSemanaActivdadUno;
        datosGuardados.TiempoActividadUno = datos.TiempoActividadUno;
        datosGuardados.ActivdadDos = datos.ActivdadDos;
        datosGuardados.PorSemanaActivdadDos = datos.PorSemanaActivdadDos;
        datosGuardados.TiempoActividadDos = datos.TiempoActividadDos;
        datosGuardados.ActividadTres = datos.ActividadTres;
        datosGuardados.PorSemanaActividadTres = datos.PorSemanaActividadTres;
        datosGuardados.TiempoActividadTres = datos.TiempoActividadTres;
        datosGuardados.CheckCaminata = datos.CheckCaminata;
        datosGuardados.CheckYoga = datos.CheckYoga;
        datosGuardados.CheckBicicleta = datos.CheckBicicleta;
        datosGuardados.CheckGimAcuatica = datos.CheckGimAcuatica;
        datosGuardados.CheckBaile = datos.CheckBaile;
        datosGuardados.CheckNatacion = datos.CheckNatacion;
        datosGuardados.CheckTaiChi = datos.CheckTaiChi;
        datosGuardados.CheckOtra = datos.CheckOtra;
        datosGuardados.OtraActivdad = datos.OtraActivdad;
        datosGuardados.MedioDeTransporte = datos.MedioDeTransporte;
        datosGuardados.CheckActividadAcompañado = datos.CheckActividadAcompañado;
        datosGuardados.CheckActividadGrupal = datos.CheckActividadGrupal;
        datosGuardados.CheckActividadPersonalizada = datos.CheckActividadPersonalizada;
        datosGuardados.CheckActividadSolo = datos.CheckActividadSolo;
        datosGuardados.CheckActividadNo = datos.CheckActividadNo;
        model.SaveChanges();
    }

    public ActividadFisica getDatosGuardados()
    {
        crearDatosSiNoExisten();
        return model.ActividadFisica.Where(ac => ac.Usuario.Id == idUsuario)
                .OrderByDescending(ac => ac.Id)
                    .First();
                    
    }

    public void crearDatosSiNoExisten()
    {
        var harDatos = model.ActividadFisica.Where(ac => ac.Usuario.Id == idUsuario).Count() > 0;
        if (!harDatos)
        {
            var actividad = new ActividadFisica()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ActividadFisica.AddObject(actividad);
            model.SaveChanges();
        }
    }

}
