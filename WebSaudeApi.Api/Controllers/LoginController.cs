using System;
using System.Net;
using System.Web.Http;
using WebSaude.Application.Interface;

namespace WebSaude.Api.Controllers
{
    [AuthLogin]
    [RoutePrefix("")]
    public class LoginController : ApiController
    {
        private readonly IProfissionalAcesso _pacienteApp;

        public LoginController(IPacienteAppService pacienteApp)
        {
            _pacienteApp = pacienteApp;
        }

        /// <summary>
        ///     Autenticar na API
        /// </summary>
        /// <returns>Autenticar na API utilizando usuario e senha pré cadastrados</returns>
        [HttpGet]
        [Route("login")]
        public IHttpActionResult Listar([FromUri] string email, [FromUri] string senha)
        {
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
            {
                try
                {
                    var resultado = _profissionaisAppService.Login(email, senha);

                    return Ok(resultado);
                }
                catch (Exception e)
                {
                    return Content(HttpStatusCode.Unauthorized, e.Message);
                }
            }
            return Content(HttpStatusCode.Unauthorized, "Email ou Senha inválidos");
        }
    }
}