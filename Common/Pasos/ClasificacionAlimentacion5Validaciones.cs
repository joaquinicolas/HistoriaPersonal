using HistoriaPersonalCormillot;
using System.Linq;

public class ClasificacionAlimentacion5Validaciones: PasosValidaciones
{
    private int idUsuario;

    public ClasificacionAlimentacion5Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ClasificacionAlimentacion5 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.Naranja = datosNuevos.Naranja;
        datosGuardados.Pera = datosNuevos.Pera;
        datosGuardados.Pomelo = datosNuevos.Pomelo;
        datosGuardados.Sandía = datosNuevos.Sandía;
        datosGuardados.Uva = datosNuevos.Uva;

        datosGuardados.EnvasadosAnana = datosNuevos.EnvasadosAnana;
        datosGuardados.EnvasadosDuraznos = datosNuevos.EnvasadosDuraznos;
        datosGuardados.EnvasadosEnsaladaFrutas = datosNuevos.EnvasadosEnsaladaFrutas;
        datosGuardados.EnvasadosPeras = datosNuevos.EnvasadosPeras;

        datosGuardados.DeshidratasCiruela = datosNuevos.DeshidratasCiruela;
        datosGuardados.DeshidratasDamasco = datosNuevos.DeshidratasDamasco;
        datosGuardados.DeshidratasManzana = datosNuevos.DeshidratasManzana;
        datosGuardados.DeshidratasOrejones = datosNuevos.DeshidratasOrejones;
        datosGuardados.DeshidratasPasasDeUva = datosNuevos.DeshidratasPasasDeUva;

        datosGuardados.Almendras = datosNuevos.Almendras;
        datosGuardados.Avellanas = datosNuevos.Avellanas;
        datosGuardados.Manies = datosNuevos.Manies;
        datosGuardados.Nueces = datosNuevos.Nueces;

        datosGuardados.Aceite = datosNuevos.Aceite;
        datosGuardados.Manteca = datosNuevos.Manteca;

        datosGuardados.ArrrozConLeche = datosNuevos.ArrrozConLeche;
        datosGuardados.Flan = datosNuevos.Flan;
        datosGuardados.Gelatina = datosNuevos.Gelatina;
        datosGuardados.Helado = datosNuevos.Helado;
        datosGuardados.Mousse = datosNuevos.Mousse;
        datosGuardados.PostresDeLeche = datosNuevos.PostresDeLeche;

        datosGuardados.Alfajores = datosNuevos.Alfajores;
        datosGuardados.BudinPan = datosNuevos.BudinPan;
        datosGuardados.Budines = datosNuevos.Budines;
        datosGuardados.Chocolates = datosNuevos.Chocolates;
        datosGuardados.CremaChantilly = datosNuevos.CremaChantilly;
        datosGuardados.DulceBatata = datosNuevos.DulceBatata;

        model.SaveChanges();
    }

    public ClasificacionAlimentacion5 getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ClasificacionAlimentacion5.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ClasificacionAlimentacion5.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ClasificacionAlimentacion5()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ClasificacionAlimentacion5.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}