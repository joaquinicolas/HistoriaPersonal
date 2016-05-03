using HistoriaPersonalCormillot;
using System.Linq;

public class ClasificacionAlimentacion4Validaciones: PasosValidaciones
{
    private int idUsuario;

    public ClasificacionAlimentacion4Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ClasificacionAlimentacion4 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.PastasRellenas = datosNuevos.PastasRellenas;
        datosGuardados.PastasSimples = datosNuevos.PastasSimples;
        datosGuardados.Pochoclo = datosNuevos.Pochoclo;
        datosGuardados.Polenta = datosNuevos.Polenta;
        datosGuardados.TrigoInflado = datosNuevos.TrigoInflado;
        datosGuardados.Empanadas = datosNuevos.Empanadas;
        datosGuardados.Pizza = datosNuevos.Pizza;
        datosGuardados.Sandwiches = datosNuevos.Sandwiches;

        datosGuardados.CremaDeLeche = datosNuevos.CremaDeLeche;
        datosGuardados.Ketchup = datosNuevos.Ketchup;
        datosGuardados.Mayonesa = datosNuevos.Mayonesa;
        datosGuardados.Mostaza = datosNuevos.Mostaza;
        datosGuardados.SalsaBlanca = datosNuevos.SalsaBlanca;
        datosGuardados.SalsaBoloniesa = datosNuevos.SalsaBoloniesa;
        datosGuardados.SalsaCuatroQuesos = datosNuevos.SalsaCuatroQuesos;
        datosGuardados.SalsaSoja = datosNuevos.SalsaSoja;
        datosGuardados.SalsaTomate = datosNuevos.SalsaTomate;
        datosGuardados.SalsaGolf = datosNuevos.SalsaGolf;

        datosGuardados.Aceitunas = datosNuevos.Aceitunas;
        datosGuardados.Ajies = datosNuevos.Ajies;
        datosGuardados.Cebollitas = datosNuevos.Cebollitas;
        datosGuardados.Pepinitos = datosNuevos.Pepinitos;
        datosGuardados.Pickles = datosNuevos.Pickles;

        datosGuardados.Anana = datosNuevos.Anana;
        datosGuardados.Banana = datosNuevos.Banana;
        datosGuardados.Cereza = datosNuevos.Cereza;
        datosGuardados.Ciruela = datosNuevos.Ciruela;
        datosGuardados.Damasco = datosNuevos.Damasco;
        datosGuardados.Durazno = datosNuevos.Durazno;
        datosGuardados.Frutilla = datosNuevos.Frutilla;
        datosGuardados.Kiwi = datosNuevos.Kiwi;
        datosGuardados.Mandarina = datosNuevos.Mandarina;
        datosGuardados.Manzana = datosNuevos.Manzana;
        datosGuardados.Melon = datosNuevos.Melon;

        model.SaveChanges();
    }

    public ClasificacionAlimentacion4 getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ClasificacionAlimentacion4.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ClasificacionAlimentacion4.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ClasificacionAlimentacion4()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ClasificacionAlimentacion4.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}