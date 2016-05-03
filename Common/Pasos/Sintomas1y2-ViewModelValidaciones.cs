using System.Linq;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;


public class Sintomas1y2_ViewModelValidaciones:PasosValidaciones
 {
         private int idUsuario;

         public Sintomas1y2_ViewModelValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }
         public void save(Sintomas1y2_ViewModel datosNuevos)
         {
             var datosGuardados = getDatos();
             //Sintomas1
             datosGuardados.sintomas1.SienteMal = datosNuevos.sintomas1.SienteMal;
             datosGuardados.sintomas1.CreeProblemaSalud = datosNuevos.sintomas1.CreeProblemaSalud;

             datosGuardados.sintomas1.EnfermedadRespiratoria = datosNuevos.sintomas1.EnfermedadRespiratoria;
             datosGuardados.sintomas1.Ronquera = datosNuevos.sintomas1.Ronquera;
             datosGuardados.sintomas1.Ronca = datosNuevos.sintomas1.Ronca;
             datosGuardados.sintomas1.Despierta = datosNuevos.sintomas1.Despierta;
             datosGuardados.sintomas1.RespirarDormir = datosNuevos.sintomas1.RespirarDormir;
             datosGuardados.sintomas1.SuenioDia = datosNuevos.sintomas1.SuenioDia;

             datosGuardados.sintomas1.DificultadRespirarEsfuerzo = datosNuevos.sintomas1.DificultadRespirarEsfuerzo;
             datosGuardados.sintomas1.ProblemasCardiacos = datosNuevos.sintomas1.ProblemasCardiacos;
             datosGuardados.sintomas1.DolorPecho = datosNuevos.sintomas1.DolorPecho;
             datosGuardados.sintomas1.Palpitaciones = datosNuevos.sintomas1.Palpitaciones;
             datosGuardados.sintomas1.PresionAlta = datosNuevos.sintomas1.PresionAlta;

             datosGuardados.sintomas1.CalculosUrinarios = datosNuevos.sintomas1.CalculosUrinarios;
             datosGuardados.sintomas1.InfeccionViasUrinarias = datosNuevos.sintomas1.InfeccionViasUrinarias;
             datosGuardados.sintomas1.PerdidaFuerzaOrinar = datosNuevos.sintomas1.PerdidaFuerzaOrinar;
             datosGuardados.sintomas1.IncontinenciaUrinaria = datosNuevos.sintomas1.IncontinenciaUrinaria;

             datosGuardados.sintomas1.DolorPiernasCaminar = datosNuevos.sintomas1.DolorPiernasCaminar;
             datosGuardados.sintomas1.Varices = datosNuevos.sintomas1.Varices;
             datosGuardados.sintomas1.InfeccionesPiernas = datosNuevos.sintomas1.InfeccionesPiernas;
             datosGuardados.sintomas1.PiesHinchados = datosNuevos.sintomas1.PiesHinchados;
             datosGuardados.sintomas1.Calambres = datosNuevos.sintomas1.Calambres;
             datosGuardados.sintomas1.Hormigueos = datosNuevos.sintomas1.Hormigueos;
             datosGuardados.sintomas1.ArticulacionesRojas = datosNuevos.sintomas1.ArticulacionesRojas;
             datosGuardados.sintomas1.ProblemasGenitales = datosNuevos.sintomas1.ProblemasGenitales;
             datosGuardados.sintomas1.PerdidaSangre = datosNuevos.sintomas1.PerdidaSangre;
             datosGuardados.sintomas1.Picazon = datosNuevos.sintomas1.Picazon;
             datosGuardados.sintomas1.PicazonDonde = datosNuevos.sintomas1.PicazonDonde;
             datosGuardados.sintomas1.Ganglios = datosNuevos.sintomas1.Ganglios;

             datosGuardados.sintomas1.ProblemasOido = datosNuevos.sintomas1.ProblemasOido;
             datosGuardados.sintomas1.ProblemasVista = datosNuevos.sintomas1.ProblemasVista;

             datosGuardados.sintomas1.EnfermedadTiroidea = datosNuevos.sintomas1.EnfermedadTiroidea;
             datosGuardados.sintomas1.PielSeca = datosNuevos.sintomas1.PielSeca;
             datosGuardados.sintomas1.UniasFragiles = datosNuevos.sintomas1.UniasFragiles;
             datosGuardados.sintomas1.CabelloSeco = datosNuevos.sintomas1.CabelloSeco;
             datosGuardados.sintomas1.SensibilidadFrio = datosNuevos.sintomas1.SensibilidadFrio;
             datosGuardados.sintomas1.CansancioInexplicable = datosNuevos.sintomas1.CansancioInexplicable;

          



             //Sintomas2
             datosGuardados.sintomas2.ColesterolAumentado = datosNuevos.sintomas2.ColesterolAumentado;
             datosGuardados.sintomas2.TrigliceridosAumentados = datosNuevos.sintomas2.TrigliceridosAumentados;
             datosGuardados.sintomas2.Gota = datosNuevos.sintomas2.Gota;
             datosGuardados.sintomas2.Osteoporosis = datosNuevos.sintomas2.Osteoporosis;
             datosGuardados.sintomas2.Diabetes = datosNuevos.sintomas2.Diabetes;
             datosGuardados.sintomas2.Alergias = datosNuevos.sintomas2.Alergias;
             datosGuardados.sintomas2.AlergiasQUe = datosNuevos.sintomas2.AlergiasQUe;

             datosGuardados.sintomas2.DigestionLenta = datosNuevos.sintomas2.DigestionLenta;
             datosGuardados.sintomas2.DolorEstomago = datosNuevos.sintomas2.DolorEstomago;
             datosGuardados.sintomas2.Vomitos = datosNuevos.sintomas2.Vomitos;
             datosGuardados.sintomas2.Meteorismo = datosNuevos.sintomas2.Meteorismo;
             datosGuardados.sintomas2.Constipacion = datosNuevos.sintomas2.Constipacion;
             datosGuardados.sintomas2.Diarrrea = datosNuevos.sintomas2.Diarrrea;
             datosGuardados.sintomas2.Hemorroides = datosNuevos.sintomas2.Hemorroides;
             datosGuardados.sintomas2.IntoleranciaAlimento = datosNuevos.sintomas2.IntoleranciaAlimento;
            

             datosGuardados.sintomas2.ProblemasPiel = datosNuevos.sintomas2.ProblemasPiel;
             datosGuardados.sintomas2.Verrugas = datosNuevos.sintomas2.Verrugas;
             datosGuardados.sintomas2.Manchas = datosNuevos.sintomas2.Manchas;
             datosGuardados.sintomas2.Acne = datosNuevos.sintomas2.Acne;
             datosGuardados.sintomas2.CaidaCabello = datosNuevos.sintomas2.CaidaCabello;

             datosGuardados.sintomas2.ProblemaDental = datosNuevos.sintomas2.ProblemaDental;
             datosGuardados.sintomas2.Llagas = datosNuevos.sintomas2.Llagas;
             datosGuardados.sintomas2.SangradoEncias = datosNuevos.sintomas2.SangradoEncias;

             datosGuardados.sintomas2.ProblemaNeurologico = datosNuevos.sintomas2.ProblemaNeurologico;
             datosGuardados.sintomas2.DoloresCabeza = datosNuevos.sintomas2.DoloresCabeza;
             datosGuardados.sintomas2.Mareos = datosNuevos.sintomas2.Mareos;

             datosGuardados.sintomas2.Triste = datosNuevos.sintomas2.Triste;
             datosGuardados.sintomas2.LlantoFacil = datosNuevos.sintomas2.LlantoFacil;
             datosGuardados.sintomas2.PocoPlacer = datosNuevos.sintomas2.PocoPlacer;
             datosGuardados.sintomas2.PerdidaInteres = datosNuevos.sintomas2.PerdidaInteres;
             datosGuardados.sintomas2.PocaInteraccion = datosNuevos.sintomas2.PocaInteraccion;
             datosGuardados.sintomas2.Aislamiento = datosNuevos.sintomas2.Aislamiento;

             //datosGuardados.sintomas2.DificultadConcentrarse = datosNuevos.sintomas2.DificultadConcentrarse;
             //datosGuardados.sintomas2.Indecision = datosNuevos.sintomas2.Indecision;
             //datosGuardados.sintomas2.SentimientoCulpa = datosNuevos.sintomas2.SentimientoCulpa;
             //datosGuardados.sintomas2.Aburrimiento = datosNuevos.sintomas2.Aburrimiento;
             //datosGuardados.sintomas2.SoloMundo = datosNuevos.sintomas2.SoloMundo;
             //datosGuardados.sintomas2.SensacionVacio = datosNuevos.sintomas2.SensacionVacio;

             model.SaveChanges();
         }







         public Sintomas1y2_ViewModel getDatos()
         {
             crearDatosSiNoExiste();
             var sintomas1y2 = new Sintomas1y2_ViewModel();
             sintomas1y2.sintomas1 = model.Sintomas.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                         .First();
             sintomas1y2.sintomas2 = model.Sintomas2.Where(rtm => rtm.Usuario.Id == idUsuario).OrderByDescending(rtm => rtm.Id)
                                         .First();

             return sintomas1y2;

         }

         private void crearDatosSiNoExiste()
         {
             var hayDatosS1 =
                     model.Sintomas.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
             var hayDatosS2 =
                     model.Sintomas2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

             if (!hayDatosS1)
             {
                 var antecedentes = new Sintomas()
                 {
                     Usuario = getUsuario(idUsuario)
                 };
                 model.Sintomas.AddObject(antecedentes);
             }
             if (!hayDatosS2)
             {
                 var antecedentesH = new Sintomas2()
                 {
                     Usuario = getUsuario(idUsuario)
                 };


                 model.Sintomas2.AddObject(antecedentesH);
             }
             model.SaveChanges();

         }

  }
