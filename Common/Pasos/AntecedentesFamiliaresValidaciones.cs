using HistoriaPersonalCormillot;
using System.Linq;

public class AntecedentesFamiliaresValidaciones: PasosValidaciones
{
    private int idUsuario;

    public AntecedentesFamiliaresValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(AntecedentesFamiliares datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.VivePadre = datosNuevos.VivePadre;
        datosGuardados.ViveMadre = datosNuevos.ViveMadre;
        datosGuardados.ViveAbuelos = datosNuevos.ViveAbuelos;
        datosGuardados.ViveConyuge = datosNuevos.ViveConyuge;
        datosGuardados.ViveHnos = datosNuevos.ViveHnos;
        datosGuardados.ViveHijos = datosNuevos.ViveHijos;

        datosGuardados.ObesidadPadre = datosNuevos.ObesidadPadre;
        datosGuardados.ObesidadMadre = datosNuevos.ObesidadMadre;
        datosGuardados.ObesidadAbuelos = datosNuevos.ObesidadAbuelos;
        datosGuardados.ObesidadConyuge = datosNuevos.ObesidadConyuge;
        datosGuardados.ObesidadHnos = datosNuevos.ObesidadHnos;
        datosGuardados.ObesidadHijos = datosNuevos.ObesidadHijos;
        
        datosGuardados.DiabetesPadre = datosNuevos.DiabetesPadre;
        datosGuardados.DiabetesMadre = datosNuevos.DiabetesMadre;
        datosGuardados.DiabetesAbuelos = datosNuevos.DiabetesAbuelos;
        datosGuardados.DiabetesConyuge = datosNuevos.DiabetesConyuge;
        datosGuardados.DiabetesHnos = datosNuevos.DiabetesHnos;
        datosGuardados.DiabetesHijos = datosNuevos.DiabetesHijos;
        
        datosGuardados.ColesterolPadre = datosNuevos.ColesterolPadre;
        datosGuardados.ColesterolMadre = datosNuevos.ColesterolMadre;
        datosGuardados.ColesterolAbuelos = datosNuevos.ColesterolAbuelos;
        datosGuardados.ColesterolConyuge = datosNuevos.ColesterolConyuge;
        datosGuardados.ColesterolHnos = datosNuevos.ColesterolHnos;
        datosGuardados.ColesterolHijos = datosNuevos.ColesterolHijos;

        datosGuardados.TrigliceridosPadre = datosNuevos.TrigliceridosPadre;
        datosGuardados.TrigliceridosMadre = datosNuevos.TrigliceridosMadre;
        datosGuardados.TrigliceridosAbuelos = datosNuevos.TrigliceridosAbuelos;
        datosGuardados.TrigliceridosConyuge = datosNuevos.TrigliceridosConyuge;
        datosGuardados.TrigliceridosHnos = datosNuevos.TrigliceridosHnos;
        datosGuardados.TrigliceridosHijos = datosNuevos.TrigliceridosHijos;

        datosGuardados.CardiacaPadre = datosNuevos.CardiacaPadre;
        datosGuardados.CardiacaMadre = datosNuevos.CardiacaMadre;
        datosGuardados.CardiacaAbuelos = datosNuevos.CardiacaAbuelos;
        datosGuardados.CardiacaConyuge = datosNuevos.CardiacaConyuge;
        datosGuardados.CardiacaHnos = datosNuevos.CardiacaHnos;
        datosGuardados.CardiacaHijos = datosNuevos.CardiacaHijos;

        datosGuardados.DerramePadre = datosNuevos.DerramePadre;
        datosGuardados.DerrameMadre = datosNuevos.DerrameMadre;
        datosGuardados.DerrameAbuelos = datosNuevos.DerrameAbuelos;
        datosGuardados.DerrameConyuge = datosNuevos.DerrameConyuge;
        datosGuardados.DerrameHnos = datosNuevos.DerrameHnos;
        datosGuardados.DerrameHijos = datosNuevos.DerrameHijos;

        datosGuardados.HipertensionPadre = datosNuevos.HipertensionPadre;
        datosGuardados.HipertensionMadre = datosNuevos.HipertensionMadre;
        datosGuardados.HipertensionAbuelos = datosNuevos.HipertensionAbuelos;
        datosGuardados.HipertensionConyuge = datosNuevos.HipertensionConyuge;
        datosGuardados.HipertensionHnos = datosNuevos.HipertensionHnos;
        datosGuardados.HipertensionHijos = datosNuevos.HipertensionHijos;

        datosGuardados.SubitaPadre = datosNuevos.SubitaPadre;
        datosGuardados.SubitaMadre = datosNuevos.SubitaMadre;
        datosGuardados.SubitaAbuelos = datosNuevos.SubitaAbuelos;
        datosGuardados.SubitaConyuge = datosNuevos.SubitaConyuge;
        datosGuardados.SubitaHnos = datosNuevos.SubitaHnos;
        datosGuardados.SubitaHijos = datosNuevos.SubitaHijos;

        datosGuardados.CancerPadre = datosNuevos.CancerPadre;
        datosGuardados.CancerMadre = datosNuevos.CancerMadre;
        datosGuardados.CancerAbuelos = datosNuevos.CancerAbuelos;
        datosGuardados.CancerConyuge = datosNuevos.CancerConyuge;
        datosGuardados.CancerHnos = datosNuevos.CancerHnos;
        datosGuardados.CancerHijos = datosNuevos.CancerHijos;

        datosGuardados.DepresionPadre = datosNuevos.DepresionPadre;
        datosGuardados.DepresionMadre = datosNuevos.DepresionMadre;
        datosGuardados.DepresionAbuelos = datosNuevos.DepresionAbuelos;
        datosGuardados.DepresionConyuge = datosNuevos.DepresionConyuge;
        datosGuardados.DepresionHnos = datosNuevos.DepresionHnos;
        datosGuardados.DepresionHijos = datosNuevos.DepresionHijos;

        datosGuardados.PreocupacionPadre = datosNuevos.PreocupacionPadre;
        datosGuardados.PreocupacionMadre = datosNuevos.PreocupacionMadre;
        datosGuardados.PreocupacionAbuelos = datosNuevos.PreocupacionAbuelos;
        datosGuardados.PreocupacionConyuge = datosNuevos.PreocupacionConyuge;
        datosGuardados.PreocupacionHnos = datosNuevos.PreocupacionHnos;
        datosGuardados.PreocupacionHijos = datosNuevos.PreocupacionHijos;

        datosGuardados.PsicologicosPadre = datosNuevos.PsicologicosPadre;
        datosGuardados.PsicologicosMadre = datosNuevos.PsicologicosMadre;
        datosGuardados.PsicologicosAbuelos = datosNuevos.PsicologicosAbuelos;
        datosGuardados.PsicologicosConyuge = datosNuevos.PsicologicosConyuge;
        datosGuardados.PsicologicosHnos = datosNuevos.PsicologicosHnos;
        datosGuardados.PsicologicosHijos = datosNuevos.PsicologicosHijos;
        
        datosGuardados.DrogasPadre = datosNuevos.DrogasPadre;
        datosGuardados.DrogasMadre = datosNuevos.DrogasMadre;
        datosGuardados.DrogasAbuelos = datosNuevos.DrogasAbuelos;
        datosGuardados.DrogasConyuge = datosNuevos.DrogasConyuge;
        datosGuardados.DrogasHnos = datosNuevos.DrogasHnos;
        datosGuardados.DrogasHijos = datosNuevos.DrogasHijos;

        datosGuardados.FamiliaMenos60 = datosNuevos.FamiliaMenos60;
        datosGuardados.QuienMenos60 = datosNuevos.QuienMenos60;
        datosGuardados.CausaMenos60 = datosNuevos.CausaMenos60;

        datosGuardados.SaludPeriodo = datosNuevos.SaludPeriodo;
        datosGuardados.TuvoIntervenciones = datosNuevos.TuvoIntervenciones;
        datosGuardados.MedicacionTomada = datosNuevos.MedicacionTomada;
        datosGuardados.RadioMedicacionActual = datosNuevos.RadioMedicacionActual;
        datosGuardados.MedicacionActual = datosNuevos.MedicacionActual;
        datosGuardados.TipoCancer = datosNuevos.TipoCancer;
        
        model.SaveChanges();
    }

    public AntecedentesFamiliares getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.AntecedentesFamiliares.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.AntecedentesFamiliares.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new AntecedentesFamiliares()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.AntecedentesFamiliares.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}