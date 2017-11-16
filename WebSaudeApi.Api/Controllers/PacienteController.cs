using System;
using System.Linq;
using System.Web.Http;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Api.Controllers
{
    [Auth]
    [RoutePrefix("")]
    public class PacienteController : ApiController
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        /// <summary>
        ///     Listar todos os pacientes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("pacientes")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var pacientes = _pacienteService.GetAll();
                if (pacientes == null || !pacientes.Any())
                {
                    return NotFound();
                }

                return Ok(pacientes);
            }
            catch (Exception e)
            {
                throw new Exception("erro consultar :" + e.Message);
            }
        }
    }
}