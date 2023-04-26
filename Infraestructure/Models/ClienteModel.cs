using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get;  set; }
        public string Ciudad { get;  set; }
        public int IdCiudad { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Nacionalidad { get; set; }
        public string Documento { get; set; }

    }
}
