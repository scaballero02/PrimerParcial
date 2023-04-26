
using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services.Services
{
    public class ClienteService
    {
        private ClienteRepository repositoryCliente;

        public ClienteService(string connectionString)
        {
            this.repositoryCliente = new ClienteRepository(connectionString);
        }

        public string insertarCliente(ClienteModel Cliente)
        {
            return validarDatosCliente(Cliente) ? repositoryCliente.insertarCliente(Cliente) : throw new Exception("Error en la validacion");
        }

        public string modificarCliente(ClienteModel Cliente, int id)
        {
            return validarDatosCliente(Cliente) ? repositoryCliente.modificarCliente(Cliente, id) : throw new Exception("Error en la validacion");
        }

        public string eliminarCliente(int id)
        {
            return repositoryCliente.eliminarCliente(id);
        }

        public ClienteModel consultarCliente(int id)
        {
            return repositoryCliente.consultarCliente(id);
        }

        public IEnumerable<ClienteModel> listarCliente()
        {
            return repositoryCliente.listarCliente();
        }

        private bool validarDatosCliente(ClienteModel Cliente)
        {
            /*if (Cliente.Nombre.Trim().Length > 2)
            {
                return false;
            }*/

            return true;
        }
    }
}