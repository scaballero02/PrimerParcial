using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Infraestructure.Models;

namespace Infraestructure.Repository
{
    public class ClienteRepository
    {
        private string _connectionString;
        private Npgsql.NpgsqlConnection connection;
        public ClienteRepository(string connectionString)
        {
            this._connectionString = connectionString;
            this.connection = new Npgsql.NpgsqlConnection(this._connectionString);
        }

        public string insertarCliente(ClienteModel cliente)
        {
            try
            {
                String query = "insert into cliente(nombre, apellido, idciudad, fechanacimiento, ciudad, nacionalidad, documento, email, telefono) " +
                    " values(@Nombre, @apellido, @idciudad, @Nacimiento, @ciudad, @nacionalidad, @documento, @email, @telefono)";
                connection.Open();
                connection.Execute(query, cliente);
                connection.Close();
                return "Se inserto correctamente...";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string modificarCliente(ClienteModel cliente, int id)
        {
            try
            {
                connection.Execute($"UPDATE cliente SET " +
                    "nombre = @nombre, " +
                    "apellido = @apellido, " +
                    "edad = @edad, " +
                    "email = @email, " +
                    "telefono = @telefono " +
                    $"WHERE id = {id}");
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string eliminarCliente(int id)
        {
            try
            {
                connection.Execute($" DELETE FROM cliente WHERE id = {id}");
                return "Se eliminó correctamente el registro...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteModel consultarCliente(int id)
        {
            try
            {
                return connection.QueryFirst<ClienteModel>($"SELECT * FROM cliente WHERE id = {id}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<ClienteModel> listarCliente()
        {
            try
            {
                return connection.Query<ClienteModel>($"SELECT * FROM cliente order by id asc");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}