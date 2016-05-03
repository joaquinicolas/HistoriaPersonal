using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;
using System.Linq;

public class Sintomas3Validaciones: PasosValidaciones
{
    private int idUsuario;
    
    public Sintomas3Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }


    public void save(Sintomas3 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.sintomas.DificultadConcentrarse = datosNuevos.DificultadConcentrarse;
        datosGuardados.sintomas.Indecisión = datosNuevos.Indecisión;
        datosGuardados.sintomas.SentimientoCulpa = datosNuevos.SentimientoCulpa;
        datosGuardados.sintomas.Aburrimiento = datosNuevos.Aburrimiento;
        datosGuardados.sintomas.SoloEnElMundo = datosNuevos.SoloEnElMundo;
        datosGuardados.sintomas.SensacionVacio = datosNuevos.SoloEnElMundo;

        datosGuardados.sintomas.IrritacionIncontrolable = datosNuevos.IrritacionIncontrolable;
        datosGuardados.sintomas.OscilacionesAnimo = datosNuevos.OscilacionesAnimo;
        datosGuardados.sintomas.Nervios = datosNuevos.Nervios;
        datosGuardados.sintomas.Enojo = datosNuevos.Enojo;
        datosGuardados.sintomas.Autolesiones = datosNuevos.Autolesiones;
        datosGuardados.sintomas.Agresion = datosNuevos.Agresion;
        datosGuardados.sintomas.Furia = datosNuevos.Furia;
        datosGuardados.sintomas.Habla = datosNuevos.Habla;
        datosGuardados.sintomas.DuermeMenos = datosNuevos.DuermeMenos;
        datosGuardados.sintomas.EstarCima = datosNuevos.EstarCima;
        datosGuardados.sintomas.AumentoSexual = datosNuevos.AumentoSexual;
        datosGuardados.sintomas.GastaDinero = datosNuevos.GastaDinero;
        datosGuardados.sintomas.Apuestas = datosNuevos.Apuestas;
        datosGuardados.sintomas.ActividadUsual = datosNuevos.ActividadUsual;

        datosGuardados.sintomas.Ansioso = datosNuevos.Ansioso;
        datosGuardados.sintomas.PreocupacionesExcesivas = datosNuevos.PreocupacionesExcesivas;
        datosGuardados.sintomas.TensionMuscular = datosNuevos.TensionMuscular;
        datosGuardados.sintomas.EstadoAnimo = datosNuevos.EstadoAnimo;
        datosGuardados.sintomas.Miedos = datosNuevos.Miedos;
        datosGuardados.sintomas.PensamientosIncomodos = datosNuevos.PensamientosIncomodos;

        datosGuardados.sintomas.NoPlacerSexual = datosNuevos.NoPlacerSexual;
        datosGuardados.sintomas.DeseoSexual = datosNuevos.DeseoSexual;
        datosGuardados.sintomas.DificultadesSexuales = datosNuevos.DificultadesSexuales;
        datosGuardados.sintomas.EvitarSexuales = datosNuevos.EvitarSexuales;

        datosGuardados.sintomas.Autoestima = datosNuevos.Autoestima;
        datosGuardados.sintomas.PerdidasSiNo = datosNuevos.PerdidasSiNo;
        datosGuardados.sintomas.CualesPerdidas = datosNuevos.CualesPerdidas;
        datosGuardados.sintomas.TraumaticoSiNo = datosNuevos.TraumaticoSiNo;
        datosGuardados.sintomas.TraumaticoQue = datosNuevos.TraumaticoQue;
        datosGuardados.sintomas.TraumaticoCuando = datosNuevos.TraumaticoCuando;

        datosGuardados.sintomas.DificultadQuedarseDormido = datosNuevos.DificultadQuedarseDormido;
        datosGuardados.sintomas.SeDespiertaNoche = datosNuevos.SeDespiertaNoche;
        datosGuardados.sintomas.Pesadillas = datosNuevos.Pesadillas;
        datosGuardados.sintomas.DuermeDiaNoNoche = datosNuevos.DuermeDiaNoNoche;
        datosGuardados.sintomas.TomaPastillasDormir = datosNuevos.TomaPastillasDormir;
        
        model.SaveChanges();
    }
 
    public EstadoClinico_HabitosViewModel getDatosGuardados()
    {
        crearDatosSiNoExiste();
        
        //return model.Sintomas3.Where(rtm => rtm.Usuario.Id == idUsuario)
        //                .OrderByDescending(rmt => rmt.Id)
        //                    .First();
        var estadoClinico_sintomas = new EstadoClinico_HabitosViewModel();
        estadoClinico_sintomas.sintomas = model.Sintomas3.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                            .First();
        return estadoClinico_sintomas;
    }
   

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.Sintomas3.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new Sintomas3()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.Sintomas3.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
 
}