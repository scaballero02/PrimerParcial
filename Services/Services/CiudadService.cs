using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CiudadService
    {

        private CiudadRepository repositoryCiudad;

        public CiudadService(string connectionString)
        {
            this.repositoryCiudad = new CiudadRepository(connectionString);
        }

        public string insertarCiudad(CiudadModel Ciudad)
        {
            return validarDatosCiudad(Ciudad) ? repositoryCiudad.insertarCiudad(Ciudad) : throw new Exception("Error en la validacion");
        }

        public string modificarCiudad(CiudadModel Ciudad, int id)
        {
            return validarDatosCiudad(Ciudad) ? repositoryCiudad.modificarCiudad(Ciudad, id) : throw new Exception("Error en la validacion");
        }

        public string eliminarCiudad(int id)
        {
            return repositoryCiudad.eliminarCiudad(id);
        }

        public CiudadModel consultarCiudad(int id)
        {
            return repositoryCiudad.consultarCiudad(id);
        }

        public IEnumerable<CiudadModel> listarCiudad()
        {
            return repositoryCiudad.listarCiudad();
        }

        private bool validarDatosCiudad(CiudadModel Ciudad)
        {
            /*if (Ciudad.Nombre.Trim().Length > 2)
            {
                return false;
            }*/

            return true;
        }
    }
}
