using System.Linq;
using HistoriaPersonalCormillot;
using HistoriaPersonalCormillot.ViewModels;


 public class ClasificacionAlimentacion3_4_5_6ViewModelValidaciones:PasosValidaciones
 {
     
          private int idUsuario;

          public ClasificacionAlimentacion3_4_5_6ViewModelValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }
          public void save(ClasificacionAlimentacion3_4_5_6ViewModel datosNuevos)
          {   
              var datosGuardados = getDatosGuardados();
              //Calsificacion Alimentacion 3

              datosGuardados.aliment3.ArrozBlanco = datosNuevos.aliment3.ArrozBlanco;
              datosGuardados.aliment3.ArrozIntegral = datosNuevos.aliment3.ArrozIntegral;
              datosGuardados.aliment3.AvenaArrollada = datosNuevos.aliment3.AvenaArrollada;
              datosGuardados.aliment3.BarrasCereal = datosNuevos.aliment3.BarrasCereal;
              datosGuardados.aliment3.CoposCereal = datosNuevos.aliment3.CoposCereal;
              datosGuardados.aliment3.GalletasArroz = datosNuevos.aliment3.GalletasArroz;
              datosGuardados.aliment3.GalletitasAgua = datosNuevos.aliment3.GalletitasAgua;
              datosGuardados.aliment3.GalletitasDulces = datosNuevos.aliment3.GalletitasDulces;
              datosGuardados.aliment3.Mueslix = datosNuevos.aliment3.Mueslix;
              datosGuardados.aliment3.PanArabe = datosNuevos.aliment3.PanArabe;
              datosGuardados.aliment3.PanBaguette = datosNuevos.aliment3.PanBaguette;
              datosGuardados.aliment3.PanBlanco = datosNuevos.aliment3.PanBlanco;
              datosGuardados.aliment3.PanSalvado = datosNuevos.aliment3.PanSalvado;

              //Clasificacion Alimentacion 4

              datosGuardados.aliment4.PastasRellenas = datosNuevos.aliment4.PastasRellenas;
              datosGuardados.aliment4.PastasSimples = datosNuevos.aliment4.PastasSimples;
              datosGuardados.aliment4.Pochoclo = datosNuevos.aliment4.Pochoclo;
              datosGuardados.aliment4.Polenta = datosNuevos.aliment4.Polenta;
              datosGuardados.aliment4.TrigoInflado = datosNuevos.aliment4.TrigoInflado;
              datosGuardados.aliment4.Empanadas = datosNuevos.aliment4.Empanadas;
              datosGuardados.aliment4.Pizza = datosNuevos.aliment4.Pizza;
              datosGuardados.aliment4.Sandwiches = datosNuevos.aliment4.Sandwiches;

              datosGuardados.aliment4.CremaDeLeche = datosNuevos.aliment4.CremaDeLeche;
              datosGuardados.aliment4.Ketchup = datosNuevos.aliment4.Ketchup;
              datosGuardados.aliment4.Mayonesa = datosNuevos.aliment4.Mayonesa;
              datosGuardados.aliment4.Mostaza = datosNuevos.aliment4.Mostaza;
              datosGuardados.aliment4.SalsaBlanca = datosNuevos.aliment4.SalsaBlanca;
              datosGuardados.aliment4.SalsaBoloniesa = datosNuevos.aliment4.SalsaBoloniesa;
              datosGuardados.aliment4.SalsaCuatroQuesos = datosNuevos.aliment4.SalsaCuatroQuesos;
              datosGuardados.aliment4.SalsaSoja = datosNuevos.aliment4.SalsaSoja;
              datosGuardados.aliment4.SalsaTomate = datosNuevos.aliment4.SalsaTomate;
              datosGuardados.aliment4.SalsaGolf = datosNuevos.aliment4.SalsaGolf;

              datosGuardados.aliment4.Aceitunas = datosNuevos.aliment4.Aceitunas;
              datosGuardados.aliment4.Ajies = datosNuevos.aliment4.Ajies;
              datosGuardados.aliment4.Cebollitas = datosNuevos.aliment4.Cebollitas;
              datosGuardados.aliment4.Pepinitos = datosNuevos.aliment4.Pepinitos;
              datosGuardados.aliment4.Pickles = datosNuevos.aliment4.Pickles;

              datosGuardados.aliment4.Anana = datosNuevos.aliment4.Anana;
              datosGuardados.aliment4.Banana = datosNuevos.aliment4.Banana;
              datosGuardados.aliment4.Cereza = datosNuevos.aliment4.Cereza;
              datosGuardados.aliment4.Ciruela = datosNuevos.aliment4.Ciruela;
              datosGuardados.aliment4.Damasco = datosNuevos.aliment4.Damasco;
              datosGuardados.aliment4.Durazno = datosNuevos.aliment4.Durazno;
              datosGuardados.aliment4.Frutilla = datosNuevos.aliment4.Frutilla;
              datosGuardados.aliment4.Kiwi = datosNuevos.aliment4.Kiwi;
              datosGuardados.aliment4.Mandarina = datosNuevos.aliment4.Mandarina;
              datosGuardados.aliment4.Manzana = datosNuevos.aliment4.Manzana;
              datosGuardados.aliment4.Melon = datosNuevos.aliment4.Melon;

              ////Clasificacion Alimentacion 5
              datosGuardados.aliment5.Naranja = datosNuevos.aliment5.Naranja;
              datosGuardados.aliment5.Pera = datosNuevos.aliment5.Pera;
              datosGuardados.aliment5.Pomelo = datosNuevos.aliment5.Pomelo;
              datosGuardados.aliment5.Sandía = datosNuevos.aliment5.Sandía;
              datosGuardados.aliment5.Uva = datosNuevos.aliment5.Uva;

              datosGuardados.aliment5.EnvasadosAnana = datosNuevos.aliment5.EnvasadosAnana;
              datosGuardados.aliment5.EnvasadosDuraznos = datosNuevos.aliment5.EnvasadosDuraznos;
              datosGuardados.aliment5.EnvasadosEnsaladaFrutas = datosNuevos.aliment5.EnvasadosEnsaladaFrutas;
              datosGuardados.aliment5.EnvasadosPeras = datosNuevos.aliment5.EnvasadosPeras;

              datosGuardados.aliment5.DeshidratasCiruela = datosNuevos.aliment5.DeshidratasCiruela;
              datosGuardados.aliment5.DeshidratasDamasco = datosNuevos.aliment5.DeshidratasDamasco;
              datosGuardados.aliment5.DeshidratasManzana = datosNuevos.aliment5.DeshidratasManzana;
              datosGuardados.aliment5.DeshidratasOrejones = datosNuevos.aliment5.DeshidratasOrejones;
              datosGuardados.aliment5.DeshidratasPasasDeUva = datosNuevos.aliment5.DeshidratasPasasDeUva;

              datosGuardados.aliment5.Almendras = datosNuevos.aliment5.Almendras;
              datosGuardados.aliment5.Avellanas = datosNuevos.aliment5.Avellanas;
              datosGuardados.aliment5.Manies = datosNuevos.aliment5.Manies;
              datosGuardados.aliment5.Nueces = datosNuevos.aliment5.Nueces;

              datosGuardados.aliment5.Aceite = datosNuevos.aliment5.Aceite;
              datosGuardados.aliment5.Manteca = datosNuevos.aliment5.Manteca;

              datosGuardados.aliment5.ArrrozConLeche = datosNuevos.aliment5.ArrrozConLeche;
              datosGuardados.aliment5.Flan = datosNuevos.aliment5.Flan;
              datosGuardados.aliment5.Gelatina = datosNuevos.aliment5.Gelatina;
              datosGuardados.aliment5.Helado = datosNuevos.aliment5.Helado;
              datosGuardados.aliment5.Mousse = datosNuevos.aliment5.Mousse;
              datosGuardados.aliment5.PostresDeLeche = datosNuevos.aliment5.PostresDeLeche;

              datosGuardados.aliment5.Alfajores = datosNuevos.aliment5.Alfajores;
              datosGuardados.aliment5.BudinPan = datosNuevos.aliment5.BudinPan;
              datosGuardados.aliment5.Budines = datosNuevos.aliment5.Budines;
              datosGuardados.aliment5.Chocolates = datosNuevos.aliment5.Chocolates;
              datosGuardados.aliment5.CremaChantilly = datosNuevos.aliment5.CremaChantilly;
              datosGuardados.aliment5.DulceBatata = datosNuevos.aliment5.DulceBatata;

              ////Clasificacion Alimentacion 6
              datosGuardados.aliment6.DulceDeLeche = datosNuevos.aliment6.DulceDeLeche;
              datosGuardados.aliment6.Facturas = datosNuevos.aliment6.Facturas;
              datosGuardados.aliment6.Golosinas = datosNuevos.aliment6.Golosinas;
              datosGuardados.aliment6.Masitas = datosNuevos.aliment6.Masitas;

              datosGuardados.aliment6.Mermeladas = datosNuevos.aliment6.Mermeladas;
              datosGuardados.aliment6.Panqueques = datosNuevos.aliment6.Panqueques;
              datosGuardados.aliment6.Pastelitos = datosNuevos.aliment6.Pastelitos;
              datosGuardados.aliment6.Tortas = datosNuevos.aliment6.Tortas;

              datosGuardados.aliment6.Otros = datosNuevos.aliment6.Otros;

              model.SaveChanges();
          }








          public ClasificacionAlimentacion3_4_5_6ViewModel getDatosGuardados()
          {
              crearDatosSiNoExiste();
              var clasificacional = new ClasificacionAlimentacion3_4_5_6ViewModel();
              clasificacional.aliment3 = model.ClasificacionAlimentacion3.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                          .First();
              clasificacional.aliment4 = model.ClasificacionAlimentacion4.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                          .First();
              clasificacional.aliment5 = model.ClasificacionAlimentacion5.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                        .First();
              clasificacional.aliment6 = model.ClasificacionAlimentacion6.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                     .First();

              return clasificacional;

          }


          private void crearDatosSiNoExiste()
          {
              var hayDatosc3 =
                      model.ClasificacionAlimentacion3.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
              var hayDatosc4 =
                      model.ClasificacionAlimentacion4.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
              var hayDatosc5 =
                    model.ClasificacionAlimentacion5.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
              var hayDatosc6 =
               model.ClasificacionAlimentacion6.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

              if (!hayDatosc3)
              {
                  var antecedentesc3 = new ClasificacionAlimentacion3()
                  {
                      Usuario = getUsuario(idUsuario)
                  };
                  model.ClasificacionAlimentacion3.AddObject(antecedentesc3);
              }
              if (!hayDatosc4)
              {
                  var antecedentesc4 = new ClasificacionAlimentacion4()
                  {
                      Usuario = getUsuario(idUsuario)
                  };
                  model.ClasificacionAlimentacion4.AddObject(antecedentesc4);
              }
              if (!hayDatosc5)
              {
                  var antecedentesc5 = new ClasificacionAlimentacion5()
                  {
                      Usuario = getUsuario(idUsuario)
                  };


                  model.ClasificacionAlimentacion5.AddObject(antecedentesc5);
              }
              if (!hayDatosc6)
              {
                  var antecedentesc6 = new ClasificacionAlimentacion6()
                  {
                      Usuario = getUsuario(idUsuario)
                  };


                  model.ClasificacionAlimentacion6.AddObject(antecedentesc6);
              }
              model.SaveChanges();

          }
 }
