using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoriaPersonalCormillot.Models
{
    public class RegistroComidas
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Fecha { get; set; }
        public string FranjaHoraria { get; set;}
        public string Hora { get; set; }
        public string Cantidad { get; set; }
        public string Alimento { get; set; }
        public int Creditos { get; set; }
        public int Apetito { get; set; }
    }
}