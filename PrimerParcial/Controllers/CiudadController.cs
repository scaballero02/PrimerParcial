using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace PrimerParcial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CiudadController : Controller
    {
        // GET: CiudadController
        /*private string ConnectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=1234;";*/
        private CiudadService CiudadService;
        private IConfiguration configuration;

        /*public CiudadController()*/
        public CiudadController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.CiudadService = new CiudadService(configuration.GetConnectionString("postgresDB"));
        }

        [HttpGet("ListarCiudad")]
        public ActionResult<List<CiudadModel>> ListarCiudad()
        {
            var resultado = CiudadService.listarCiudad();
            return Ok(resultado);
        }

        [HttpGet("ConsultarCiudad/{id}")]
        /*public ActionResult<CiudadModel> getById(int id, string documento)*/
        public ActionResult<CiudadModel> ConsultarCiudad(int id)
        {
            var result = this.CiudadService.consultarCiudad(id);
            return Ok(result);
        }

        [HttpPost("InsertarCiudad")]
        public ActionResult<string> insertarCiudad(CiudadModel models)
        {
            /*return Ok("Ok");*/
            var result = this.CiudadService.insertarCiudad(new Infraestructure.Models.CiudadModel
            {
                Estado = models.Estado,
                Ciudad = models.Ciudad,
            });
            return Ok(result);
        }
        // endpoint for Ciudad modify
        [HttpPut("ModificarCiudad/{id}")]
        public ActionResult<string> modificarCiudad(CiudadModel models, int id)
        {
            var result = this.CiudadService.modificarCiudad(new Infraestructure.Models.CiudadModel
            {
                Estado = models.Estado,
                Ciudad = models.Ciudad,
            }, id);
            return Ok(result);
        }

        // endpoint for Ciudad delete
        [HttpDelete("EliminarCiudad/{id}")]
        public ActionResult<string> eliminar(int id)
        {
            var result = this.CiudadService.eliminarCiudad(id);
            return Ok(result);
        }
    }
}
