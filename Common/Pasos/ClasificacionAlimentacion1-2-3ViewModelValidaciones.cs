using System.Linq;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;


    public class ClasificacionAlimentacion1_2_3ViewModelValidaciones:PasosValidaciones
    { 
          private int idUsuario;

          public ClasificacionAlimentacion1_2_3ViewModelValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }
          public void save(ClasificacionAlimentacion1_2_3ViewModel datosNuevos)
          {
              var datosGuardados = getDatosGuardados();

              //Clasificacion Alimentacion
              datosGuardados.alimen1.LecheDescremada = datosNuevos.alimen1.LecheDescremada;
              datosGuardados.alimen1.QuesoBlanco = datosNuevos.alimen1.QuesoBlanco;
              datosGuardados.alimen1.QuesoGruyere = datosNuevos.alimen1.QuesoGruyere;
              datosGuardados.alimen1.QuesoPortSalut = datosNuevos.alimen1.QuesoPortSalut;
              datosGuardados.alimen1.QuesoRoquefort = datosNuevos.alimen1.QuesoRoquefort;
              datosGuardados.alimen1.QuesoDuros = datosNuevos.alimen1.QuesoDuros;
              datosGuardados.alimen1.YofurtDescremado = datosNuevos.alimen1.YofurtDescremado;

              datosGuardados.alimen1.Amargos = datosNuevos.alimen1.Amargos;
              datosGuardados.alimen1.Soja = datosNuevos.alimen1.Soja;
              datosGuardados.alimen1.Cafe = datosNuevos.alimen1.Cafe;
              datosGuardados.alimen1.GaseosaLight = datosNuevos.alimen1.GaseosaLight;
              datosGuardados.alimen1.JugoLight = datosNuevos.alimen1.JugoLight;
              datosGuardados.alimen1.JugoNatural = datosNuevos.alimen1.JugoNatural;
              datosGuardados.alimen1.Chocolatada = datosNuevos.alimen1.Chocolatada;
              datosGuardados.alimen1.Cerveza = datosNuevos.alimen1.Cerveza;
              datosGuardados.alimen1.Champan = datosNuevos.alimen1.Champan;
              datosGuardados.alimen1.Vino = datosNuevos.alimen1.Vino;

              datosGuardados.alimen1.Fernet = datosNuevos.alimen1.Fernet;
              datosGuardados.alimen1.Tes = datosNuevos.alimen1.Tes;
              datosGuardados.alimen1.Sidra = datosNuevos.alimen1.Sidra;

              datosGuardados.alimen1.Cerdo = datosNuevos.alimen1.Cerdo;
              datosGuardados.alimen1.Chinchulin = datosNuevos.alimen1.Chinchulin;
              datosGuardados.alimen1.Chorizo = datosNuevos.alimen1.Chorizo;
              datosGuardados.alimen1.Fiambres = datosNuevos.alimen1.Fiambres;
              datosGuardados.alimen1.Higado = datosNuevos.alimen1.Higado;
              datosGuardados.alimen1.Molleja = datosNuevos.alimen1.Molleja;
              datosGuardados.alimen1.Morcilla = datosNuevos.alimen1.Morcilla;
              datosGuardados.alimen1.Salchichas = datosNuevos.alimen1.Salchichas;
              datosGuardados.alimen1.Rinion = datosNuevos.alimen1.Rinion;
              datosGuardados.alimen1.Vacuna = datosNuevos.alimen1.Vacuna;
              datosGuardados.alimen1.Albondigas = datosNuevos.alimen1.Albondigas;
              datosGuardados.alimen1.Asado = datosNuevos.alimen1.Asado;
              datosGuardados.alimen1.CarneHorno = datosNuevos.alimen1.CarneHorno;
              datosGuardados.alimen1.Hamburguesas = datosNuevos.alimen1.Hamburguesas;
              datosGuardados.alimen1.Milanesas = datosNuevos.alimen1.Milanesas;

              //Clasificacion Alimentacion2

              datosGuardados.alimen2.MarFrescos = datosNuevos.alimen2.MarFrescos;
              datosGuardados.alimen2.RioFrescos = datosNuevos.alimen2.RioFrescos;
              datosGuardados.alimen2.Envasados = datosNuevos.alimen2.Envasados;
              datosGuardados.alimen2.Kanikama = datosNuevos.alimen2.Kanikama;
              datosGuardados.alimen2.Mariscos = datosNuevos.alimen2.Mariscos;
              datosGuardados.alimen2.Sushi = datosNuevos.alimen2.Sushi;

              datosGuardados.alimen2.Pavita = datosNuevos.alimen2.Pavita;
              datosGuardados.alimen2.Pollo = datosNuevos.alimen2.Pollo;

              datosGuardados.alimen2.HuevosDuros = datosNuevos.alimen2.HuevosDuros;
              datosGuardados.alimen2.HuevosFritos = datosNuevos.alimen2.HuevosFritos;

              datosGuardados.alimen2.Acelga = datosNuevos.alimen2.Acelga;
              datosGuardados.alimen2.Ajo = datosNuevos.alimen2.Ajo;
              datosGuardados.alimen2.Alcaucil = datosNuevos.alimen2.Alcaucil;
              datosGuardados.alimen2.Apio = datosNuevos.alimen2.Apio;
              datosGuardados.alimen2.Batata = datosNuevos.alimen2.Batata;

              datosGuardados.alimen2.Berenjena = datosNuevos.alimen2.Berenjena;
              datosGuardados.alimen2.Berro = datosNuevos.alimen2.Berro;
              datosGuardados.alimen2.Brocoli = datosNuevos.alimen2.Brocoli;
              datosGuardados.alimen2.Calabaza = datosNuevos.alimen2.Calabaza;
              datosGuardados.alimen2.Cebolla = datosNuevos.alimen2.Cebolla;
              datosGuardados.alimen2.Champiñones = datosNuevos.alimen2.Champiñones;
              datosGuardados.alimen2.Choclo = datosNuevos.alimen2.Choclo;
              datosGuardados.alimen2.Coliflor = datosNuevos.alimen2.Coliflor;
              datosGuardados.alimen2.Esparragos = datosNuevos.alimen2.Esparragos;
              datosGuardados.alimen2.Espinaca = datosNuevos.alimen2.Espinaca;
              datosGuardados.alimen2.Lechuga = datosNuevos.alimen2.Lechuga;
              datosGuardados.alimen2.Palmitos = datosNuevos.alimen2.Palmitos;
              datosGuardados.alimen2.Plata = datosNuevos.alimen2.Plata;
              datosGuardados.alimen2.Papa = datosNuevos.alimen2.Papa;
              datosGuardados.alimen2.Pepino = datosNuevos.alimen2.Pepino;
              datosGuardados.alimen2.Pimiento = datosNuevos.alimen2.Pimiento;
              datosGuardados.alimen2.Radicheta = datosNuevos.alimen2.Radicheta;
              datosGuardados.alimen2.Remolacha = datosNuevos.alimen2.Remolacha;
              datosGuardados.alimen2.Repollitos = datosNuevos.alimen2.Repollitos;
              datosGuardados.alimen2.Repollo = datosNuevos.alimen2.Repollo;

              //////Clasificacion Alimentacion3

              datosGuardados.alimen3.Rucula = datosNuevos.alimen3.Rucula;
              datosGuardados.alimen3.Tomate = datosNuevos.alimen3.Tomate;
              datosGuardados.alimen3.TomateCherry = datosNuevos.alimen3.TomateCherry;
              datosGuardados.alimen3.Zanahoria = datosNuevos.alimen3.Zanahoria;
              datosGuardados.alimen3.Zapallito = datosNuevos.alimen3.Zapallito;
              datosGuardados.alimen3.Zapallo = datosNuevos.alimen3.Zapallo;
              datosGuardados.alimen3.Cazuelas = datosNuevos.alimen3.Cazuelas;
              datosGuardados.alimen3.PapasFritas = datosNuevos.alimen3.PapasFritas;
              datosGuardados.alimen3.PapasHorno = datosNuevos.alimen3.PapasHorno;
              datosGuardados.alimen3.Pure = datosNuevos.alimen3.Pure;
              datosGuardados.alimen3.Revueltos = datosNuevos.alimen3.Revueltos;
              datosGuardados.alimen3.Sopas = datosNuevos.alimen3.Sopas;
              datosGuardados.alimen3.Tartas = datosNuevos.alimen3.Tartas;
              datosGuardados.alimen3.Tortillas = datosNuevos.alimen3.Tortillas;
              datosGuardados.alimen3.VegetalesRellenos = datosNuevos.alimen3.VegetalesRellenos;

              datosGuardados.alimen3.Arvejas = datosNuevos.alimen3.Arvejas;
              datosGuardados.alimen3.Chauchas = datosNuevos.alimen3.Chauchas;
              datosGuardados.alimen3.Lentejas = datosNuevos.alimen3.Lentejas;
              datosGuardados.alimen3.MilanesasSoja = datosNuevos.alimen3.MilanesasSoja;
              datosGuardados.alimen3.PorotosComunes = datosNuevos.alimen3.PorotosComunes;
              datosGuardados.alimen3.PorotosSoja = datosNuevos.alimen3.PorotosSoja;
              datosGuardados.alimen3.BrotesSoja = datosNuevos.alimen3.BrotesSoja;

              model.SaveChanges();
          }







          public ClasificacionAlimentacion1_2_3ViewModel getDatosGuardados()
          {
              crearDatosSiNoExiste();
              var clasificacion = new ClasificacionAlimentacion1_2_3ViewModel();
              clasificacion.alimen1 = model.ClasificacionAlimentacion.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                          .First();
              clasificacion.alimen2 = model.ClasificacionAlimentacion2.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                          .First();
              clasificacion.alimen3 = model.ClasificacionAlimentacion3.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                        .First();

              return clasificacion;

          }


          private void crearDatosSiNoExiste()
          {
              var hayDatosc1 =
                      model.ClasificacionAlimentacion.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
              var hayDatosc2 =
                      model.ClasificacionAlimentacion2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
              var hayDatosc3 =
                    model.ClasificacionAlimentacion3.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

              if (!hayDatosc1)
              {
                  var antecedentesc1 = new ClasificacionAlimentacion()
                  {
                      Usuario = getUsuario(idUsuario)
                  };
                  model.ClasificacionAlimentacion.AddObject(antecedentesc1);
              }
              if (!hayDatosc2)
              {
                  var antecedentesc2 = new ClasificacionAlimentacion2()
                  {
                      Usuario = getUsuario(idUsuario)
                  };
                  model.ClasificacionAlimentacion2.AddObject(antecedentesc2);
              }
              if (!hayDatosc3)
              {
                  var antecedentesc3 = new ClasificacionAlimentacion3()
                  {
                      Usuario = getUsuario(idUsuario)
                  };


                  model.ClasificacionAlimentacion3.AddObject(antecedentesc3);
              }
              model.SaveChanges();

          }
    }