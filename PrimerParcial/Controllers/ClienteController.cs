using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace PrimerParcial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        // GET: ClienteController
        /*private string ConnectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=1234;";*/
        private ClienteService ClienteService;
        private IConfiguration configuration;

        /*public ClienteController()*/
        public ClienteController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.ClienteService = new ClienteService(configuration.GetConnectionString("postgresDB"));
        }

        [HttpGet("ListarCliente")]
        public ActionResult<List<ClienteModel>> ListarCliente()
        {
            var resultado = ClienteService.listarCliente();
            return Ok(resultado);
        }
       
        [HttpGet("ConsultarCliente/{id}")]
        /*public ActionResult<ClienteModel> getById(int id, string documento)*/
        public ActionResult<ClienteModel> ConsultarCliente(int id)
        {
            var result = this.ClienteService.consultarCliente(id);
            return Ok(result);
        }


        [HttpPost("InsertarCliente")]
        public ActionResult<string> insert(ClienteModel models)
        {
            /*return Ok("Ok");*/
            var result = this.ClienteService.insertarCliente(new Infraestructure.Models.ClienteModel
            {
                Nombre = models.Nombre,
                Apellido = models.Apellido,
                Email = models.Email,
                IdCiudad = models.IdCiudad,
                Telefono = models.Telefono,
                Nacimiento = models.Nacimiento,
                Documento = models.Documento,
                Ciudad = models.Ciudad,
                Nacionalidad = models.Nacionalidad,
            });
            return Ok(result);
        }
        // endpoint for Cliente modify
        [HttpPut("ModificarCliente/{id}")]
        public ActionResult<string> modificarCliente(ClienteModel models, int id)
        {
            var result = this.ClienteService.modificarCliente(new Infraestructure.Models.ClienteModel
            {
                Nombre = models.Nombre,
                Apellido = models.Apellido,
                Email = models.Email,
                IdCiudad = models.IdCiudad,
                Telefono = models.Telefono,
                Nacimiento = models.Nacimiento,
                Documento = models.Documento,
                Ciudad = models.Ciudad,
                Nacionalidad = models.Nacionalidad,
            }, id);
            return Ok(result);
        }

        // endpoint for Cliente delete
        [HttpDelete("EliminarCliente/{id}")]
        public ActionResult<string> eliminar(int id)
        {
            var result = this.ClienteService.eliminarCliente(id);
            return Ok(result);
        }
    }
}
