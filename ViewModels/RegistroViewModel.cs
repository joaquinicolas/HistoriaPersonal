using System.Collections.Generic;
namespace HistoriaPersonalCormillot.ViewModels
{
    public class RegistroViewModel
    {
        private string _NombreCompleto;
        public string NombreCompleto
        { get { return _NombreCompleto; } set { _NombreCompleto = value == null ? "" : value.Trim(); } }

        private string _Email;
        public string Email
        { get { return _Email; } set { _Email = value == null ? "" : value.Trim(); } }

        private string _Password;
        public string Password
        { get { return _Password; } set { _Password = value == null ? "" : value.Trim(); } }

        private string _Password2;
        public string Password2
        { get { return _Password2; } set { _Password2 = value == null ? "" : value.Trim(); } }

        private List<string> _ErroresValidacion;
        public List<string> ErroresValidacion
        {
            get 
            {
                if (_ErroresValidacion == null)
                {
                    _ErroresValidacion = new List<string>();
                }
                return _ErroresValidacion;
            }
            set 
            {
                _ErroresValidacion = value;
            }
        }
    }
}