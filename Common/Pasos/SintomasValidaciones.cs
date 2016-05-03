using HistoriaPersonalCormillot;
using System.Linq;

public class SintomasValidaciones: PasosValidaciones
{
    private int idUsuario;

    public SintomasValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(Sintomas datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.SienteMal = datosNuevos.SienteMal;
        datosGuardados.CreeProblemaSalud = datosNuevos.CreeProblemaSalud;

        datosGuardados.ProblemasEnLaPiel = datosNuevos.ProblemasEnLaPiel;
        datosGuardados.Manchas = datosNuevos.Manchas;
        datosGuardados.VerrugasLunares = datosNuevos.VerrugasLunares;
        datosGuardados.Acne = datosNuevos.VerrugasLunares;
        datosGuardados.CaidaCabello = datosNuevos.CaidaCabello;

        datosGuardados.ProblemaNeurologico = datosNuevos.ProblemaNeurologico;
        datosGuardados.DolorCabeza = datosNuevos.DolorCabeza;
        datosGuardados.MareosVertigos = datosNuevos.MareosVertigos;

        datosGuardados.ProblemaDental = datosNuevos.ProblemaDental;
        datosGuardados.LlagasBultosBoca = datosNuevos.LlagasBultosBoca;
        datosGuardados.SangradoEncias = datosNuevos.SangradoEncias;

        datosGuardados.DigestionLenta = datosNuevos.DigestionLenta;
        datosGuardados.DolorAcidezEstomago = datosNuevos.DolorAcidezEstomago;
        datosGuardados.Vomitos = datosNuevos.Vomitos;
        datosGuardados.Meteorismo = datosNuevos.Meteorismo;
        datosGuardados.Constipacion = datosNuevos.Constipacion;
        datosGuardados.Diarrea = datosNuevos.Diarrea;
        datosGuardados.Hemorroides = datosNuevos.Hemorroides;
        datosGuardados.IntoleranciaAlimento = datosNuevos.IntoleranciaAlimento;

        datosGuardados.Colesterol = datosNuevos.Colesterol;
        datosGuardados.Trigliceridos = datosNuevos.Trigliceridos;
        datosGuardados.GotaAcidoUrico = datosNuevos.GotaAcidoUrico;
        datosGuardados.OsteoporosisOsteopenia = datosNuevos.OsteoporosisOsteopenia;
        datosGuardados.Diabetes = datosNuevos.Diabetes;
        datosGuardados.Alergias = datosNuevos.Alergias;
        datosGuardados.AlergiasAQue = datosNuevos.AlergiasAQue;

        
        datosGuardados.EnfermedadRespiratoria = datosNuevos.EnfermedadRespiratoria;
        datosGuardados.Ronquera = datosNuevos.Ronquera;
        datosGuardados.Ronca = datosNuevos.Ronca;
        datosGuardados.Despierta = datosNuevos.Despierta;
        datosGuardados.RespirarDormir = datosNuevos.RespirarDormir;
        datosGuardados.SuenioDia = datosNuevos.SuenioDia;
        
        datosGuardados.DificultadRespirarEsfuerzo = datosNuevos.DificultadRespirarEsfuerzo;
        datosGuardados.ProblemasCardiacos = datosNuevos.ProblemasCardiacos;
        datosGuardados.DolorPecho = datosNuevos.DolorPecho;
        datosGuardados.Palpitaciones = datosNuevos.Palpitaciones;
        datosGuardados.PresionAlta = datosNuevos.PresionAlta;

        datosGuardados.CalculosUrinarios = datosNuevos.CalculosUrinarios;
        datosGuardados.InfeccionViasUrinarias = datosNuevos.InfeccionViasUrinarias;
        datosGuardados.PerdidaFuerzaOrinar = datosNuevos.PerdidaFuerzaOrinar;
        datosGuardados.IncontinenciaUrinaria = datosNuevos.IncontinenciaUrinaria;

        datosGuardados.DolorPiernasCaminar = datosNuevos.DolorPiernasCaminar;
        datosGuardados.Varices = datosNuevos.Varices;
        datosGuardados.InfeccionesPiernas = datosNuevos.InfeccionesPiernas;
        datosGuardados.PiesHinchados = datosNuevos.PiesHinchados;
        datosGuardados.Calambres = datosNuevos.Calambres;
        datosGuardados.Hormigueos = datosNuevos.Hormigueos;
        datosGuardados.ArticulacionesRojas = datosNuevos.ArticulacionesRojas;
        datosGuardados.ProblemasGenitales = datosNuevos.ProblemasGenitales;
        datosGuardados.PerdidaSangre = datosNuevos.PerdidaSangre;
        datosGuardados.Picazon = datosNuevos.Picazon;
        datosGuardados.PicazonDonde = datosNuevos.PicazonDonde;
        datosGuardados.Ganglios = datosNuevos.Ganglios;

        datosGuardados.ProblemasOido = datosNuevos.ProblemasOido;
        datosGuardados.ProblemasVista = datosNuevos.ProblemasVista;

        datosGuardados.EnfermedadTiroidea = datosNuevos.EnfermedadTiroidea;
        datosGuardados.PielSeca = datosNuevos.PielSeca;
        datosGuardados.UniasFragiles = datosNuevos.UniasFragiles;
        datosGuardados.CabelloSeco = datosNuevos.CabelloSeco;
        datosGuardados.SensibilidadFrio = datosNuevos.SensibilidadFrio;
        datosGuardados.CansancioInexplicable = datosNuevos.CansancioInexplicable;

        datosGuardados.TristeAngustiadoDeprimido = datosNuevos.TristeAngustiadoDeprimido;
        datosGuardados.LlantoFacil = datosNuevos.LlantoFacil;
        datosGuardados.PocoPlacerCotidiano = datosNuevos.PocoPlacerCotidiano;
        datosGuardados.PerdidaInteres = datosNuevos.PerdidaInteres;
        datosGuardados.PocaInteraccion = datosNuevos.PocaInteraccion;
        datosGuardados.Aislamiento = datosNuevos.Aislamiento;

        model.SaveChanges();
    }

    public Sintomas getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.Sintomas.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.Sintomas.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new Sintomas()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.Sintomas.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}