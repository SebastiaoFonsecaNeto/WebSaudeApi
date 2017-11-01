using System;
using System.Web.Http;
using WebSaude.Application.Interface;

namespace WebSaude.Api.Controllers
{
    [RoutePrefix("")]
    public class PacienteController : ApiController
    {
        private readonly IPacienteAppService _pacienteApp;

        public PacienteController(IPacienteAppService pacienteApp)
        {
            _pacienteApp = pacienteApp;
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
                var pacientes = _pacienteApp.GetAll();
                if (pacientes == null)
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