using System.ComponentModel.DataAnnotations.Schema;

namespace HistoriaPersonalCormillot.Models
{
    public class UsuarioMF
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username {get; set;}
        public string Password {get; set;}
        public string Habilitado { get; set; }
        public string Formulario { get; set; }
        public System.Guid idx { get; set; }
    }
}