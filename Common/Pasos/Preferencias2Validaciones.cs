using HistoriaPersonalCormillot;
using System.Linq;



public class Preferencias2Validaciones : PasosValidaciones
{
    private int idUsuario;

    public Preferencias2Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(Preferencias2 datos)
    {
        var datosGuardados = getDatosGuardados();
        datosGuardados.RadioComo = datos.RadioComo;
        datosGuardados.RadioMisBocados = datos.RadioMisBocados;
        datosGuardados.RadioVelocidad = datos.RadioVelocidad;
        datosGuardados.RadioMastico = datos.RadioMastico;
        datosGuardados.RadioSaboreo = datos.RadioSaboreo;
        datosGuardados.Horario0a6 = datos.Horario0a6;
        datosGuardados.Horario12a16 = datos.Horario12a16;
        datosGuardados.Horario20a22 = datos.Horario20a22;
        datosGuardados.Horario22a24 = datos.Horario22a24;
        datosGuardados.Horario6a12 = datos.Horario6a12;
        datosGuardados.ViernesDesayuno = datos.ViernesDesayuno;
        datosGuardados.ViernesAlmuerzo = datos.ViernesAlmuerzo;
        datosGuardados.ViernesMerienda = datos.ViernesMerienda;
        datosGuardados.ViernesCena = datos.ViernesCena;
        datosGuardados.SabadoDesayuno = datos.SabadoDesayuno;
        datosGuardados.SabadoAlmuerzo = datos.SabadoAlmuerzo;
        datosGuardados.SabadoMerienda = datos.SabadoMerienda;
        datosGuardados.SabadoCena = datos.SabadoCena;
        datosGuardados.DomingoDesayuno = datos.DomingoDesayuno;
        datosGuardados.DomingoAlmuerzo = datos.DomingoAlmuerzo;
        datosGuardados.DomingoMerienda = datos.DomingoMerienda;
        datosGuardados.DomingoCena = datos.DomingoCena;
        datosGuardados.ComoMasSolo = datos.ComoMasSolo;
        datosGuardados.ComoMasEnFlia = datos.ComoMasEnFlia;
        datosGuardados.ComoMasConAmigos = datos.ComoMasConAmigos;
        datosGuardados.ComoMasEnFiestas = datos.ComoMasEnFiestas;
        datosGuardados.ComoMasEnPareja = datos.ComoMasEnPareja;
        datosGuardados.MientrasCocino = datos.MientrasCocino;
        datosGuardados.MientrasTvOCompu = datos.MientrasTvOCompu;
        //datosGuardados.LugarCasa = datos.LugarCasa;
        //datosGuardados.LugarColegio = datos.LugarColegio;
        //datosGuardados.LugarTrabajo = datos.LugarTrabajo;
        //datosGuardados.LugarTraslados = datos.LugarTraslados;
        //datosGuardados.LugarRestaurante = datos.LugarRestaurante;
        //datosGuardados.LugarKiosko = datos.LugarKiosko;
        //datosGuardados.LugarCalle = datos.LugarCalle;
        //datosGuardados.LugarViaje = datos.LugarViaje;
        //datosGuardados.LugarVacaciones = datos.LugarVacaciones;
        //datosGuardados.LugarClub = datos.LugarClub;
        datosGuardados.ComerMasConAmigos = datos.ComerMasConAmigos;
        datosGuardados.ComerMasEnFamilia = datos.ComerMasEnFamilia;
        datosGuardados.ComerMasEnFiestas = datos.ComerMasEnFiestas;
        datosGuardados.ComerMasEnPareja = datos.ComerMasEnPareja;
        datosGuardados.ComerMasSolo = datos.ComerMasSolo;
        datosGuardados.ComerMientrasCocino = datos.ComerMientrasCocino;
        datosGuardados.ComerMientrasTvoCompu = datos.ComerMientrasTvoCompu;

        model.SaveChanges();
    }

    public Preferencias2 getDatosGuardados()
    {
        crearDatosSiNoExisten();
        return model.Preferencias2.Where(p => p.Usuario.Id == idUsuario)
                .OrderBy(p => p.Id)
                    .First();
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
