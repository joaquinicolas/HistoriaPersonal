using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace HistoriaPersonalCormillot.Models
{
    public class DatosPersonalesMF
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime? Fecha { get; set; }
        public string NombreyApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string EstadoCivil { get; set; }
        public string ViveCon { get; set; }
        public int? Hijos { get; set; }
        public string EdadesySexo { get; set; }
        public string ObraSocialoPrepago { get; set; }
        public int? NroAfiliado { get; set; }

        public virtual Usuario Usuario { get; set; }
        public Guid IdUsuario { get; set; }
    }
}