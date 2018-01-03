using System;
using System.Linq;
using System.Web.Http;
using WebSaude.Domain.Commands;
using WebSaude.Domain.Entities;
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
                throw new Exception("erro ao consultar :" + e.Message);
            }
        }

        /// <summary>
        /// Incluir paciente
        /// </summary>
        /// <param name="pacienteInclusao">Dados paciente</param>
        /// <remarks>Incluir paciente</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Incluir paciente</returns>
        [HttpPost]
        [Route("pacientes")]
        public IHttpActionResult Add([FromBody] PacienteCommand pacienteInclusao)
        {
            try
            {
                _pacienteService.Add(Paciente.Criar(pacienteInclusao));

                var paciente = _pacienteService.GetAll().LastOrDefault();

                if (paciente == null)
                {
                    return NotFound();
                }

                return Ok(paciente);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao incluir :" + e.Message);
            }
        }

        /// <summary>
        /// Alterar paciente
        /// </summary>
        /// <param name="id">Id do paciente a ser alterado</param>
        /// <param name="pacienteAlteracao">Dados paciente</param>
        /// <remarks>Alterar paciente</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Alterar paciente</returns>
        [HttpPut]
        [Route("pacientes/{id}")]
        public IHttpActionResult Update(int id, [FromBody] PacienteCommand pacienteAlteracao)
        {
            try
            {
                var paciente = _pacienteService.GetById(id);

                if (paciente == null)
                {
                    return NotFound();
                }

                Paciente.Alterar(paciente, pacienteAlteracao);

                _pacienteService.Update(paciente);
                
                return Ok(paciente);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar :" + e.Message);
            }
        }

        /// <summary>
        /// Excluir paciente
        /// </summary>
        /// <param name="id">Id do paciente a ser Excluido</param>
        /// <remarks>Excluir paciente</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Excluir paciente</returns>
        [HttpDelete]
        [Route("pacientes/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var paciente = _pacienteService.GetById(id);

                if (paciente == null)
                {
                    return NotFound();
                }

                _pacienteService.Remove(paciente);

                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir :" + e.Message);
            }
        }
    }
}