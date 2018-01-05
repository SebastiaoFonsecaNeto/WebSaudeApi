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
    public class ProfissionalController : ApiController
    {
        private readonly IProfissionalService _profissionalService;

        public ProfissionalController(IProfissionalService profissionalService)
        {
            _profissionalService = profissionalService;
        }

        /// <summary>
        ///     Listar todos os profissionais cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("profissionais")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var profissionais = _profissionalService.GetAll();
                
                if (profissionais == null || !profissionais.Any())
                {
                    return NotFound();
                }

                return Ok(profissionais);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao consultar :" + e.Message);
            }
        }

        /// <summary>
        /// Incluir profissional
        /// </summary>
        /// <param name="profissionalInclusao">Dados profissional</param>
        /// <remarks>Incluir profissional</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Incluir profissional</returns>
        [HttpPost]
        [Route("profissionais")]
        public IHttpActionResult Add([FromBody] ProfissionalCommand profissionalInclusao)
        {
            try
            {
                _profissionalService.Add(Profissional.Criar(profissionalInclusao));

                var profissional = _profissionalService.GetAll().LastOrDefault();

                if (profissional == null)
                {
                    return NotFound();
                }

                return Ok(profissional);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao incluir :" + e.Message);
            }
        }

        /// <summary>
        /// Alterar profissional
        /// </summary>
        /// <param name="id">Id do profissional a ser alterado</param>
        /// <param name="profissionalAlteracao">Dados profissional</param>
        /// <remarks>Alterar profissional</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Alterar profissional</returns>
        [HttpPut]
        [Route("profissionais/{id}")]
        public IHttpActionResult Update(int id, [FromBody] ProfissionalCommand profissionalAlteracao)
        {
            try
            {
                var profissional = _profissionalService.GetById(id);

                if (profissional == null)
                {
                    return NotFound();
                }

                Profissional.Alterar(profissional, profissionalAlteracao);

                _profissionalService.Update(profissional);
                
                return Ok(profissional);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar :" + e.Message);
            }
        }

        /// <summary>
        /// Excluir profissional
        /// </summary>
        /// <param name="id">Id do profissional a ser Excluido</param>
        /// <remarks>Excluir profissional</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Excluir profissional</returns>
        [HttpDelete]
        [Route("profissionais/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var profissional = _profissionalService.GetById(id);

                if (profissional == null)
                {
                    return NotFound();
                }

                _profissionalService.Remove(profissional);

                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir :" + e.Message);
            }
        }
    }
}