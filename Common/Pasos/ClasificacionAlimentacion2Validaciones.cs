using HistoriaPersonalCormillot;
using System.Linq;

public class ClasificacionAlimentacion2Validaciones: PasosValidaciones
{
    private int idUsuario;

    public ClasificacionAlimentacion2Validaciones(int idUsuario)
    {
        this.idUsuario = idUsuario;
    }

    public void save(ClasificacionAlimentacion2 datosNuevos)
    {
        var datosGuardados = getDatosGuardados();

        datosGuardados.MarFrescos = datosNuevos.MarFrescos;
        datosGuardados.RioFrescos = datosNuevos.RioFrescos;
        datosGuardados.Envasados = datosNuevos.Envasados;
        datosGuardados.Kanikama = datosNuevos.Kanikama;
        datosGuardados.Mariscos = datosNuevos.Mariscos;
        datosGuardados.Sushi = datosNuevos.Sushi;
        
        datosGuardados.Pavita = datosNuevos.Pavita;
        datosGuardados.Pollo = datosNuevos.Pollo;
        
        datosGuardados.HuevosDuros = datosNuevos.HuevosDuros;
        datosGuardados.HuevosFritos = datosNuevos.HuevosFritos;

        datosGuardados.Acelga = datosNuevos.Acelga;
        datosGuardados.Ajo = datosNuevos.Ajo;
        datosGuardados.Alcaucil = datosNuevos.Alcaucil;
        datosGuardados.Apio = datosNuevos.Apio;
        datosGuardados.Batata = datosNuevos.Batata;

        datosGuardados.Berenjena = datosNuevos.Berenjena;
        datosGuardados.Berro = datosNuevos.Berro;
        datosGuardados.Brocoli = datosNuevos.Brocoli;
        datosGuardados.Calabaza = datosNuevos.Calabaza;
        datosGuardados.Cebolla = datosNuevos.Cebolla;
        datosGuardados.Champiñones = datosNuevos.Champiñones;
        datosGuardados.Choclo = datosNuevos.Choclo;
        datosGuardados.Coliflor = datosNuevos.Coliflor;
        datosGuardados.Esparragos = datosNuevos.Esparragos;
        datosGuardados.Espinaca = datosNuevos.Espinaca;
        datosGuardados.Lechuga = datosNuevos.Lechuga;
        datosGuardados.Palmitos = datosNuevos.Palmitos;
        datosGuardados.Plata = datosNuevos.Plata;
        datosGuardados.Papa = datosNuevos.Papa;
        datosGuardados.Pepino = datosNuevos.Pepino;
        datosGuardados.Pimiento = datosNuevos.Pimiento;
        datosGuardados.Radicheta = datosNuevos.Radicheta;
        datosGuardados.Remolacha = datosNuevos.Remolacha;
        datosGuardados.Repollitos = datosNuevos.Repollitos;
        datosGuardados.Repollo = datosNuevos.Repollo;

        model.SaveChanges();
    }

    public ClasificacionAlimentacion2 getDatosGuardados()
    {
        crearDatosSiNoExiste();
        return model.ClasificacionAlimentacion2.Where(rtm => rtm.Usuario.Id == idUsuario)
                        .OrderByDescending(rmt => rmt.Id)
                            .First();
    }

    private void crearDatosSiNoExiste()
    {
        var hayDatos =
                model.ClasificacionAlimentacion2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        if (!hayDatos)
        {
            var antecedentes = new ClasificacionAlimentacion2()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.ClasificacionAlimentacion2.AddObject(antecedentes);
            model.SaveChanges();
        }
    }
}