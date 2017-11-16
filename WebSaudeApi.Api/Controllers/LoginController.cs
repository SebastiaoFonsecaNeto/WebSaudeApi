using System;
using System.Net;
using System.Web.Http;
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
        /// <returns>Autenticar na API utilizando usuario e senha pré cadastrados</returns>
        [HttpGet]
        [Route("login")]
        public IHttpActionResult Autenticar(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                return Content(HttpStatusCode.Unauthorized, "Email ou Senha inválidos");

            try
            {
                var resultado = _profissionalAcessoService.Login(email, senha);

                return Ok(resultado);
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.Unauthorized, e.Message);
            }
        }
    }
}