using HistoriaPersonalCormillot;
using System;
using System.Collections.Generic;
using System.Linq;
using HistoriaPersonalCormillot.ViewModels;
public  class HabitosChild: Habitos
{
    private CormillotHistoriaPersonalCustomEntities model = new CormillotHistoriaPersonalCustomEntities();
    private HistoriaPersonalCormillot.Habitos habitos = new HistoriaPersonalCormillot.Habitos();
    
    public HabitosChild(HistoriaPersonalCormillot.Habitos habitos)
    {
        this.habitos = habitos;
    }

    public HabitosChild()
    {
    }

    public bool save(HistoriaPersonalCormillot.Habitos h)
    {
        try
        {
            if (h != null)
            {
                if (!existe(h.IdUsuario))
                {
                    model.Habitos.AddObject(h);
                    model.SaveChanges();
                }
                else
                {
                    this.habitos = h;
                   return Update();
                }
            }
            else
            {
                throw new System.ArgumentException("El objeto de tipo Habitos no puede ser null");
            }

            return true;
        }


        catch(Exception e)
        {
            return false;
        }
    }

    public Habitos getHabitos(int id_user)
    {
        var hab = new Habitos();
        try
        {
             hab = (from h in model.Habitos where h.IdUsuario == id_user select h).First();
        }
        catch
        {
            hab = new Habitos();
        }
        return hab;
    }

    private bool existe(int id_user)
    {
        if ((from h in model.Habitos where h.IdUsuario == id_user select h).Count() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Update()
    {
        try
        {
            Habitos h = (from m in model.Habitos where m.IdUsuario == this.habitos.IdUsuario select m).First();
            h.IdUsuario = habitos.IdUsuario != null ? habitos.IdUsuario:h.IdUsuario;
            h.DificultadParaQuedarseDormido = habitos.DificultadParaQuedarseDormido != null ? habitos.DificultadParaQuedarseDormido:h.DificultadParaQuedarseDormido;
            h.SeDespiertaDuranteLaNoche = habitos.SeDespiertaDuranteLaNoche != null ? habitos.SeDespiertaDuranteLaNoche : h.SeDespiertaDuranteLaNoche;
            h.TienePesadillas = habitos.TienePesadillas != null ? habitos.TienePesadillas : h.TienePesadillas;
            h.DuermeDeDia = habitos.DuermeDeDia != null ? habitos.DuermeDeDia : h.DuermeDeDia;
            h.TomaPastillas = habitos.TomaPastillas != null ? habitos.TomaPastillas : h.TomaPastillas;
            h.Fuma = habitos.Fuma != null ? habitos.Fuma : h.Fuma;
            h.CuantosCigarrillosPorDia = habitos.CuantosCigarrillosPorDia != null ? habitos.CuantosCigarrillosPorDia : h.CuantosCigarrillosPorDia;
            h.DejeFumarHace = habitos.DejeFumarHace != null ? habitos.DejeFumarHace : h.DejeFumarHace;
            h.VasosVino = habitos.VasosVino != null ? habitos.VasosVino : h.VasosVino;
            h.CervezaLatas = habitos.CervezaLatas != null ? habitos.CervezaLatas : h.CervezaLatas;
            h.BlancasMedidas = habitos.BlancasMedidas != null ? habitos.BlancasMedidas : h.BlancasMedidas;
            h.OtrasMedidas = habitos.OtrasMedidas != null ? habitos.OtrasMedidas : h.OtrasMedidas;
            h.PreocupaManeraBeber = habitos.PreocupaManeraBeber != null ? habitos.PreocupaManeraBeber : h.PreocupaManeraBeber;
            h.SienteCulpa = habitos.SienteCulpa != null ? habitos.SienteCulpa : h.SienteCulpa;
            h.IntentoDejarBeber = habitos.IntentoDejarBeber != null ? habitos.IntentoDejarBeber : h.IntentoDejarBeber;
            h.LlamadoAtencion = habitos.LlamadoAtencion != null ? habitos.LlamadoAtencion : h.LlamadoAtencion;
            h.TomaCalmarse = habitos.TomaCalmarse != null ? habitos.TomaCalmarse : false;
            h.TomaASolas = habitos.TomaASolas != null ? habitos.TomaASolas : false;
            h.ActitudPadres = habitos.ActitudPadres != null ? habitos.ActitudPadres : h.ActitudPadres;
            h.ActitudHermanos = habitos.ActitudHermanos != null ? habitos.ActitudHermanos : h.ActitudHermanos;
            h.ActitudConyuge = habitos.ActitudConyuge != null ? habitos.ActitudConyuge : h.ActitudConyuge;
            h.ActitudHijos = habitos.ActitudHijos != null ? habitos.ActitudHijos : h.ActitudHijos;
            h.ActitudAmigos = habitos.ActitudAmigos != null ? habitos.ActitudAmigos : h.ActitudAmigos;
            h.ActitudCompañeros = habitos.ActitudCompañeros != null ? habitos.ActitudCompañeros : h.ActitudCompañeros;
            h.RelacionHijos = habitos.RelacionHijos !=null ? habitos.RelacionHijos : h.RelacionHijos;
            h.RelacionAmigos = habitos.RelacionAmigos != null ? habitos.RelacionAmigos : h.RelacionAmigos;
            h.RelacionPareja = habitos.RelacionPareja != null ? habitos.RelacionPareja : h.RelacionPareja;
            h.RelacionFamilia = habitos.RelacionFamilia != null ? habitos.RelacionFamilia : h.RelacionFamilia;
            h.RelacionCompañerosTrabajo = habitos.RelacionCompañerosTrabajo != null ? habitos.RelacionCompañerosTrabajo : h.RelacionCompañerosTrabajo;
            h.HorasSueño = habitos.HorasSueño != null ? habitos.HorasSueño : h.HorasSueño;
            h.IntentoCambiarBebida = habitos.IntentoCambiarBebida != null ? habitos.IntentoCambiarBebida : h.IntentoCambiarBebida;
            h.ParaDormirToma = habitos.ParaDormirToma != null ? habitos.ParaDormirToma : false;

            model.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {  
            return false;
        }
    }
}