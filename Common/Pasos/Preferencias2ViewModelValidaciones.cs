using System.Linq;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;

    public class Preferencias2ViewModelValidaciones:PasosValidaciones
    {private int idUsuario;

    public Preferencias2ViewModelValidaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(Preferencias2ViewModel datos)
    {
        var datosGuardados = getDatos();
        datosGuardados.preferencias.RadioComo = datos.preferencias.RadioComo;
        datosGuardados.preferencias.RadioMisBocados = datos.preferencias.RadioMisBocados;
        datosGuardados.preferencias.RadioVelocidad = datos.preferencias.RadioVelocidad;
        datosGuardados.preferencias.RadioMastico = datos.preferencias.RadioMastico;
        datosGuardados.preferencias.RadioSaboreo = datos.preferencias.RadioSaboreo;
        datosGuardados.preferencias.Horario0a6 = datos.preferencias.Horario0a6;
        datosGuardados.preferencias.Horario12a16 = datos.preferencias.Horario12a16;
        datosGuardados.preferencias.Horario20a22 = datos.preferencias.Horario20a22;
        datosGuardados.preferencias.Horario22a24 = datos.preferencias.Horario22a24;
        datosGuardados.preferencias.Horario6a12 = datos.preferencias.Horario6a12;
        datosGuardados.preferencias.ViernesDesayuno = datos.preferencias.ViernesDesayuno;
        datosGuardados.preferencias.ViernesAlmuerzo = datos.preferencias.ViernesAlmuerzo;
        datosGuardados.preferencias.ViernesMerienda = datos.preferencias.ViernesMerienda;
        datosGuardados.preferencias.ViernesCena = datos.preferencias.ViernesCena;
        datosGuardados.preferencias.SabadoDesayuno = datos.preferencias.SabadoDesayuno;
        datosGuardados.preferencias.SabadoAlmuerzo = datos.preferencias.SabadoAlmuerzo;
        datosGuardados.preferencias.SabadoMerienda = datos.preferencias.SabadoMerienda;
        datosGuardados.preferencias.SabadoCena = datos.preferencias.SabadoCena;
        datosGuardados.preferencias.DomingoDesayuno = datos.preferencias.DomingoDesayuno;
        datosGuardados.preferencias.DomingoAlmuerzo = datos.preferencias.DomingoAlmuerzo;
        datosGuardados.preferencias.DomingoMerienda = datos.preferencias.DomingoMerienda;
        datosGuardados.preferencias.DomingoCena = datos.preferencias.DomingoCena;
        datosGuardados.preferencias.ComoMasSolo = datos.preferencias.ComoMasSolo;
        datosGuardados.preferencias.ComoMasEnFlia = datos.preferencias.ComoMasEnFlia;
        datosGuardados.preferencias.ComoMasConAmigos = datos.preferencias.ComoMasConAmigos;
        datosGuardados.preferencias.ComoMasEnFiestas = datos.preferencias.ComoMasEnFiestas;
        datosGuardados.preferencias.ComoMasEnPareja = datos.preferencias.ComoMasEnPareja;
        datosGuardados.preferencias.MientrasCocino = datos.preferencias.MientrasCocino;
        datosGuardados.preferencias.MientrasTvOCompu = datos.preferencias.MientrasTvOCompu;
        datosGuardados.preferencias.ComerMasConAmigos = datos.preferencias.ComerMasConAmigos;
        datosGuardados.preferencias.ComerMasEnFamilia = datos.preferencias.ComerMasEnFamilia;
        datosGuardados.preferencias.ComerMasEnFiestas = datos.preferencias.ComerMasEnFiestas;
        datosGuardados.preferencias.ComerMasEnPareja = datos.preferencias.ComerMasEnPareja;
        datosGuardados.preferencias.ComerMasSolo = datos.preferencias.ComerMasSolo;
        datosGuardados.preferencias.ComerMientrasCocino = datos.preferencias.ComerMientrasCocino;
        datosGuardados.preferencias.ComerMientrasTvoCompu = datos.preferencias.ComerMientrasTvoCompu;

        model.SaveChanges();
    }


    public Preferencias2ViewModel getDatos()
    {
        crearDatosSiNoExisten();
        var preferencias = new Preferencias2ViewModel();
        preferencias.preferencias = model.Preferencias2.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                    .First();

        return preferencias;

    }
    public void crearDatosSiNoExisten()
    {
        var hayDatos = 
            model.Preferencias2.Where(p => p.Usuario.Id == idUsuario).Count() > 0;
        if(!hayDatos)
        {
            var preferencias = new Preferencias2()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.Preferencias2.AddObject(preferencias);
            model.SaveChanges();
        }
    }

    }
