using System.Linq;
using HistoriaPersonalCormillot.ViewModels;
using HistoriaPersonalCormillot;

public class SintomasHabitosValidaciones: PasosValidaciones
{
   
          private int idUsuario;

          public SintomasHabitosValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }
          public void save(EstadoClinico_HabitosViewModel datosNuevos)
          {
              var datosGuardados = getDatos();
              

              datosGuardados.sintomas.DificultadConcentrarse = datosNuevos.sintomas.DificultadConcentrarse;
              datosGuardados.sintomas.Indecisión = datosNuevos.sintomas.Indecisión;
              datosGuardados.sintomas.SentimientoCulpa = datosNuevos.sintomas.SentimientoCulpa;
              datosGuardados.sintomas.Aburrimiento = datosNuevos.sintomas.Aburrimiento;
              datosGuardados.sintomas.SoloEnElMundo = datosNuevos.sintomas.SoloEnElMundo;
              datosGuardados.sintomas.SensacionVacio = datosNuevos.sintomas.SensacionVacio;

              datosGuardados.sintomas.IrritacionIncontrolable = datosNuevos.sintomas.IrritacionIncontrolable;
              datosGuardados.sintomas.OscilacionesAnimo = datosNuevos.sintomas.OscilacionesAnimo;
              datosGuardados.sintomas.Nervios = datosNuevos.sintomas.Nervios;
              datosGuardados.sintomas.Enojo = datosNuevos.sintomas.Enojo;
              datosGuardados.sintomas.Autolesiones = datosNuevos.sintomas.Autolesiones;
              datosGuardados.sintomas.Agresion = datosNuevos.sintomas.Agresion;
              datosGuardados.sintomas.Furia = datosNuevos.sintomas.Furia;
              datosGuardados.sintomas.Habla = datosNuevos.sintomas.Habla;
              datosGuardados.sintomas.DuermeMenos = datosNuevos.sintomas.DuermeMenos;
              datosGuardados.sintomas.EstarCima = datosNuevos.sintomas.EstarCima;
              datosGuardados.sintomas.AumentoSexual = datosNuevos.sintomas.AumentoSexual;
              datosGuardados.sintomas.GastaDinero = datosNuevos.sintomas.GastaDinero;
              datosGuardados.sintomas.Apuestas = datosNuevos.sintomas.Apuestas;
              datosGuardados.sintomas.ActividadUsual = datosNuevos.sintomas.ActividadUsual;

              datosGuardados.sintomas.Ansioso = datosNuevos.sintomas.Ansioso;
              datosGuardados.sintomas.PreocupacionesExcesivas = datosNuevos.sintomas.PreocupacionesExcesivas;
              datosGuardados.sintomas.TensionMuscular = datosNuevos.sintomas.TensionMuscular;
              datosGuardados.sintomas.EstadoAnimo = datosNuevos.sintomas.EstadoAnimo;
              datosGuardados.sintomas.Miedos = datosNuevos.sintomas.Miedos;
              datosGuardados.sintomas.PensamientosIncomodos = datosNuevos.sintomas.PensamientosIncomodos;

              datosGuardados.sintomas.NoPlacerSexual = datosNuevos.sintomas.NoPlacerSexual;
              datosGuardados.sintomas.DeseoSexual = datosNuevos.sintomas.DeseoSexual;
              datosGuardados.sintomas.DificultadesSexuales = datosNuevos.sintomas.DificultadesSexuales;
              datosGuardados.sintomas.EvitarSexuales = datosNuevos.sintomas.EvitarSexuales;

              datosGuardados.sintomas.Autoestima = datosNuevos.sintomas.Autoestima;
              datosGuardados.sintomas.PerdidasSiNo = datosNuevos.sintomas.PerdidasSiNo;
              datosGuardados.sintomas.CualesPerdidas = datosNuevos.sintomas.CualesPerdidas;
              datosGuardados.sintomas.TraumaticoSiNo = datosNuevos.sintomas.TraumaticoSiNo;
              datosGuardados.sintomas.TraumaticoQue = datosNuevos.sintomas.TraumaticoQue;
              datosGuardados.sintomas.TraumaticoCuando = datosNuevos.sintomas.TraumaticoCuando;

              datosGuardados.sintomas.DificultadQuedarseDormido = datosNuevos.sintomas.DificultadQuedarseDormido;
              datosGuardados.sintomas.SeDespiertaNoche = datosNuevos.sintomas.SeDespiertaNoche;
              datosGuardados.sintomas.Pesadillas = datosNuevos.sintomas.Pesadillas;
              datosGuardados.sintomas.DuermeDiaNoNoche = datosNuevos.sintomas.DuermeDiaNoNoche;
              datosGuardados.sintomas.TomaPastillasDormir = datosNuevos.sintomas.TomaPastillasDormir;

              //Habitos
              datosGuardados.habitos.HorasSueño = datosNuevos.habitos.HorasSueño;
              datosGuardados.habitos.CuantosCigarrillosPorDia = datosNuevos.habitos.CuantosCigarrillosPorDia;
              datosGuardados.habitos.Fuma = datosNuevos.habitos.Fuma;
              datosGuardados.habitos.CervezaLatas = datosNuevos.habitos.CervezaLatas;
              datosGuardados.habitos.VasosVino = datosNuevos.habitos.VasosVino;
              datosGuardados.habitos.BlancasMedidas = datosNuevos.habitos.BlancasMedidas;
              datosGuardados.habitos.OtrasMedidas = datosNuevos.habitos.OtrasMedidas;
              datosGuardados.habitos.TomaCalmarse = datosNuevos.habitos.TomaCalmarse;
              datosGuardados.habitos.ParaDormirToma = datosNuevos.habitos.ParaDormirToma;
              datosGuardados.habitos.TomaASolas = datosNuevos.habitos.TomaASolas;
              datosGuardados.habitos.DejeFumarHace = datosNuevos.habitos.DejeFumarHace;
              //datosGuardados.habitos.DificultadParaQuedarseDormido = datosNuevos.habitos.DificultadParaQuedarseDormido;
              //datosGuardados.habitos.ActitudAmigos = datosNuevos.habitos.ActitudAmigos;
              //datosGuardados.habitos.ActitudCompañeros = datosNuevos.habitos.ActitudCompañeros;
              //datosGuardados.habitos.ActitudConyuge = datosNuevos.habitos.ActitudConyuge;
              //datosGuardados.habitos.ActitudHermanos = datosNuevos.habitos.ActitudHermanos;
              //datosGuardados.habitos.ActitudHijos = datosNuevos.habitos.ActitudHijos;
              //datosGuardados.habitos.ActitudPadres = datosNuevos.habitos.ActitudPadres;

              
              //datosGuardados.habitos.DificultadParaQuedarseDormido = datosNuevos.habitos.DificultadParaQuedarseDormido;
              //datosGuardados.habitos.DuermeDeDia = datosNuevos.habitos.DuermeDeDia;

             
              //datosGuardados.habitos.IntentoCambiarBebida = datosNuevos.habitos.IntentoCambiarBebida;
              //datosGuardados.habitos.IntentoDejarBeber = datosNuevos.habitos.IntentoDejarBeber;
              //datosGuardados.habitos.LlamadoAtencion = datosNuevos.habitos.LlamadoAtencion;

        
              //datosGuardados.habitos.PreocupaManeraBeber = datosNuevos.habitos.PreocupaManeraBeber;
              //datosGuardados.habitos.RelacionAmigos = datosNuevos.habitos.RelacionAmigos;
              //datosGuardados.habitos.RelacionCompañerosTrabajo = datosNuevos.habitos.RelacionCompañerosTrabajo;
              //datosGuardados.habitos.RelacionFamilia = datosNuevos.habitos.RelacionFamilia;
              //datosGuardados.habitos.RelacionHijos = datosNuevos.habitos.RelacionHijos;
              //datosGuardados.habitos.RelacionPareja = datosNuevos.habitos.RelacionPareja;
              //datosGuardados.habitos.SeDespiertaDuranteLaNoche = datosNuevos.habitos.SeDespiertaDuranteLaNoche;
              //datosGuardados.habitos.SienteCulpa = datosNuevos.habitos.SienteCulpa;
              //datosGuardados.habitos.TienePesadillas = datosNuevos.habitos.TienePesadillas;

             
              //datosGuardados.habitos.TomaPastillas = datosNuevos.habitos.TomaPastillas;
              

              datosGuardados.habitos.FumaS = datosNuevos.habitos.FumaS;
              datosGuardados.habitos.PreocupaManeraBeberS = datosNuevos.habitos.PreocupaManeraBeberS;
              datosGuardados.habitos.SienteCulpaS = datosNuevos.habitos.SienteCulpaS;
              datosGuardados.habitos.IntentoDejarBeberS = datosNuevos.habitos.IntentoDejarBeberS;
              datosGuardados.habitos.LlamadoAtencionS = datosNuevos.habitos.LlamadoAtencionS;
              datosGuardados.habitos.TomaCalmarseS = datosNuevos.habitos.TomaCalmarseS;
              datosGuardados.habitos.TomaASolasS = datosNuevos.habitos.TomaASolasS;
              datosGuardados.habitos.IntentoCambiarBebidaS = datosNuevos.habitos.IntentoCambiarBebidaS;
              datosGuardados.habitos.ParaDormirTomaS = datosNuevos.habitos.ParaDormirTomaS;
              
              model.SaveChanges();
          }


          public EstadoClinico_HabitosViewModel getDatos()
          {
              crearDatosSiNoExiste();
              var estadoClinico_sintomas = new EstadoClinico_HabitosViewModel();
              estadoClinico_sintomas.sintomas = model.Sintomas3.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                          .First();
              estadoClinico_sintomas.habitos = model.Habitos.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                          .First();
              
              return estadoClinico_sintomas;

          }

          private void crearDatosSiNoExiste()
          {
              var hayDatos =
                      model.Sintomas3.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
              var hayDatosH =
                      model.Habitos.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

              if (!hayDatos)
              {
                  var antecedentes = new Sintomas3()
                  {
                      Usuario = getUsuario(idUsuario)
                  };
                  model.Sintomas3.AddObject(antecedentes);
              }
              if (!hayDatosH)
              {
                  var antecedentesH = new Habitos()
              {
                  Usuario = getUsuario(idUsuario)
              };


                  model.Habitos.AddObject(antecedentesH);
              }
              model.SaveChanges();

          }
    
    }
