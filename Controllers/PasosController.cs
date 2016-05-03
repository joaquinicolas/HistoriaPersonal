using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HistoriaPersonalCormillot.Models;
using HistoriaPersonalCormillot.Common;
using HistoriaPersonalCormillot.ViewModels;

namespace HistoriaPersonalCormillot.Controllers
{
    [ActionFilterUsuarioLogeado]
    public class PasosController : Controller
    {
        private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();

        private int _idUsuario;
        private int idUsuario 
        {
            get
            {
                if (_idUsuario == 0 && Session["IdUsuario"] != null)
                {
                    _idUsuario = (int)Session["IdUsuario"];
                }
                return _idUsuario;
            }
            set
            {
                _idUsuario = value;
            }
        }

        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult AnteriorPaso(int id)
        {
            var pasoAnterior = new Paso() { Orden = id }.Anterior();
            if (pasoAnterior.Consejo != null)
                return RedirectToAction("Consejos", new { id = pasoAnterior.Id });

            return RedirectToAction(pasoAnterior.Descripcion);
        }
        public ActionResult ProximoPaso(int id)
        {
            var pasoSiguiente = new Paso() { Orden = id }.Siguiente();
            if (pasoSiguiente.Consejo != null)
                return RedirectToAction("Consejos", new { id = pasoSiguiente.Id });
            
            return RedirectToAction(pasoSiguiente.Descripcion);
        }

            /*CONSEJOS*/
        public ActionResult Consejos(int id)
        {
            var consejo = getConsejo(id);
            ViewBag.Pagina = consejo.Paso.Orden;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;
            return View(consejo);
        }

            /*DATOS PERSONALES*/
        public ActionResult DatosPersonales()
        {
            ViewBag.Pagina = 1;
            ViewBag.EsConsejo = false;
           
            crearDatosPersonalesSiNoExiste(idUsuario);
            DatosPersonales datosPersonales = getDatosPersonalesUsuario(idUsuario);
            ViewBag.NombreyApellido = datosPersonales.NombreyApellido;

            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;
            return View(datosPersonales);
        }
        [HttpPost]
        public ActionResult SaveDatosPersonales(DatosPersonales datos)
        {
            try
            {
                var datosPersonales = getDatosPersonalesUsuario(idUsuario);
                datosPersonales.Fecha = datos.Fecha ?? null;
                datosPersonales.NombreyApellido = datos.NombreyApellido ?? "";
                datosPersonales.FechaNacimiento = datos.FechaNacimiento;
                datosPersonales.Edad = parsearIntPositivo(datos.Edad);
                datosPersonales.EstadoCivil = datos.EstadoCivil ?? "";
                datosPersonales.ViveCon = datos.ViveCon ?? "";
                datosPersonales.Domicilio = datos.Domicilio ?? "";
                datosPersonales.Hijos = datos.Hijos;
                datosPersonales.EdadesySexo = datos.EdadesySexo ?? "";
                datosPersonales.ObraSocialoPrepago = datos.ObraSocialoPrepago ?? "";
                datosPersonales.NroAfiliado = datos.NroAfiliado;
                datosPersonales.TelEmergenciaObraSocial = datos.TelEmergenciaObraSocial ?? "";
                datosPersonales.EstudiosCursados = datos.EstudiosCursados;
                datosPersonales.ActividadActual = datos.ActividadActual;
                datosPersonales.DireccionCorrespondencia = datos.DireccionCorrespondencia;

                datosPersonales.TelMensajes1 = datos.TelMensajes1;
                datosPersonales.HorarioMensajesDesde1 = datos.HorarioMensajesDesde1;
                datosPersonales.HorarioMensajesHasta1 = datos.HorarioMensajesHasta1;

                datosPersonales.TelMensajes2 = datos.TelMensajes2;
                datosPersonales.HorarioMensajesDesde2 = datos.HorarioMensajesDesde2;
                datosPersonales.HorarioMensajesHasta2 = datos.HorarioMensajesHasta2;

                datosPersonales.TelCelular = datos.TelCelular;
                datosPersonales.TelBeeper = datos.TelBeeper;
                datosPersonales.Email = datos.Email;
                datosPersonales.NecesidadNombre = datos.NecesidadNombre;
                datosPersonales.NecesidadTel = datos.NecesidadTel;

                datosPersonales.PacienteSiNo = datos.PacienteSiNo;
                datosPersonales.PacienteAño = datos.PacienteAño;

                datosPersonales.ConocioClinicaOtroPaciente = datos.ConocioClinicaOtroPaciente;
                datosPersonales.ConocioClinicaDiarios = datos.ConocioClinicaDiarios;
                datosPersonales.ConocioClinicaRevistas = datos.ConocioClinicaRevistas;
                datosPersonales.ConocioClinicaTV = datos.ConocioClinicaTV;
                datosPersonales.ConocioClinicaInternet = datos.ConocioClinicaInternet;
                datosPersonales.ConocioClinicaOtro = datos.ConocioClinicaOtro;

                model.SaveChanges();
                return Json("OK", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

            /*RELACION TRATAMIENTO MOTIVACION*/
        public ActionResult RelacionTratamientoMotivacion()
        {
            ViewBag.Pagina = 2;
            ViewBag.EsConsejo = false;

            crearRelacionTratamientoMotivacionSiNoExiste(idUsuario);
            RelacionTratamientoMotivacion relacionTratamientoMotivacion = getRelacionTramiteMotivacion(idUsuario);

            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;
            return View(relacionTratamientoMotivacion);
        }
        [HttpPost]
        public ActionResult SaveRelacionTratamientoMotivacion(RelacionTratamientoMotivacion datos)
        {
            try
            {
                var relacionTratamientoMotivacion = getRelacionTramiteMotivacion(idUsuario);
                relacionTratamientoMotivacion.Razon1 = datos.Razon1;
                relacionTratamientoMotivacion.Razon2 = datos.Razon2;
                relacionTratamientoMotivacion.Razon3 = datos.Razon3;
                relacionTratamientoMotivacion.QueDeseaCambiar = datos.QueDeseaCambiar;
                relacionTratamientoMotivacion.Motivacion = datos.Motivacion;
                relacionTratamientoMotivacion.MantenerPeso = datos.MantenerPeso;
                relacionTratamientoMotivacion.SubirPesoV = datos.SubirPesoV;
                relacionTratamientoMotivacion.BajarPesoV = datos.BajarPesoV;
                relacionTratamientoMotivacion.TiempoHacerConPeso = datos.TiempoHacerConPeso;
                relacionTratamientoMotivacion.ExpectativaCambiarPeso = datos.ExpectativaCambiarPeso;
                relacionTratamientoMotivacion.ConfianzaCambiarPeso = datos.ConfianzaCambiarPeso;
                relacionTratamientoMotivacion.EsperaTratamiento = datos.EsperaTratamiento;
                relacionTratamientoMotivacion.Medicamentos = datos.Medicamentos;
                relacionTratamientoMotivacion.CirugiaBariatrica = datos.CirugiaBariatrica;
                relacionTratamientoMotivacion.CirugiaPlastica = datos.CirugiaPlastica;
                relacionTratamientoMotivacion.Hierbas = datos.Hierbas;
                relacionTratamientoMotivacion.Otros = datos.Otros;
                relacionTratamientoMotivacion.OtrosText = datos.OtrosText;
                relacionTratamientoMotivacion.HaRealizadoTratamiento = datos.HaRealizadoTratamiento;
                relacionTratamientoMotivacion.CuantosTratamiento = datos.CuantosTratamiento;
                relacionTratamientoMotivacion.TratamientoClinicaCormillot = datos.TratamientoClinicaCormillot;
                relacionTratamientoMotivacion.TratamientoPsiquiatria = datos.TratamientoPsiquiatria;
                relacionTratamientoMotivacion.TratamientoDietaClub = datos.TratamientoDietaClub;
                relacionTratamientoMotivacion.TratamientoAlco = datos.TratamientoAlco;
                relacionTratamientoMotivacion.TratamientoPsicoterapia = datos.TratamientoPsicoterapia;
                relacionTratamientoMotivacion.TratamientoActividadFisica = datos.TratamientoActividadFisica;
                relacionTratamientoMotivacion.TratamientoHomeopatia = datos.TratamientoHomeopatia;
                relacionTratamientoMotivacion.TratamientoDietasPorSuCuenta = datos.TratamientoDietasPorSuCuenta;
                relacionTratamientoMotivacion.TratamientoMedicoODietista = datos.TratamientoMedicoODietista;
                relacionTratamientoMotivacion.TratamientoInternet = datos.TratamientoInternet;
                relacionTratamientoMotivacion.TratamientoCirugia = datos.TratamientoCirugia;
                relacionTratamientoMotivacion.TratamientoMedicamentos = datos.TratamientoMedicamentos;
                relacionTratamientoMotivacion.TratamientoOtros = datos.TratamientoOtros;
                relacionTratamientoMotivacion.TratamientoCuales = datos.TratamientoCuales;
                relacionTratamientoMotivacion.TratamiengoInternacion = datos.TratamiengoInternacion;
                relacionTratamientoMotivacion.TratamientoCual=datos.TratamientoCual;


                model.SaveChanges();
                return Json("OK", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

        /*RELACION TRATAMIENTO MOTIVACION 2*/
        public ActionResult RelacionTratamientoMotivacion2()
        {
            ViewBag.Pagina = 3;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            crearRelacionTratamientoMotivacion2SiNoExiste(idUsuario);
            var relacionTratamientoMotivacion2 = getRelacionTramiteMotivacion2(idUsuario);
            return View(relacionTratamientoMotivacion2);
        }
        [HttpPost]
        public ActionResult SaveRelacionTratamientoMotivacion2(RelacionTratamientoMotivacion2 datos)
        {
            try
            {
                var relacionTratamientoMotivacion2 = getRelacionTramiteMotivacion2(idUsuario);
                relacionTratamientoMotivacion2.HaRealizadoTratamiento = datos.HaRealizadoTratamiento;
                relacionTratamientoMotivacion2.CuantosTratamiento = datos.CuantosTratamiento;

                //relacionTratamientoMotivacion2.TratamientoClinicaCormillot = datos.TratamientoClinicaCormillot;
                //relacionTratamientoMotivacion2.TratamientoPsiquiatria = datos.TratamientoPsiquiatria;
                //relacionTratamientoMotivacion2.TratamientoDietaClub = datos.TratamientoDietaClub;
                //relacionTratamientoMotivacion2.TratamientoAlco = datos.TratamientoAlco;
                //relacionTratamientoMotivacion2.TratamientoPsicoterapia = datos.TratamientoPsicoterapia;
                //relacionTratamientoMotivacion2.TratamientoActividadFisica = datos.TratamientoActividadFisica;
                //relacionTratamientoMotivacion2.TratamientoHomeopatia = datos.TratamientoHomeopatia;
                //relacionTratamientoMotivacion2.TratamientoDietasPorSuCuenta = datos.TratamientoDietasPorSuCuenta;
                //relacionTratamientoMotivacion2.TratamientoMedicoODietista = datos.TratamientoMedicoODietista;
                //relacionTratamientoMotivacion2.TratamientoInternet = datos.TratamientoInternet;
                //relacionTratamientoMotivacion2.TratamientoCirugia = datos.TratamientoCirugia;
                //relacionTratamientoMotivacion2.TratamientoMedicamentos = datos.TratamientoMedicamentos;
                //relacionTratamientoMotivacion2.TratamientoOtros = datos.TratamientoOtros;
                //relacionTratamientoMotivacion2.TratamientoCuales = datos.TratamientoCuales;

                relacionTratamientoMotivacion2.CuantoBajoEnTratamientosAnteriores = datos.CuantoBajoEnTratamientosAnteriores;
                relacionTratamientoMotivacion2.EfectoNegativoTratamientosAnteriores = datos.EfectoNegativoTratamientosAnteriores;
                relacionTratamientoMotivacion2.CualEfectoNegativoTratamientosAnteriores = datos.CualEfectoNegativoTratamientosAnteriores;
                relacionTratamientoMotivacion2.MotivoTratamientosAnterioresFallaron = datos.MotivoTratamientosAnterioresFallaron;

                relacionTratamientoMotivacion2.BarreraTratamientoHorarios = datos.BarreraTratamientoHorarios;
                relacionTratamientoMotivacion2.BarreraTratamientoDesorden = datos.BarreraTratamientoDesorden;
                relacionTratamientoMotivacion2.BarreraTratamientoEstres = datos.BarreraTratamientoEstres;
                relacionTratamientoMotivacion2.BarreraTratamientoEstadoDeAnimo = datos.BarreraTratamientoEstadoDeAnimo;
                relacionTratamientoMotivacion2.BarreraTratamientoFamilia = datos.BarreraTratamientoFamilia;
                relacionTratamientoMotivacion2.BarreraTratamientoVidaSocial = datos.BarreraTratamientoVidaSocial;
                relacionTratamientoMotivacion2.BarreraTratamientoTrabajo = datos.BarreraTratamientoTrabajo;
                relacionTratamientoMotivacion2.BarreraTratamientoMotivacion = datos.BarreraTratamientoMotivacion;
                relacionTratamientoMotivacion2.BarreraTratamientoOtro = datos.BarreraTratamientoOtro;
                relacionTratamientoMotivacion2.BarreraTratamientoCual = datos.BarreraTratamientoCual;

                relacionTratamientoMotivacion2.AbandonarTratamientoNoModificarPeso = datos.AbandonarTratamientoNoModificarPeso;
                relacionTratamientoMotivacion2.AbandonarTratamientoProblemasPersonales = datos.AbandonarTratamientoProblemasPersonales;
                relacionTratamientoMotivacion2.AbandonarTratamientoVidaSocial = datos.AbandonarTratamientoVidaSocial;
                relacionTratamientoMotivacion2.AbandonarTratamientoModificarloPoco = datos.AbandonarTratamientoModificarloPoco;
                relacionTratamientoMotivacion2.AbandonarTratamientoProblemasEconomicos = datos.AbandonarTratamientoProblemasEconomicos;
                relacionTratamientoMotivacion2.AbandonarTratamientoSentirsePresionado = datos.AbandonarTratamientoSentirsePresionado;
                relacionTratamientoMotivacion2.AbandonarTratamientoSalirUnaVezYAbandonar = datos.AbandonarTratamientoSalirUnaVezYAbandonar;
                relacionTratamientoMotivacion2.AbandonarTratamientoLlevarseMalConElEquipo = datos.AbandonarTratamientoLlevarseMalConElEquipo;
                relacionTratamientoMotivacion2.AbandonarTratamientoAburrirseDeLaDieta = datos.AbandonarTratamientoAburrirseDeLaDieta;
                relacionTratamientoMotivacion2.AbandonarTratamientoDistanciaALaQueVive = datos.AbandonarTratamientoDistanciaALaQueVive;
                relacionTratamientoMotivacion2.AbandonarTratamientoPocoApoyoFamiliar = datos.AbandonarTratamientoPocoApoyoFamiliar;
                relacionTratamientoMotivacion2.AbandonarTratamientoOtras = datos.AbandonarTratamientoOtras;

                relacionTratamientoMotivacion2.PesoActualAlimentacion = datos.PesoActualAlimentacion;
                relacionTratamientoMotivacion2.PesoActualAnsiedad = datos.PesoActualAnsiedad;
                relacionTratamientoMotivacion2.PesoActualProblemasDeSalud = datos.PesoActualProblemasDeSalud;
                relacionTratamientoMotivacion2.PesoActualEmbarazos = datos.PesoActualEmbarazos;
                relacionTratamientoMotivacion2.PesoActualAlcohol = datos.PesoActualAlcohol;
                relacionTratamientoMotivacion2.PesoActualEstres = datos.PesoActualEstres;
                relacionTratamientoMotivacion2.PesoActualMetabolismo = datos.PesoActualMetabolismo;
                relacionTratamientoMotivacion2.PesoActualHerencia = datos.PesoActualHerencia;
                relacionTratamientoMotivacion2.PesoActualSedentarismo = datos.PesoActualSedentarismo;
                relacionTratamientoMotivacion2.PesoActualMedicacion = datos.PesoActualMedicacion;
                relacionTratamientoMotivacion2.PesoActualDejarDeFumar = datos.PesoActualDejarDeFumar;
                relacionTratamientoMotivacion2.PesoActualDepresion = datos.PesoActualDepresion;
                relacionTratamientoMotivacion2.PesoActualPerdidas = datos.PesoActualPerdidas;
                relacionTratamientoMotivacion2.PesoActualMenopausia = datos.PesoActualMenopausia;
                relacionTratamientoMotivacion2.PesoActualOtros = datos.PesoActualOtros;
                relacionTratamientoMotivacion2.PesoActualOtrosTexto = datos.PesoActualOtrosTexto;
                relacionTratamientoMotivacion2.PesoNacer = datos.PesoNacer;
                relacionTratamientoMotivacion2.MaximoAdulto = datos.MaximoAdulto;
                relacionTratamientoMotivacion2.Minimo = datos.Minimo;
                relacionTratamientoMotivacion2.Edad = datos.Edad;
                relacionTratamientoMotivacion2.Deseado = datos.Deseado;
                relacionTratamientoMotivacion2.PesoEsta = datos.PesoEsta;
                relacionTratamientoMotivacion2.PesoComodo = datos.PesoComodo;


                model.SaveChanges();
                return Json("OK", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

        /*RELACION TRATAMIENTO MOTIVACION 3*/
        public ActionResult RelacionTratamientoMotivacion3()
        {
            ViewBag.Pagina = 4;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            crearRelacionTratamientoMotivacion3SiNoExiste(idUsuario);
            var relacionTratamientoMotivacion3 = getRelacionTramiteMotivacion3(idUsuario);
            return View(relacionTratamientoMotivacion3);
        }
        public ActionResult SaveRelacionTratamientoMotivacion3(RelacionTratamientoMotivacion3 datos)
        {
            try
            {
                var r = getRelacionTramiteMotivacion3(idUsuario);
                r.PesoNacer = datos.PesoNacer;
                r.MaximoAdulto = datos.MaximoAdulto;
                r.Minimo = datos.Minimo;
                r.Edad = datos.Edad;
                r.Deseado = datos.Deseado;
                r.PesoEsta = datos.PesoEsta;
                r.PesoComodo = datos.PesoComodo;
                r.CalidadVida = datos.CalidadVida;
                r.RelacionFamiliar = datos.RelacionFamiliar;
                r.VidaSocial = datos.VidaSocial;
                r.VidaPareja = datos.VidaPareja;
                r.VidaLaboral = datos.VidaLaboral;
                r.Economia = datos.Economia;
                r.Ridiculo = datos.Ridiculo;
                r.Asiento = datos.Asiento;
                r.Pasillos = datos.Pasillos;
                r.Sillas = datos.Sillas;
                r.GustariaSer = datos.GustariaSer;
                r.Ahora = datos.Ahora;
                r.Bnarse = datos.Bnarse;
                r.Vestirse = datos.Vestirse;
                r.ArreglarCasa = datos.ArreglarCasa;
                r.SubirEscaleras = datos.SubirEscaleras;
                r.CaminarCasa = datos.CaminarCasa;
                r.IrCompras = datos.IrCompras;
                r.CaminarFueraCasa = datos.CaminarFueraCasa;
                r.IrTrabajo = datos.IrTrabajo;
                r.AtarZapatos = datos.AtarZapatos;
                r.LevantarDeSilla = datos.LevantarDeSilla;
                r.LevarDeCama = datos.LevarDeCama;
                r.OtraDif = datos.OtraDif;

                model.SaveChanges();
                return Json("OK", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

        /* SU ESTADO CLINICO */

        public ActionResult SuEstadoClinico()
        {
            ViewBag.Pagina = 6;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;
            crearSuestadoClinicioSiNoExiste(idUsuario);
            var RelacionSuEstadoClinico = getSuEstadoClinico(idUsuario);
            return View(RelacionSuEstadoClinico);
        }

        public ActionResult SaveSuEstadoClinico(SuEstadoClinico datos)
        {
            try
            {
                var s = getSuEstadoClinico(idUsuario);
                s.SaludPeriodo = datos.SaludPeriodo;
                s.TuvoIntervenciones = datos.TuvoIntervenciones;
                s.MedicacionTomada = datos.MedicacionTomada;
                s.MedicacionActual = datos.MedicacionActual;
                s.DejariaMedicacion = datos.DejariaMedicacion;
                s.CausaTratamientoPs = datos.CausaTratamientoPs;
                s.DuracionTratamientoPs = datos.DuracionTratamientoPs;

                s.RadioMedicacionActual = datos.RadioMedicacionActual;
                s.RadioDejariaMedicacion = datos.RadioDejariaMedicacion;
                s.RadioTratamientoPs = datos.RadioTratamientoPs;

                s.PrimerM = datos.PrimerM;
                s.Ciclo = datos.Ciclo;
                s.UltimaM = datos.UltimaM;
                s.RadioEmbarazada = datos.RadioEmbarazada;
                s.TiempoEmbarazo = datos.TiempoEmbarazo;
                s.RadioAnticonceptivo = datos.RadioAnticonceptivo;
                s.MetodoUsado = datos.MetodoUsado;
                s.FechaUltimoP = datos.FechaUltimoP;
                s.RadioEstadoAnimico = datos.RadioEstadoAnimico;
                s.RadioDolores = datos.RadioDolores;
                s.FechaUltimaM = datos.FechaUltimaM;
                s.RadioVello = datos.RadioVello;
                s.FrecuenciaDep = datos.FrecuenciaDep;
                s.UltimoExamenPros = datos.UltimoExamenPros;
                s.Antigeno = datos.Antigeno;
                s.RadioColon = datos.RadioColon;
                s.ComentarEstudio = datos.ComentarEstudio;

                model.SaveChanges();
                return Json("OK", JsonRequestBehavior.AllowGet);
            }

            catch(Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
        }

        /* FIN SU ESTADO CLINICO */

        /* ANTECEDENTES FAMILIARES */
        public ActionResult AntecedentesFamiliares()
        {
            ViewBag.Pagina = 5;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var antecedentesFamiliares = new AntecedentesFamiliaresValidaciones(idUsuario).getDatosGuardados();
            return View(antecedentesFamiliares);
        }
        public ActionResult SaveAntecedentesFamiliares(AntecedentesFamiliares antecedentes)
        {
            try
            {
                new AntecedentesFamiliaresValidaciones(idUsuario).save(antecedentes);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        /* FIN ANTECEDENTES FAMILIARES FIN */
         
        /* SUS ALLEGADOS SU RELACION CON LA COMIDA(View Model SusHabitos2-SusAllegados...) */

        public ActionResult SusAllegadosSuRelacionConLaComida()
        {
            ViewBag.Pagina = 9;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var habitos2Allegados = new Habitos2AllegadosViewModelValidaciones(idUsuario).getDatosGuardados();
            return View(habitos2Allegados);
        }
        public ActionResult SaveSusAllegadosSuRelacionConLaComida(Habitos2AllegadosViewModel habitos2allegados)
        {
            if (habitos2allegados.habitos2 == null) habitos2allegados.habitos2 = new SusHabitos2();
            try
            {
                new Habitos2AllegadosViewModelValidaciones(idUsuario).save(habitos2allegados);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        /* FIN SUS ALLEGADOS SU RELACION CON LA COMIDA */

        /* SINTOMAS */
        public ActionResult Sintomas()
        {
            ViewBag.Pagina = 7;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new Sintomas1y2_ViewModelValidaciones(idUsuario).getDatos();
            return View(data);
        }
        public ActionResult SaveSintomas(Sintomas1y2_ViewModel sintomas)
        {
            try
            {
                new Sintomas1y2_ViewModelValidaciones(idUsuario).save(sintomas);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        /* FIN SINTOMAS FIN */


        /* SINTOMAS 2 */
        //public ActionResult Sintomas2()
        //{
        //    ViewBag.Pagina = 10;
        //    ViewBag.EsConsejo = false;
        //    ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

        //    var data = new Sintomas2Validaciones(idUsuario).getDatosGuardados();
        //    return View(data);
        //}
        //public ActionResult SaveSintomas2(Sintomas2 sintomas)
        //{
        //    try
        //    {
        //        new Sintomas2Validaciones(idUsuario).save(sintomas);
        //    }
        //    catch (Exception e)
        //    {
        //        return Json("Fallo", JsonRequestBehavior.AllowGet);
        //    }
        //    return Json("OK", JsonRequestBehavior.AllowGet);
        //}
        /* FIN SINTOMAS 2 FIN */

        /* SINTOMAS 3 */
        
        public ActionResult Sintomas3()
        {
            ViewBag.Pagina = 8;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;
            
            var data = new SintomasHabitosValidaciones(idUsuario).getDatos();
            return View(data);
        }
        public ActionResult SaveSintomas3(EstadoClinico_HabitosViewModel sintHab)
        {
            try
            {
                new SintomasHabitosValidaciones(idUsuario).save(sintHab);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        /* FIN SINTOMAS 3 FIN */
        
        /* ALIMENTACION */
        public ActionResult Alimentacion()
        {
            ViewBag.Pagina = 12;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new Preferencias2AlimentacionViewModelValidaciones(idUsuario).getDatos();
            return View(data);
        }
        public ActionResult SaveAlimentacion(Preferencias2AlimentacionViewModel sintomasPreferencias)
        {
            if (sintomasPreferencias.preferencias == null) sintomasPreferencias.preferencias = new Preferencias2();
            try
            {
                new Preferencias2AlimentacionViewModelValidaciones(idUsuario).save(sintomasPreferencias);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        /* FIN ALIMENTACION FIN */


        /* PREFERENCIAS */

        public ActionResult Preferencias()
        {
            ViewBag.Pagina = 10;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new SusAlleRelacionComidaPreferenciasViewModelValidaciones(idUsuario).getDatos();
            return View(data);
        }

        public ActionResult SavePreferencias(SusAllegadosRelacComPreferenciasViewModel relacionpreferencias)
        {
            try
            {
                new SusAlleRelacionComidaPreferenciasViewModelValidaciones(idUsuario).save(relacionpreferencias);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        /* FIN PREFERENCIAS */

        /* ClasificacionAlimentacion */

        public ActionResult ClasificacionAlimentacion()
        {
            ViewBag.Pagina = 15;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new ClasificacionAlimentacion1_2_3ViewModelValidaciones(idUsuario).getDatosGuardados();
            return View(data);
        }

        public ActionResult SaveClasificacionAlimentacion(ClasificacionAlimentacion1_2_3ViewModel ClasificacionAlimentacion)
        {
            if (ClasificacionAlimentacion.alimen1 == null) { ClasificacionAlimentacion.alimen1 = new ClasificacionAlimentacion(); }
            if (ClasificacionAlimentacion.alimen2 == null){ ClasificacionAlimentacion.alimen2 = new ClasificacionAlimentacion2();}
            if (ClasificacionAlimentacion.alimen3 == null) {ClasificacionAlimentacion.alimen3 = new ClasificacionAlimentacion3();}
            try
            {
                new ClasificacionAlimentacion1_2_3ViewModelValidaciones(idUsuario).save(ClasificacionAlimentacion);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        /* FIN ClasificacionAlimentacion */

        /* ClasificacionAlimentacion2 */

        //public ActionResult ClasificacionAlimentacion2()
        //{
        //    ViewBag.Pagina = 20;
        //    ViewBag.EsConsejo = false;
        //    ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

        //    var data = new ClasificacionAlimentacion2Validaciones(idUsuario).getDatosGuardados();
        //    return View(data);
        //}

        //public ActionResult SaveClasificacionAlimentacion2(ClasificacionAlimentacion2 ClasificacionAlimentacion2)
        //{
        //    try
        //    {
        //        new ClasificacionAlimentacion2Validaciones(idUsuario).save(ClasificacionAlimentacion2);
        //    }
        //    catch (Exception e)
        //    {
        //        return Json("Fallo", JsonRequestBehavior.AllowGet);
        //    }
        //    return Json("OK", JsonRequestBehavior.AllowGet);
        //}

        /* FIN ClasificacionAlimentacion2 */

        /* ClasificacionAlimentacion3 */

        public ActionResult ClasificacionAlimentacion3()
        {
            ViewBag.Pagina = 16;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new ClasificacionAlimentacion3_4_5_6ViewModelValidaciones(idUsuario).getDatosGuardados();
            return View(data);
        }

        public ActionResult SaveClasificacionAlimentacion3(ClasificacionAlimentacion3_4_5_6ViewModel ClasificacionAlimentacion3)
        {
            if (ClasificacionAlimentacion3.aliment3 == null) { ClasificacionAlimentacion3.aliment3 = new ClasificacionAlimentacion3(); }
            if (ClasificacionAlimentacion3.aliment4 == null) { ClasificacionAlimentacion3.aliment4 = new ClasificacionAlimentacion4(); }
            if (ClasificacionAlimentacion3.aliment5 == null) { ClasificacionAlimentacion3.aliment5 = new ClasificacionAlimentacion5(); }
            if (ClasificacionAlimentacion3.aliment6 == null) { ClasificacionAlimentacion3.aliment6 = new ClasificacionAlimentacion6(); }
            try
            {
                new ClasificacionAlimentacion3_4_5_6ViewModelValidaciones(idUsuario).save(ClasificacionAlimentacion3);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        /* FIN ClasificacionAlimentacion3 */

        /* ClasificacionAlimentacion4 */

        //public ActionResult ClasificacionAlimentacion4()
        //{
        //    ViewBag.Pagina = 22;
        //    ViewBag.EsConsejo = false;
        //    ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

        //    var data = new ClasificacionAlimentacion4Validaciones(idUsuario).getDatosGuardados();
        //    return View(data);
        //}

        //public ActionResult SaveClasificacionAlimentacion4(ClasificacionAlimentacion4 ClasificacionAlimentacion4)
        //{
        //    try
        //    {
        //        new ClasificacionAlimentacion4Validaciones(idUsuario).save(ClasificacionAlimentacion4);
        //    }
        //    catch (Exception e)
        //    {
        //        return Json("Fallo", JsonRequestBehavior.AllowGet);
        //    }
        //    return Json("OK", JsonRequestBehavior.AllowGet);
        //}

        ///* FIN ClasificacionAlimentacion4 */

        ///* ClasificacionAlimentacion5 */

        //public ActionResult ClasificacionAlimentacion5()
        //{
        //    ViewBag.Pagina = 23;
        //    ViewBag.EsConsejo = false;
        //    ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

        //    var data = new ClasificacionAlimentacion5Validaciones(idUsuario).getDatosGuardados();
        //    return View(data);
        //}

        //public ActionResult SaveClasificacionAlimentacion5(ClasificacionAlimentacion5 ClasificacionAlimentacion5)
        //{
        //    try
        //    {
        //        new ClasificacionAlimentacion5Validaciones(idUsuario).save(ClasificacionAlimentacion5);
        //    }
        //    catch (Exception e)
        //    {
        //        return Json("Fallo", JsonRequestBehavior.AllowGet);
        //    }
        //    return Json("OK", JsonRequestBehavior.AllowGet);
        //}

        ///* FIN ClasificacionAlimentacion5 */

        ///* ClasificacionAlimentacion6 */

        //public ActionResult ClasificacionAlimentacion6()
        //{
        //    ViewBag.Pagina = 24;
        //    ViewBag.EsConsejo = false;
        //    ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

        //    var data = new ClasificacionAlimentacion6Validaciones(idUsuario).getDatosGuardados();
        //    return View(data);
        //}

        //public ActionResult SaveClasificacionAlimentacion6(ClasificacionAlimentacion6 ClasificacionAlimentacion6)
        //{
        //    try
        //    {
        //        new ClasificacionAlimentacion6Validaciones(idUsuario).save(ClasificacionAlimentacion6);
        //    }
        //    catch (Exception e)
        //    {
        //        return Json("Fallo", JsonRequestBehavior.AllowGet);
        //    }
        //    return Json("OK", JsonRequestBehavior.AllowGet);
        //}

        ///* FIN ClasificacionAlimentacion6 */

        /* PREFERENCIAS 2 */

        public ActionResult Preferencias2()
        {
            ViewBag.Pagina = 11;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new Preferencias2Validaciones(idUsuario).getDatosGuardados();
            return View(data);
        }

        public ActionResult savePreferencias2(Preferencias2 preferencias)
        {
            try
            {
                new Preferencias2Validaciones(idUsuario).save(preferencias);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }


        /* FIN PREFERENCIAS 2 */

        /* COME DIA TIPICO Y FINDE */

        public ActionResult ComeDiaTipicoYFinde()
        {
            ViewBag.Pagina = 13;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new ComeDiaTipicoYFindeValidaciones(idUsuario).getDatosGuardados();
            return View(data);
        }
        public ActionResult saveComeDiaTipicoYFinde(ComeDiaTipicoYFinde comeDiaTipico)
        {
            try
            {
                new ComeDiaTipicoYFindeValidaciones(idUsuario).save(comeDiaTipico);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }


        /* FIN COME DIA TIPICO Y FINDE */

        /* COME DIA TIPICO Y FINDE DOS */

        public ActionResult ComeDiaTipicoYFinde2()
        {
            ViewBag.Pagina = 14;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new ComeDiaTipicoYFinde2Validaciones(idUsuario).getdatosGuardados();
            return View(data);
        }

        public ActionResult saveComeDiaTipicoYFinde2(ComeDiaTipicoYFinde2 comediaTipico)
        {
            try
            {
                new ComeDiaTipicoYFinde2Validaciones(idUsuario).save(comediaTipico);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }

        /* FIN COME DIA TIPICO Y FINDE DOS */

       

        /* COMENTARIO GENERAL */
        public ActionResult ComentarioGeneral()
        {
            ViewBag.Pagina = 18;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new ComentarioGeneralValidaciones(idUsuario).getDatosGuardados();
            return View(data);
        }
        public ActionResult saveComentarioGeneral(ComentarioGeneral comentarioGeneral)
        {
            try
            {
                new ComentarioGeneralValidaciones(idUsuario).save(comentarioGeneral);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        /* FIN COMENTARIO GENERAL FIN */

        public ActionResult EnvioFormulario()
        {
            var usuario = model.Usuario.Where(u => u.Id == idUsuario).First();
            usuario.Formulario = true;
            model.SaveChanges();
            return RedirectToAction("ComentarioGeneral", "Pasos");
        }




        private int? parsearIntPositivo(int? nInt)
        {
            return nInt.HasValue && nInt.Value >= 0? nInt : null;
        }

        private Consejo getConsejo(int id)
        {
            return model.Consejo.Where(c => c.IdPaso == id).First();
        }

        private DatosPersonales getDatosPersonalesUsuario(int idUsuario)
        {
            return model.DatosPersonales.Where(dp => dp.Usuario.Id == idUsuario)
                            .OrderByDescending(dp => dp.Id)
                                .First();
        }

        private RelacionTratamientoMotivacion getRelacionTramiteMotivacion(int idUsuario)
        {
            return model.RelacionTratamientoMotivacion.Where(rtm => rtm.Usuario.Id == idUsuario)
                            .OrderByDescending(rmt => rmt.Id)
                                .First();
        }

        private RelacionTratamientoMotivacion2 getRelacionTramiteMotivacion2(int idUsuario)
        {
            return model.RelacionTratamientoMotivacion2.Where(rtm => rtm.Usuario.Id == idUsuario)
                            .OrderByDescending(rmt => rmt.Id)
                                .First();
        }

        private RelacionTratamientoMotivacion3 getRelacionTramiteMotivacion3(int idUsuario)
        {
            return model.RelacionTratamientoMotivacion3.Where(rtm => rtm.Usuario.Id == idUsuario)
                            .OrderByDescending(rmt => rmt.Id)
                                .First();
        }

        private SuEstadoClinico getSuEstadoClinico(int idUsuario)
        {
            return model.SuEstadoClinico.Where(stc => stc.Usuario.Id == idUsuario)
                    .OrderByDescending(stc => stc.Id)
                        .First();
        }

        private void crearDatosPersonalesSiNoExiste(int idUsuario){
            var hayDatosPersonales = model.DatosPersonales.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
            if (!hayDatosPersonales)
            {
                var datosPersonales = new DatosPersonales()
                {
                    Usuario = getUsuario(idUsuario)
                };
                model.DatosPersonales.AddObject(datosPersonales);
                model.SaveChanges();
            }
        }

        private void crearRelacionTratamientoMotivacionSiNoExiste(int idUsuario)
        {
            var hayRelacionTratamientoMotivacion = 
                    model.RelacionTratamientoMotivacion.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
            if (!hayRelacionTratamientoMotivacion)
            {
                var relacionTramiteMotivacion = new RelacionTratamientoMotivacion()
                {
                    Usuario = getUsuario(idUsuario)
                };
                model.RelacionTratamientoMotivacion.AddObject(relacionTramiteMotivacion);
                model.SaveChanges();
            }
        }

        private void crearRelacionTratamientoMotivacion2SiNoExiste(int idUsuario)
        {
            var hayRelacionTratamientoMotivacion2 =
                    model.RelacionTratamientoMotivacion2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
            if (!hayRelacionTratamientoMotivacion2)
            {
                var relacionTramiteMotivacion2 = new RelacionTratamientoMotivacion2()
                {
                    Usuario = getUsuario(idUsuario)
                };
                model.RelacionTratamientoMotivacion2.AddObject(relacionTramiteMotivacion2);
                model.SaveChanges();
            }
        }

        private void crearRelacionTratamientoMotivacion3SiNoExiste(int idUsuario)
        {
            var hayRelacionTratamientoMotivacion3 =
                    model.RelacionTratamientoMotivacion3.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
            if (!hayRelacionTratamientoMotivacion3)
            {
                var relacionTramiteMotivacion3 = new RelacionTratamientoMotivacion3()
                {
                    Usuario = getUsuario(idUsuario)
                };
                model.RelacionTratamientoMotivacion3.AddObject(relacionTramiteMotivacion3);
                model.SaveChanges();
            }
        }

        private void crearSuestadoClinicioSiNoExiste(int idUsuario)
        {
            var haySuEstadoClinico =
                    model.SuEstadoClinico.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
            if (!haySuEstadoClinico)
            {
                var SuEstadoClinico = new SuEstadoClinico()
                {
                    Usuario = getUsuario(idUsuario)
                };
                model.SuEstadoClinico.AddObject(SuEstadoClinico);
                model.SaveChanges();
            }
        }

        private Usuario getUsuario(int idUsuario)
        {   
            return model.Usuario.Where(u => u.Id == idUsuario).First();
         
        }

        //#region Habitos
        //public ActionResult SusHabitos()
        //{
        //    ViewBag.Pagina = 12;
        //    ViewBag.EsConsejo = false;
        //    ViewBag.NombreyApellido = getDatosPersonalesUsuario(Convert.ToInt32(Session["IdUsuario"])).NombreyApellido;
        //    var id_user = Convert.ToInt32 (Session["IdUsuario"]);
        //    var habitos = new HabitosChild().getHabitos(id_user);
        //    return View(habitos);
        //}

        //public string CreateHabitos(HistoriaPersonalCormillot.Habitos h)
        //{
        //    h.IdUsuario = Convert.ToInt32(Session["IdUsuario"]);
        //    if (new HabitosChild().save(h))
        //    {
        //        return "OK";
        //    }
        //    else
        //    {
        //        return "ERROR";
        //    }
        //}
        //#endregion


        #region Actividad Fisica
        /* ACTIVIDAD FISICA */
        public ActionResult ActividadFisica()
        {
            ViewBag.Pagina = 17;
            ViewBag.EsConsejo = false;
            ViewBag.NombreyApellido = getDatosPersonalesUsuario(idUsuario).NombreyApellido;

            var data = new ActividadFisicaValidaciones(idUsuario).getDatosGuardados();
            return View(data);
        }

        public ActionResult saveActividadFisica(ActividadFisica activdad)
        {
           
            try
            {
                new ActividadFisicaValidaciones(idUsuario).save(activdad);
            }
            catch (Exception e)
            {
                return Json("Fallo", JsonRequestBehavior.AllowGet);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        
        }
        /* FIN ACTIVIDAD FISICA */
        #endregion


    }
}
