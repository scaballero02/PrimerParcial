using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get;  set; }

        [Required(ErrorMessage = "La ciudad es requerido")]
        public string Ciudad { get;  set; }

        [Required(ErrorMessage = "El idCiudad es requerido")]
        public int IdCiudad { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerido")]
        [DataType(DataType.Date)]
        public string FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La nacionalidad es requerida")]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "El documento es requerido")]
        public string Documento { get; set; }

    }
}
