using HistoriaPersonalCormillot;
using System.Linq;

public class Sintomas2Validaciones: PasosValidaciones
{
    private int idUsuario;

    public Sintomas2Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(Sintomas2 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.ColesterolAumentado = datosNuevos.ColesterolAumentado;
        datosGuardados.TrigliceridosAumentados = datosNuevos.TrigliceridosAumentados;
        datosGuardados.Gota = datosNuevos.Gota;
        datosGuardados.Osteoporosis = datosNuevos.Osteoporosis;
        datosGuardados.Diabetes = datosNuevos.Diabetes;
        datosGuardados.Alergias = datosNuevos.Alergias;
        datosGuardados.AlergiasQUe = datosNuevos.AlergiasQUe;

        datosGuardados.DigestionLenta = datosNuevos.DigestionLenta;
        datosGuardados.DolorEstomago = datosNuevos.DolorEstomago;
        datosGuardados.Vomitos = datosNuevos.Vomitos;
        datosGuardados.Meteorismo = datosNuevos.Meteorismo;
        datosGuardados.Constipacion = datosNuevos.Constipacion;
        datosGuardados.Diarrrea = datosNuevos.Diarrrea;
        datosGuardados.Hemorroides = datosNuevos.Hemorroides;
        datosGuardados.IntoleranciaAlimento = datosNuevos.IntoleranciaAlimento;

        datosGuardados.ProblemasPiel = datosNuevos.ProblemasPiel;
        datosGuardados.Verrugas = datosNuevos.Verrugas;
        datosGuardados.Manchas = datosNuevos.Manchas;
        datosGuardados.Acne = datosNuevos.Acne;
        datosGuardados.CaidaCabello = datosNuevos.CaidaCabello;
        
        datosGuardados.ProblemaDental = datosNuevos.ProblemaDental;
        datosGuardados.Llagas = datosNuevos.Llagas;
        datosGuardados.SangradoEncias = datosNuevos.SangradoEncias;
        
        datosGuardados.ProblemaNeurologico = datosNuevos.ProblemaNeurologico;
        datosGuardados.DoloresCabeza = datosNuevos.DoloresCabeza;
        datosGuardados.Mareos = datosNuevos.Mareos;
        
        datosGuardados.Triste = datosNuevos.Triste;
        datosGuardados.LlantoFacil = datosNuevos.LlantoFacil;
        datosGuardados.PocoPlacer = datosNuevos.PocoPlacer;
        datosGuardados.PerdidaInteres = datosNuevos.PerdidaInteres;
        datosGuardados.PocaInteraccion = datosNuevos.PocaInteraccion;
        datosGuardados.Aislamiento = datosNuevos.Aislamiento;
        datosGuardados.DificultadConcentrarse = datosNuevos.DificultadConcentrarse;
        datosGuardados.Indecision = datosNuevos.Indecision;
        datosGuardados.SentimientoCulpa = datosNuevos.SentimientoCulpa;
        datosGuardados.Aburrimiento = datosNuevos.Aburrimiento;
        datosGuardados.SoloMundo = datosNuevos.SoloMundo;
        datosGuardados.SensacionVacio = datosNuevos.SensacionVacio;

        model.SaveChanges();
    }

    public Sintomas2 getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.Sintomas2.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.Sintomas2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new Sintomas2()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.Sintomas2.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}