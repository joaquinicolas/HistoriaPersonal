using System.Linq;
using HistoriaPersonalCormillot.ViewModels;
using HistoriaPersonalCormillot;

    public class Habitos2AllegadosViewModelValidaciones:PasosValidaciones
    {    private int idUsuario;

    public Habitos2AllegadosViewModelValidaciones(int idUsuario)
        {
        this.idUsuario = idUsuario;
        }


    public void save(Habitos2AllegadosViewModel datos)
    {    //SusAllegadosRelacionConLaComida
        var datosGuardados = getDatosGuardados();
        datosGuardados.allegadosrelcom.CantPesoNormal = datos.allegadosrelcom.CantPesoNormal;
        datosGuardados.allegadosrelcom.TienenPesoNormal = datos.allegadosrelcom.TienenPesoNormal;
        datosGuardados.allegadosrelcom.CantSobrepeso = datos.allegadosrelcom.CantSobrepeso;
        datosGuardados.allegadosrelcom.TienenSobrepeso = datos.allegadosrelcom.TienenSobrepeso;
        datosGuardados.allegadosrelcom.RadioUrgenciaDeComer = datos.allegadosrelcom.RadioUrgenciaDeComer;
        datosGuardados.allegadosrelcom.RadioComeDeNoche = datos.allegadosrelcom.RadioComeDeNoche;
        datosGuardados.allegadosrelcom.RadioComeParaDormir = datos.allegadosrelcom.RadioComeParaDormir;
        datosGuardados.allegadosrelcom.RadioComeSinControl = datos.allegadosrelcom.RadioComeSinControl;
        datosGuardados.allegadosrelcom.RadioLaxantes = datos.allegadosrelcom.RadioLaxantes;
        datosGuardados.allegadosrelcom.RadioDiureticos = datos.allegadosrelcom.RadioDiureticos;
        datosGuardados.allegadosrelcom.RadioInduceVomito = datos.allegadosrelcom.RadioInduceVomito;
        datosGuardados.allegadosrelcom.RadioRestringeAlimento = datos.allegadosrelcom.RadioRestringeAlimento;
        datosGuardados.allegadosrelcom.RadioActFisicaExagerada = datos.allegadosrelcom.RadioActFisicaExagerada;
        datosGuardados.allegadosrelcom.CantPesoNormal = datos.allegadosrelcom.CantPesoNormal;
        datosGuardados.allegadosrelcom.CantSobrepeso = datos.allegadosrelcom.CantSobrepeso;
        datosGuardados.allegadosrelcom.TienenPesoNormal = datos.allegadosrelcom.TienenPesoNormal;
        datosGuardados.allegadosrelcom.TienenSobrepeso = datos.allegadosrelcom.TienenSobrepeso;
        //SusHabitos2

        datosGuardados.habitos2.ActitudPadres = datos.habitos2.ActitudPadres;
        datosGuardados.habitos2.ActitudHermanos = datos.habitos2.ActitudHermanos;
        datosGuardados.habitos2.ActitudConyuge = datos.habitos2.ActitudConyuge;
        datosGuardados.habitos2.ActitudHijos = datos.habitos2.ActitudHijos;
        datosGuardados.habitos2.ActitudAmigos = datos.habitos2.ActitudAmigos;
        datosGuardados.habitos2.ActitudCompañeros = datos.habitos2.ActitudCompañeros;

        datosGuardados.habitos2.RelacionHijos = datos.habitos2.RelacionHijos;
        datosGuardados.habitos2.RelacionAmigos = datos.habitos2.RelacionAmigos;
        datosGuardados.habitos2.RelacionPareja = datos.habitos2.RelacionPareja;
        datosGuardados.habitos2.RelacionFamilia = datos.habitos2.RelacionFamilia;
        datosGuardados.habitos2.RelacionCompañerosTrabajo = datos.habitos2.RelacionCompañerosTrabajo;
        

        model.SaveChanges();
       
    }





    public Habitos2AllegadosViewModel getDatosGuardados()
    {
        crearDatosSiNoExiste();
        var habitosAllegados = new Habitos2AllegadosViewModel();
        habitosAllegados.allegadosrelcom = model.SusAllegadosSuRelacionConLaComida.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                    .First();
        habitosAllegados.habitos2 = model.SusHabitos2.Where(rtm => rtm.Usuario.Id == idUsuario).OrderBy(rtm => rtm.Id)
                                    .First();
      
        return habitosAllegados;

    }





    private void crearDatosSiNoExiste()
    {
        var hayDatosA =
                model.SusAllegadosSuRelacionConLaComida.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;
        var hayDatosH2 =
                model.SusHabitos2.Where(dp => dp.Usuario.Id == idUsuario).Count() > 0;

        if (!hayDatosA)
        {
            var antecedentes = new SusAllegadosSuRelacionConLaComida()
            {
                Usuario = getUsuario(idUsuario)
            };
            model.SusAllegadosSuRelacionConLaComida.AddObject(antecedentes);
        }
        if (!hayDatosH2)
        {
            var antecedentesH = new SusHabitos2()
            {
                Usuario = getUsuario(idUsuario)
            };


            model.SusHabitos2.AddObject(antecedentesH);
        }
        model.SaveChanges();

    }
    }
