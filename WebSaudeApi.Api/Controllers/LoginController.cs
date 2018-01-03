using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebSaude.Domain.Commands;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Api.Controllers
{
    [AuthLogin]
    [RoutePrefix("")]
    public class LoginController : ApiController
    {
        private readonly IProfissionalAcessoService _profissionalAcessoService;

        public LoginController(IProfissionalAcessoService profissionalAcessoService)
        {
            _profissionalAcessoService = profissionalAcessoService;
        }

        /// <summary>
        ///     Autenticar na API
        /// </summary>
        /// <param name="autenticacao">Dados Autenticacao</param>
        /// <remarks>Autenticar na API utilizando usuario e senha pré cadastrados</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Autenticar na API utilizando usuario e senha pré cadastrados</returns>
        [HttpPost]
        [ResponseType(typeof(string))]
        [Route("login")]
        public IHttpActionResult Autenticar([FromBody] AutenticacaoCommand autenticacao)
        {
            if (string.IsNullOrWhiteSpace(autenticacao?.Email) || string.IsNullOrWhiteSpace(autenticacao.Senha))
                return Content(HttpStatusCode.Unauthorized, "Email ou Senha inválidos");

            try
            {
                var resultado = _profissionalAcessoService.Login(autenticacao.Email, autenticacao.Senha);

                return Ok(resultado);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.Unauthorized, e.Message);
            }
        }

        /// <summary>
        ///     Logout da API
        /// </summary>
        /// <param name="email">Email Logout</param>
        /// <remarks>Logout da API utilizando email pré cadastrados</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <returns>Logout da API utilizando email pré cadastrados</returns>
        [HttpPost]
        [Route("logout")]
        public IHttpActionResult Logout([FromBody] EmailCommand email)
        {
            if (string.IsNullOrWhiteSpace(email?.Email))
                return Content(HttpStatusCode.Unauthorized, "Email inválido");

            try
            {
                if (_profissionalAcessoService.Logout(email.Email))
                    return Ok();

                return BadRequest();
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.Unauthorized, e.Message);
            }
        }
    }
}